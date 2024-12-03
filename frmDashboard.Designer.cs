namespace FitnessApp1
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.goal = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusReady,
            this.toolStripStatusMsg,
            this.toolStripStatusClock});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1200, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusReady
            // 
            this.toolStripStatusReady.Name = "toolStripStatusReady";
            this.toolStripStatusReady.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusReady.Text = "Ready";
            // 
            // toolStripStatusMsg
            // 
            this.toolStripStatusMsg.Name = "toolStripStatusMsg";
            this.toolStripStatusMsg.Size = new System.Drawing.Size(1062, 25);
            this.toolStripStatusMsg.Spring = true;
            this.toolStripStatusMsg.Text = "Welcome ";
            // 
            // toolStripStatusClock
            // 
            this.toolStripStatusClock.Name = "toolStripStatusClock";
            this.toolStripStatusClock.Size = new System.Drawing.Size(55, 25);
            this.toolStripStatusClock.Text = "Clock";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlLeft.Controls.Add(this.button4);
            this.pnlLeft.Controls.Add(this.button2);
            this.pnlLeft.Controls.Add(this.btnCalculation);
            this.pnlLeft.Controls.Add(this.logout);
            this.pnlLeft.Controls.Add(this.goal);
            this.pnlLeft.Controls.Add(this.btnActivities);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.pnlLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(231, 660);
            this.pnlLeft.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, 419);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 62);
            this.button4.TabIndex = 8;
            this.button4.Text = "&Monitor Improvement";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Record";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnCalculation
            // 
            this.btnCalculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalculation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalculation.FlatAppearance.BorderSize = 2;
            this.btnCalculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculation.ForeColor = System.Drawing.Color.Black;
            this.btnCalculation.Location = new System.Drawing.Point(0, 295);
            this.btnCalculation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(231, 62);
            this.btnCalculation.TabIndex = 6;
            this.btnCalculation.Text = "&Calculation Calories";
            this.btnCalculation.UseVisualStyleBackColor = false;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logout.FlatAppearance.BorderSize = 2;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Location = new System.Drawing.Point(0, 598);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(231, 62);
            this.logout.TabIndex = 5;
            this.logout.Text = "&Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // goal
            // 
            this.goal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.goal.Dock = System.Windows.Forms.DockStyle.Top;
            this.goal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.goal.FlatAppearance.BorderSize = 2;
            this.goal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goal.ForeColor = System.Drawing.Color.Black;
            this.goal.Location = new System.Drawing.Point(0, 233);
            this.goal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(231, 62);
            this.goal.TabIndex = 4;
            this.goal.Text = "&Setting Goals";
            this.goal.UseVisualStyleBackColor = false;
            this.goal.Click += new System.EventHandler(this.goal_Click);
            // 
            // btnActivities
            // 
            this.btnActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnActivities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActivities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnActivities.FlatAppearance.BorderSize = 2;
            this.btnActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.ForeColor = System.Drawing.Color.Black;
            this.btnActivities.Location = new System.Drawing.Point(0, 171);
            this.btnActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(231, 62);
            this.btnActivities.TabIndex = 2;
            this.btnActivities.Text = "&Activites";
            this.btnActivities.UseVisualStyleBackColor = false;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(0, 109);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(231, 62);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "&Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(231, 109);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(231, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(969, 109);
            this.pnlTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(59, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(714, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Fitness Tracker Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(231, 109);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(969, 551);
            this.pnlContainer.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button goal;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusReady;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMsg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}