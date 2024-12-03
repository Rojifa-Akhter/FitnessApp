using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApp1
{
    public partial class frmActivities : Form
    {
        // Class-level SqlConnection with connection string
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CMM1ASO;Initial Catalog=Fitness;Integrated Security=True");
        public frmActivities()
        {
            InitializeComponent();
            this.Load += frmActivities_Load;

        }
        private void frmActivities_Load(object sender, EventArgs e)
        {
            try
            {
                // Clear any existing data to avoid duplicates
                dataGridView1.DataSource = null;

                // Open the database connection
                conn.Open();

                // Define a SQL query to retrieve all data from tblActivities
                string Query = "SELECT * FROM tblActivities";
                SqlCommand cmd = new SqlCommand(Query, conn);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                // Set the DataTable as the DataSource for DataGridView if there's data
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data found in tblActivities.");
                }
            }
            catch (Exception ex)
            {
                // Show error message if there's an issue loading data
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                conn.Close();
            }
        }


        private void ClearForm()
        {
            txtUserId.Clear();
            txtDuration.Clear();
            txtDistance.Clear();
            txtCalories.Clear();
            txtSets.Clear();
            txtRepeat.Clear();
            txtPoses.Clear();
            txtElevation.Clear();
            cmbActivitytype.SelectedIndex = -1;
            dtActivityDate.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(txtUserId.Text) ||
                    cmbActivitytype.SelectedItem == null ||
                    string.IsNullOrEmpty(txtDuration.Text) ||
                    string.IsNullOrEmpty(txtDistance.Text) ||
                    string.IsNullOrEmpty(txtCalories.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (!int.TryParse(txtUserId.Text, out int UserID) ||
                    !int.TryParse(txtDuration.Text, out int Duration) ||
                    !float.TryParse(txtDistance.Text, out float Distance) ||
                    !float.TryParse(txtCalories.Text, out float Calories) ||
                    !int.TryParse(txtSets.Text, out int Sets) ||
                    !int.TryParse(txtRepeat.Text, out int Repetitions) ||
                    !int.TryParse(txtPoses.Text, out int posesCompleted) ||
                    !float.TryParse(txtElevation.Text, out float ElevationGain))
                {
                    MessageBox.Show("Please enter valid numeric values.");
                    return;
                }

                string ActivityType = cmbActivitytype.SelectedItem.ToString();
                DateTime ActivityDate = dtActivityDate.Value;

                string query = @"INSERT INTO tblActivities 
                 (UserID, ActivityType, Duration, Distance, Calories, Sets, Repetitions, PosesCompleted, ElevationGain, ActivityDate) 
                 VALUES (@UserID, @ActivityType, @Duration, @Distance, @Calories, @Sets, @Repetitions, @PosesCompleted, @ElevationGain, @ActivityDate)";

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@ActivityType", ActivityType);
                        cmd.Parameters.AddWithValue("@Duration", Duration);
                        cmd.Parameters.AddWithValue("@Distance", Distance);
                        cmd.Parameters.AddWithValue("@Calories", Calories);
                        cmd.Parameters.AddWithValue("@Sets", Sets);
                        cmd.Parameters.AddWithValue("@Repetitions", Repetitions);
                        cmd.Parameters.AddWithValue("@PosesCompleted", posesCompleted);
                        cmd.Parameters.AddWithValue("@ElevationGain", ElevationGain);
                        cmd.Parameters.AddWithValue("@ActivityDate", ActivityDate);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                            ClearForm();
                            
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data. Please try again.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            

        }


    }
}
