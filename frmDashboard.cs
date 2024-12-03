using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp1
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusClock.Text = DateTime.Now.ToString("hh:mm:ss tt");

            toolStripStatusMsg.Text = "Welcome " + UserInfo.Username;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            openChildForm(new frmActivities());
        }



        private void goal_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGoal());
        }

        private void logout_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box before closing
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                  "Cancel Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // If the user clicked Yes, close the form
            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide the current dashboard form
                frmLogin loginForm = new frmLogin(); // Create a new instance of the login form
                loginForm.Show();
            }
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCalculation());
        }
    }
}
