namespace FitnessApp1
{
    partial class frmGoal
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
            this.label12 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.fitnessDataSet = new FitnessApp1.FitnessDataSet();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserTableAdapter = new FitnessApp1.FitnessDataSetTableAdapters.tblUserTableAdapter();
            this.fitnessDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.userGoalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
              this.fitnessDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSet2 = new FitnessApp1.FitnessDataSet();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource)).BeginInit();
             ((System.ComponentModel.ISupportInitialize)(this.userGoalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(709, 58);
            this.label12.TabIndex = 0;
            this.label12.Text = "Calories Goal";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTop.Controls.Add(this.label12);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(807, 103);
            this.pnlTop.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(249, 250);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 19;
            this.btnClose.Tag = "";
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(103, 250);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 37);
            this.btnCheck.TabIndex = 18;
            this.btnCheck.Tag = "Check";
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(249, 129);
            this.txtGoal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(214, 26);
            this.txtGoal.TabIndex = 8;
            // 
            // lblGoal
            // 
            this.lblGoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(34, 129);
            this.lblGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(185, 34);
            this.lblGoal.TabIndex = 0;
            this.lblGoal.Text = "Goal Calories :";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(34, 80);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(185, 34);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Activity Type :";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlData.Controls.Add(this.cmbActivity);
            this.pnlData.Controls.Add(this.btnClose);
            this.pnlData.Controls.Add(this.btnCheck);
            this.pnlData.Controls.Add(this.txtGoal);
            this.pnlData.Controls.Add(this.lblGoal);
            this.pnlData.Controls.Add(this.lblUser);
            this.pnlData.Location = new System.Drawing.Point(96, 104);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(577, 368);
            this.pnlData.TabIndex = 8;
            // 
            // fitnessDataSet
            // 
            this.fitnessDataSet.DataSetName = "FitnessDataSet";
            this.fitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.fitnessDataSet;
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // fitnessDataSetBindingSource
            // 
            this.fitnessDataSetBindingSource.DataSource = this.fitnessDataSet;
            this.fitnessDataSetBindingSource.Position = 0;
            // 
            // fitnessDataSet1
            // 
              // 
            // userGoalsBindingSource
            // 
            this.userGoalsBindingSource.DataMember = "UserGoals";
                     // 
            // userGoalsTableAdapter
            // 
                // 
            // fitnessDataSetBindingSource1
            // 
            this.fitnessDataSetBindingSource1.DataSource = this.fitnessDataSet;
            this.fitnessDataSetBindingSource1.Position = 0;
            // 
            // tblUserBindingSource1
            // 
            this.tblUserBindingSource1.DataMember = "tblUser";
            this.tblUserBindingSource1.DataSource = this.fitnessDataSetBindingSource;
            // 
            // fitnessDataSet2
            // 
            this.fitnessDataSet2.DataSetName = "FitnessDataSet";
            this.fitnessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbActivity
            // 
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Items.AddRange(new object[] {
            "------ Select -------",
            "Cycling",
            "Swimming",
            "Weightlifting",
            "Yoga",
            "Running",
            "Hiking"});
            this.cmbActivity.Location = new System.Drawing.Point(249, 80);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(214, 28);
            this.cmbActivity.TabIndex = 20;
            // 
            // frmGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 480);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlData);
            this.Name = "frmGoal";
            this.Text = "frmGoal";
            this.pnlTop.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource)).EndInit();
             ((System.ComponentModel.ISupportInitialize)(this.userGoalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlData;
        private FitnessDataSet fitnessDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private FitnessDataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.BindingSource fitnessDataSetBindingSource;
          private System.Windows.Forms.BindingSource userGoalsBindingSource;
           private System.Windows.Forms.BindingSource fitnessDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tblUserBindingSource1;
        private FitnessDataSet fitnessDataSet2;
        private System.Windows.Forms.ComboBox cmbActivity;
    }
}