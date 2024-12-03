using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace FitnessApp1
{
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CMM1ASO;Initial Catalog=Fitness;Integrated Security=True");

        // Variable to keep track of failed login attempts
        private int failedLoginAttempts = 0;
        private const int MaxLoginAttempts = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (txtName.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter User Name !!!");
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Password !!!");
            }

            if (sb.ToString() != String.Empty)
            {
                MessageBox.Show(sb.ToString());
                return;
            }

            string query = "SELECT * FROM tblUser WHERE UserName = @uName and password = @uPass";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uName", txtName.Text);
            cmd.Parameters.AddWithValue("@uPass", txtPassword.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                // Reset the failed attempts counter upon successful login
                failedLoginAttempts = 0;

                UserInfo.Id = Int32.Parse(dt.Rows[0][0].ToString());
                UserInfo.Username = dt.Rows[0][1].ToString();

                //MessageBox.Show(UserInfo.Username + UserInfo.Id);

                this.Hide();
                frmDashboard frm = new frmDashboard();
                frm.ShowDialog();
            }
            else
            {
                failedLoginAttempts++;

                // Check if the maximum attempts have been reached
                if (failedLoginAttempts >= MaxLoginAttempts)
                {
                    MessageBox.Show("Maximum login attempts reached! Login button is now disabled.");
                    btnLogin.Enabled = false; // Disable the login button
                }
                else
                {
                    MessageBox.Show($"Login failed! You have {MaxLoginAttempts - failedLoginAttempts} attempt(s) remaining.");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box before closing
            DialogResult result = MessageBox.Show("Are you sure you want to cancel and close the login form?",
                                                  "Cancel Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // If the user clicked Yes, close the form
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

    }
}
