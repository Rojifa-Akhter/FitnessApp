namespace FitnessApp1
{
    partial class frmMonitorProgress
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
            this.fitnessDataSet2 = new FitnessApp1.FitnessDataSet();
            this.userGoalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserTableAdapter = new FitnessApp1.FitnessDataSetTableAdapters.tblUserTableAdapter();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSet = new FitnessApp1.FitnessDataSet();
            this.fitnessDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblburn = new System.Windows.Forms.Label();
            this.cmbActivitytype = new System.Windows.Forms.ComboBox();
            this.fitnessDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.lblActivity = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGoalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource1)).BeginInit();
            this.pnlData.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // fitnessDataSet2
            // 
            this.fitnessDataSet2.DataSetName = "FitnessDataSet";
            this.fitnessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userGoalsBindingSource
            // 
            this.userGoalsBindingSource.DataMember = "UserGoals";
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.fitnessDataSet;
            // 
            // fitnessDataSet
            // 
            this.fitnessDataSet.DataSetName = "FitnessDataSet";
            this.fitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fitnessDataSetBindingSource
            // 
            this.fitnessDataSetBindingSource.DataSource = this.fitnessDataSet;
            this.fitnessDataSetBindingSource.Position = 0;
            // 
            // tblUserBindingSource1
            // 
            this.tblUserBindingSource1.DataMember = "tblUser";
            this.tblUserBindingSource1.DataSource = this.fitnessDataSetBindingSource;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(270, 180);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(180, 26);
            this.txtTime.TabIndex = 24;
            // 
            // lblburn
            // 
            this.lblburn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblburn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblburn.Location = new System.Drawing.Point(55, 176);
            this.lblburn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblburn.Name = "lblburn";
            this.lblburn.Size = new System.Drawing.Size(185, 34);
            this.lblburn.TabIndex = 23;
            this.lblburn.Text = "Calories Burn :";
            this.lblburn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbActivitytype
            // 
            this.cmbActivitytype.FormattingEnabled = true;
            this.cmbActivitytype.Items.AddRange(new object[] {
            "------ Select -------",
            "Cycling",
            "Swimming",
            "Weightlifting",
            "Yoga",
            "Running",
            "Hiking"});
            this.cmbActivitytype.Location = new System.Drawing.Point(270, 68);
            this.cmbActivitytype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbActivitytype.Name = "cmbActivitytype";
            this.cmbActivitytype.Size = new System.Drawing.Size(180, 28);
            this.cmbActivitytype.TabIndex = 22;
            // 
            // fitnessDataSetBindingSource1
            // 
            this.fitnessDataSetBindingSource1.DataSource = this.fitnessDataSet;
            this.fitnessDataSetBindingSource1.Position = 0;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlData.Controls.Add(this.textBox1);
            this.pnlData.Controls.Add(this.lblGoal);
            this.pnlData.Controls.Add(this.txtTime);
            this.pnlData.Controls.Add(this.lblburn);
            this.pnlData.Controls.Add(this.cmbActivitytype);
            this.pnlData.Controls.Add(this.btnRefresh);
            this.pnlData.Controls.Add(this.btnProgress);
            this.pnlData.Controls.Add(this.lblActivity);
            this.pnlData.Location = new System.Drawing.Point(77, 146);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(736, 368);
            this.pnlData.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(282, 284);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 37);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Tag = "";
            this.btnRefresh.Text = "Refersh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.BackColor = System.Drawing.SystemColors.Control;
            this.btnProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgress.Location = new System.Drawing.Point(78, 284);
            this.btnProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(162, 37);
            this.btnProgress.TabIndex = 18;
            this.btnProgress.Tag = "Check";
            this.btnProgress.Text = "Check Progress";
            this.btnProgress.UseVisualStyleBackColor = false;
            // 
            // lblActivity
            // 
            this.lblActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(55, 64);
            this.lblActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(185, 34);
            this.lblActivity.TabIndex = 0;
            this.lblActivity.Text = "Activity type :";
            this.lblActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTop.Controls.Add(this.label12);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(936, 103);
            this.pnlTop.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(82, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(709, 58);
            this.label12.TabIndex = 0;
            this.label12.Text = "Monitor Progress";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoal
            // 
            this.lblGoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(55, 119);
            this.lblGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(185, 34);
            this.lblGoal.TabIndex = 25;
            this.lblGoal.Text = "Goal Calories :";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 123);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 26;
            // 
            // frmMonitorProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 555);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmMonitorProgress";
            this.Text = "frmMonitorProgress";
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGoalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource1)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FitnessDataSet fitnessDataSet2;
        private System.Windows.Forms.BindingSource userGoalsBindingSource;
        private FitnessDataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private FitnessDataSet fitnessDataSet;
        private System.Windows.Forms.BindingSource fitnessDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblUserBindingSource1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblburn;
        private System.Windows.Forms.ComboBox cmbActivitytype;
        private System.Windows.Forms.BindingSource fitnessDataSetBindingSource1;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label12;
    }
}