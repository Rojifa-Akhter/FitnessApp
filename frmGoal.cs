using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FitnessApp1
{
    public partial class frmGoal : Form
    {
        // Define the connection string to your database
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CMM1ASO;Initial Catalog=Fitness;Integrated Security=True");

        public frmGoal()
        {
            InitializeComponent();
        }

        // Load event for form to populate ComboBox with activity types
        private void frmGoal_Load(object sender, EventArgs e)
        {
            
            cmbActivity.Items.AddRange(new string[] { "Running", "Swimming", "Cycling", "Walking" });
        }

        // Button click event to check and insert data into the database
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate goal input
                if (string.IsNullOrEmpty(txtGoal.Text) || !int.TryParse(txtGoal.Text, out int calorieGoal))
                {
                    MessageBox.Show("Please enter a valid calorie goal.");
                    return;
                }
                if (cmbActivity.SelectedItem == null)
                {
                    MessageBox.Show("Please select an activity type.");
                    return;
                }                
                string selectedActivity = cmbActivity.SelectedItem.ToString();// Get the selected activity type from ComboBox
                conn.Open();

                string insertQuery = "INSERT INTO UserGoals (ActivityType, GoalCalories) VALUES (@ActivityType, @GoalCalories)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);

                // Set the parameters
                cmd.Parameters.AddWithValue("@ActivityType", selectedActivity); 
                cmd.Parameters.AddWithValue("@GoalCalories", calorieGoal); // Calorie goal from txtGoal
                
                int result = cmd.ExecuteNonQuery();// Execute the query
               
                if (result > 0)
                {
                    MessageBox.Show("Goal added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add goal.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Button to close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
