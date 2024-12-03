using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp1
{
    public partial class frmRegister : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CMM1ASO;Initial Catalog=Fitness;Integrated Security=True");

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // Check if username is entered
            if (txtName.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter User Name !!!");
            }

            // Check if email is entered
            if (txtEmail.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter User Email !!!");
            }

            // Check if password is entered
            if (txtPassword.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Password !!!");
            }

            // Check if confirm password is entered
            if (txtConfirm.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Confirm Password !!!");
            }

            // Check if password and confirm password match
            if (txtPassword.Text.Trim() != txtConfirm.Text.Trim())
            {
                sb.AppendLine("Password and Confirm Password do not match !!!");
            }
            string password = txtPassword.Text;
            // Check if password contains both uppercase and lowercase letters
            bool hasLowerChar = password.Any(char.IsLower);
            bool hasUpperChar = password.Any(char.IsUpper);

            if (!hasLowerChar || !hasUpperChar)
            {
                sb.AppendLine("Password must contain both uppercase and lowercase letters.");
            }
            // Check if password has at least 12 characters
            if (password.Length < 12)
            {
                sb.AppendLine("Password must be at least 12 characters long.");
            }
            // Display validation messages if any
            if (sb.ToString() != string.Empty)
            {
                MessageBox.Show(sb.ToString());
                return;
            }

            // If no validation errors, proceed to insert data into database
            SqlCommand cmd = new SqlCommand("INSERT INTO tblUser (UserName, Email, Password) VALUES(@UName, @Email, @Pass)", conn);
            cmd.Parameters.AddWithValue("@UName", txtName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            if (result != 0)
            {
                MessageBox.Show("Data Inserted Successfully !!!");
            }
            else
            {
                MessageBox.Show("Unexpected Error, Please Check !!!");
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            txtConfirm.PasswordChar = '\0';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box before closing
            DialogResult result = MessageBox.Show("Are you sure you want to cancel and close the registration form?",
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
