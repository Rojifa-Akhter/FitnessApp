using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FitnessApp1
{
    public partial class frmCalculation : Form
    {
        //database
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CMM1ASO;Initial Catalog=Fitness;Integrated Security=True");

        public frmCalculation()
        {
            InitializeComponent();
            LoadActivityTypes();
        }
        private void LoadActivityTypes()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ActivityType FROM UserGoal", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbActivitytype.Items.Add(reader["ActivityType"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading activity types: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

       


        // Method to get MET value for the selected activity from the database
        private double GetMetValue(string activity)
        {
            double metValue = 0;
            try
            {
                conn.Open();
                string query = "SELECT Duration FROM tblCalculateCalories WHERE ActivityType = @ActivityType";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ActivityType", activity);

                // Assuming that the MET value is stored in the Duration column for simplicity.
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    metValue = Convert.ToDouble(result);
                }
                else
                {
                    MessageBox.Show("Activity not found in database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching MET value: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return metValue;
        }

        // Method to insert the calories burned data into the database
        private void InsertCaloriesData(string activityType, int duration, double weight, double caloriesBurned)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO tblCalculateCalories (ActivityType, Duration, Weight, CaloriesBurned) VALUES (@ActivityType, @Duration, @Weight, @CaloriesBurned)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ActivityType", activityType);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@CaloriesBurned", caloriesBurned);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data inserted successfully into the database.");
                }
                else
                {
                    MessageBox.Show("Failed to insert data into the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Call the method to perform the calculations
            CalculateCalories();
        }

        // This method contains the logic for calculating calories
        private void CalculateCalories()
        {
            try
            {
                if (cmbActivitytype.SelectedItem == null)
                {
                    MessageBox.Show("Please select an activity type.");
                    return;
                }

                if (string.IsNullOrEmpty(txtTime.Text) || !int.TryParse(txtTime.Text, out int duration) || duration <= 0)
                {
                    MessageBox.Show("Please enter a valid duration in minutes.");
                    return;
                }

                if (string.IsNullOrEmpty(txtweight.Text) || !double.TryParse(txtweight.Text, out double weight) || weight <= 0)
                {
                    MessageBox.Show("Please enter a valid weight in kg.");
                    return;
                }

                // Get the selected activity type
                string selectedActivity = cmbActivitytype.SelectedItem.ToString();

                // Get MET value for the selected activity from the database
                double metValue = GetMetValue(selectedActivity);

                if (metValue <= 0)
                {
                    MessageBox.Show("Invalid MET value retrieved. Please check the activity type.");
                    return;
                }

                // Calculate calories burned
                double caloriesBurned = (metValue * weight * (duration / 60.0));

                // Insert calculated data into the database
                InsertCaloriesData(selectedActivity, duration, weight, caloriesBurned);

                // Display result
                MessageBox.Show($"Calories Burned: {caloriesBurned:F2} kcal");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
