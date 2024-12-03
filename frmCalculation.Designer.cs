namespace FitnessApp1
{
    partial class frmCalculation
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
            this.lblActivity = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbActivitytype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.fitnessDataSet = new FitnessApp1.FitnessDataSet();
            this.tblUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserTableAdapter = new FitnessApp1.FitnessDataSetTableAdapters.tblUserTableAdapter();
            
            this.userGoalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDataSet2 = new FitnessApp1.FitnessDataSet();
            this.pnlTop.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.userGoalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(82, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(709, 58);
            this.label12.TabIndex = 0;
            this.label12.Text = "Calories Calculation";
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
            this.pnlTop.Size = new System.Drawing.Size(881, 103);
            this.pnlTop.TabIndex = 11;
            // 
            // lblActivity
            // 
            this.lblActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(34, 129);
            this.lblActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(185, 34);
            this.lblActivity.TabIndex = 0;
            this.lblActivity.Text = "Activity type :";
            this.lblActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(103, 273);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 37);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Tag = "Check";
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(249, 272);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 37);
            this.btnClose.TabIndex = 19;
            this.btnClose.Tag = "";
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlData.Controls.Add(this.txtTime);
            this.pnlData.Controls.Add(this.lblTime);
            this.pnlData.Controls.Add(this.cmbActivitytype);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.txtweight);
            this.pnlData.Controls.Add(this.btnClose);
            this.pnlData.Controls.Add(this.btnCalculate);
            this.pnlData.Controls.Add(this.lblActivity);
            this.pnlData.Controls.Add(this.lblWeight);
            this.pnlData.Location = new System.Drawing.Point(77, 105);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(736, 368);
            this.pnlData.TabIndex = 10;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(249, 180);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(92, 26);
            this.txtTime.TabIndex = 24;
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(34, 176);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(185, 34);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "Duration :";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmbActivitytype.Location = new System.Drawing.Point(249, 133);
            this.cmbActivitytype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbActivitytype.Name = "cmbActivitytype";
            this.cmbActivitytype.Size = new System.Drawing.Size(180, 28);
            this.cmbActivitytype.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "  kg  ";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(249, 84);
            this.txtweight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(109, 26);
            this.txtweight.TabIndex = 20;
            // 
            // lblWeight
            // 
            this.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(34, 80);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(185, 34);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Entire Weight :";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fitnessDataSet
            // 
            this.fitnessDataSet.DataSetName = "FitnessDataSet";
            this.fitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserBindingSource1
            // 
            this.tblUserBindingSource1.DataMember = "tblUser";
            this.tblUserBindingSource1.DataSource = this.fitnessDataSetBindingSource;
            // 
            // fitnessDataSetBindingSource
            // 
            this.fitnessDataSetBindingSource.DataSource = this.fitnessDataSet;
            this.fitnessDataSetBindingSource.Position = 0;
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
            // fitnessDataSet1
            // 
             // 
            // userGoalsBindingSource
            // 
            this.userGoalsBindingSource.DataMember = "UserGoals";
                 // 
            // fitnessDataSetBindingSource1
            // 
            this.fitnessDataSetBindingSource1.DataSource = this.fitnessDataSet;
            this.fitnessDataSetBindingSource1.Position = 0;
            // 
            // fitnessDataSet2
            // 
            this.fitnessDataSet2.DataSetName = "FitnessDataSet";
            this.fitnessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 489);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmCalculation";
            this.Text = "frmCalculation";
            this.pnlTop.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.userGoalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlData;
        private FitnessDataSet fitnessDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource1;
        private System.Windows.Forms.BindingSource fitnessDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private FitnessDataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter;
       
        private System.Windows.Forms.BindingSource userGoalsBindingSource;
        private System.Windows.Forms.BindingSource fitnessDataSetBindingSource1;
        private FitnessDataSet fitnessDataSet2;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbActivitytype;
    }
}