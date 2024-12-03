namespace FitnessApp1
{
    partial class frmActivities
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbActivitytype = new System.Windows.Forms.ComboBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtSets = new System.Windows.Forms.TextBox();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.txtPoses = new System.Windows.Forms.TextBox();
            this.txtElevation = new System.Windows.Forms.TextBox();
            this.dtActivityDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColActivityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColElevationGain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosesCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRepetitions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActivityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActivityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlData.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(418, 286);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 19;
            this.btnClose.Tag = "";
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(195, 34);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 26);
            this.txtId.TabIndex = 11;
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
            this.cmbActivitytype.Location = new System.Drawing.Point(195, 100);
            this.cmbActivitytype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbActivitytype.Name = "cmbActivitytype";
            this.cmbActivitytype.Size = new System.Drawing.Size(180, 28);
            this.cmbActivitytype.TabIndex = 9;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(195, 142);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(148, 26);
            this.txtDuration.TabIndex = 8;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(195, 175);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(148, 26);
            this.txtDistance.TabIndex = 7;
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(195, 215);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(148, 26);
            this.txtCalories.TabIndex = 6;
            // 
            // txtSets
            // 
            this.txtSets.Location = new System.Drawing.Point(590, 60);
            this.txtSets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(148, 26);
            this.txtSets.TabIndex = 5;
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(590, 100);
            this.txtRepeat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(148, 26);
            this.txtRepeat.TabIndex = 4;
            // 
            // txtPoses
            // 
            this.txtPoses.Location = new System.Drawing.Point(590, 132);
            this.txtPoses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPoses.Name = "txtPoses";
            this.txtPoses.Size = new System.Drawing.Size(148, 26);
            this.txtPoses.TabIndex = 3;
            // 
            // txtElevation
            // 
            this.txtElevation.Location = new System.Drawing.Point(590, 166);
            this.txtElevation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtElevation.Name = "txtElevation";
            this.txtElevation.Size = new System.Drawing.Size(148, 26);
            this.txtElevation.TabIndex = 2;
            // 
            // dtActivityDate
            // 
            this.dtActivityDate.CustomFormat = "yyyy/MM/dd";
            this.dtActivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtActivityDate.Location = new System.Drawing.Point(590, 206);
            this.dtActivityDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtActivityDate.Name = "dtActivityDate";
            this.dtActivityDate.Size = new System.Drawing.Size(148, 26);
            this.dtActivityDate.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(429, 203);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 34);
            this.label11.TabIndex = 0;
            this.label11.Text = "Activity Date : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(429, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "Elevation Gain : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(429, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "Poses Complete : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(429, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "Repeatitions: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(429, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sets : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(34, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Calories : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(34, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Distance : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(34, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Duration : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Activity Type : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Location = new System.Drawing.Point(34, 66);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(149, 34);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User Id  : ";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlData.Controls.Add(this.btnInsert);
            this.pnlData.Controls.Add(this.txtUserId);
            this.pnlData.Controls.Add(this.btnClose);
            this.pnlData.Controls.Add(this.txtId);
            this.pnlData.Controls.Add(this.cmbActivitytype);
            this.pnlData.Controls.Add(this.txtDuration);
            this.pnlData.Controls.Add(this.txtDistance);
            this.pnlData.Controls.Add(this.txtCalories);
            this.pnlData.Controls.Add(this.txtSets);
            this.pnlData.Controls.Add(this.txtRepeat);
            this.pnlData.Controls.Add(this.txtPoses);
            this.pnlData.Controls.Add(this.txtElevation);
            this.pnlData.Controls.Add(this.dtActivityDate);
            this.pnlData.Controls.Add(this.label11);
            this.pnlData.Controls.Add(this.label10);
            this.pnlData.Controls.Add(this.label9);
            this.pnlData.Controls.Add(this.label8);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.lblUser);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(210, 208);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(790, 368);
            this.pnlData.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(259, 286);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(116, 37);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Tag = "";
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(195, 69);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(180, 26);
            this.txtUserId.TabIndex = 20;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTop.Controls.Add(this.label12);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1252, 103);
            this.pnlTop.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(176, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(906, 58);
            this.label12.TabIndex = 0;
            this.label12.Text = "Activities Information";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Width = 88;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Width = 88;
            // 
            // ColActivityDate
            // 
            this.ColActivityDate.HeaderText = "ActivityDate";
            this.ColActivityDate.MinimumWidth = 8;
            this.ColActivityDate.Name = "ColActivityDate";
            this.ColActivityDate.Width = 89;
            // 
            // ColElevationGain
            // 
            this.ColElevationGain.HeaderText = "ElevationGain";
            this.ColElevationGain.MinimumWidth = 8;
            this.ColElevationGain.Name = "ColElevationGain";
            this.ColElevationGain.Width = 88;
            // 
            // ColPosesCompleted
            // 
            this.ColPosesCompleted.HeaderText = "PosesCompleted";
            this.ColPosesCompleted.MinimumWidth = 8;
            this.ColPosesCompleted.Name = "ColPosesCompleted";
            this.ColPosesCompleted.Width = 88;
            // 
            // ColRepetitions
            // 
            this.ColRepetitions.HeaderText = "Repetitions";
            this.ColRepetitions.MinimumWidth = 8;
            this.ColRepetitions.Name = "ColRepetitions";
            this.ColRepetitions.Width = 88;
            // 
            // ColSets
            // 
            this.ColSets.HeaderText = "Sets";
            this.ColSets.MinimumWidth = 8;
            this.ColSets.Name = "ColSets";
            this.ColSets.Width = 89;
            // 
            // ColCalories
            // 
            this.ColCalories.HeaderText = "Calories";
            this.ColCalories.MinimumWidth = 8;
            this.ColCalories.Name = "ColCalories";
            this.ColCalories.Width = 88;
            // 
            // ColDistance
            // 
            this.ColDistance.HeaderText = "Distance";
            this.ColDistance.MinimumWidth = 8;
            this.ColDistance.Name = "ColDistance";
            this.ColDistance.Width = 88;
            // 
            // ColDuration
            // 
            this.ColDuration.HeaderText = "Duration";
            this.ColDuration.MinimumWidth = 8;
            this.ColDuration.Name = "ColDuration";
            this.ColDuration.Width = 88;
            // 
            // ColActivityType
            // 
            this.ColActivityType.HeaderText = "ActivityType";
            this.ColActivityType.MinimumWidth = 8;
            this.ColActivityType.Name = "ColActivityType";
            this.ColActivityType.Width = 89;
            // 
            // ColUserID
            // 
            this.ColUserID.HeaderText = "UserID";
            this.ColUserID.MinimumWidth = 8;
            this.ColUserID.Name = "ColUserID";
            this.ColUserID.Width = 88;
            // 
            // ColActivityID
            // 
            this.ColActivityID.HeaderText = "ActivityID";
            this.ColActivityID.MinimumWidth = 8;
            this.ColActivityID.Name = "ColActivityID";
            this.ColActivityID.Width = 88;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColActivityID,
            this.ColUserID,
            this.ColActivityType,
            this.ColDuration,
            this.ColDistance,
            this.ColCalories,
            this.ColSets,
            this.ColRepetitions,
            this.ColPosesCompleted,
            this.ColElevationGain,
            this.ColActivityDate,
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1211, 497);
            this.dataGridView1.TabIndex = 5;
            // 
            // frmActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1252, 696);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmActivities";
            this.Text = "Activities";
            this.Load += new System.EventHandler(this.frmActivities_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbActivitytype;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.TextBox txtSets;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.TextBox txtPoses;
        private System.Windows.Forms.TextBox txtElevation;
        private System.Windows.Forms.DateTimePicker dtActivityDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActivityDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColElevationGain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosesCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRepetitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCalories;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActivityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActivityID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}