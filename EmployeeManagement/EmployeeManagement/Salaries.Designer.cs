namespace EmployeeManagement
{
    partial class Salaries
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
            this.PeriodDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateSalary = new System.Windows.Forms.Button();
            this.AddSalary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SalaryEmployeeBox = new System.Windows.Forms.ComboBox();
            this.DaysBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SalaryList = new System.Windows.Forms.DataGridView();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.LogoutText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryList)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeriodDate
            // 
            this.PeriodDate.CalendarFont = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodDate.CalendarTitleBackColor = System.Drawing.Color.Lavender;
            this.PeriodDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodDate.Location = new System.Drawing.Point(91, 420);
            this.PeriodDate.Name = "PeriodDate";
            this.PeriodDate.Size = new System.Drawing.Size(338, 26);
            this.PeriodDate.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(87, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "Salary Amount";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(87, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(87, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Days Attended";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(87, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Employee";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UpdateSalary
            // 
            this.UpdateSalary.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.UpdateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSalary.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSalary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UpdateSalary.Location = new System.Drawing.Point(170, 646);
            this.UpdateSalary.Name = "UpdateSalary";
            this.UpdateSalary.Size = new System.Drawing.Size(165, 51);
            this.UpdateSalary.TabIndex = 59;
            this.UpdateSalary.Text = "UPDATE";
            this.UpdateSalary.UseVisualStyleBackColor = true;
            // 
            // AddSalary
            // 
            this.AddSalary.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.AddSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSalary.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSalary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddSalary.Location = new System.Drawing.Point(170, 577);
            this.AddSalary.Name = "AddSalary";
            this.AddSalary.Size = new System.Drawing.Size(165, 51);
            this.AddSalary.TabIndex = 58;
            this.AddSalary.Text = "ADD";
            this.AddSalary.UseVisualStyleBackColor = true;
            this.AddSalary.Click += new System.EventHandler(this.AddSalary_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork__2_;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 72);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(438, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagement.Properties.Resources.smart_card;
            this.pictureBox1.Location = new System.Drawing.Point(191, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 118);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // SalaryEmployeeBox
            // 
            this.SalaryEmployeeBox.BackColor = System.Drawing.Color.Lavender;
            this.SalaryEmployeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalaryEmployeeBox.FormattingEnabled = true;
            this.SalaryEmployeeBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SalaryEmployeeBox.Location = new System.Drawing.Point(91, 220);
            this.SalaryEmployeeBox.Name = "SalaryEmployeeBox";
            this.SalaryEmployeeBox.Size = new System.Drawing.Size(338, 45);
            this.SalaryEmployeeBox.TabIndex = 60;
            this.SalaryEmployeeBox.SelectedIndexChanged += new System.EventHandler(this.SalaryEmployeeBox_SelectedIndexChanged);
            // 
            // DaysBox
            // 
            this.DaysBox.BackColor = System.Drawing.Color.Lavender;
            this.DaysBox.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DaysBox.Location = new System.Drawing.Point(91, 324);
            this.DaysBox.Name = "DaysBox";
            this.DaysBox.Size = new System.Drawing.Size(338, 46);
            this.DaysBox.TabIndex = 61;
            this.DaysBox.TextChanged += new System.EventHandler(this.DaysBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(14, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 62;
            this.label6.Text = "Employee";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(231, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Department";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(499, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 64;
            this.label9.Text = "Salary";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // SalaryList
            // 
            this.SalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryList.Location = new System.Drawing.Point(499, 194);
            this.SalaryList.Name = "SalaryList";
            this.SalaryList.Size = new System.Drawing.Size(807, 503);
            this.SalaryList.TabIndex = 65;
            this.SalaryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentList_CellContentClick);
            // 
            // AmountBox
            // 
            this.AmountBox.BackColor = System.Drawing.Color.Lavender;
            this.AmountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountBox.Enabled = false;
            this.AmountBox.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AmountBox.Location = new System.Drawing.Point(91, 506);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(338, 39);
            this.AmountBox.TabIndex = 66;
            this.AmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LogoutText
            // 
            this.LogoutText.AutoSize = true;
            this.LogoutText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogoutText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LogoutText.Location = new System.Drawing.Point(668, 9);
            this.LogoutText.Name = "LogoutText";
            this.LogoutText.Size = new System.Drawing.Size(122, 23);
            this.LogoutText.TabIndex = 68;
            this.LogoutText.Text = "LogoutText";
            this.LogoutText.Click += new System.EventHandler(this.LogoutText_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.LogoutText);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(499, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 42);
            this.panel3.TabIndex = 69;
            // 
            // Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 835);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.SalaryList);
            this.Controls.Add(this.DaysBox);
            this.Controls.Add(this.SalaryEmployeeBox);
            this.Controls.Add(this.UpdateSalary);
            this.Controls.Add(this.AddSalary);
            this.Controls.Add(this.PeriodDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Salaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salaries";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateSalary;
        private System.Windows.Forms.Button AddSalary;
        private System.Windows.Forms.DateTimePicker PeriodDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox SalaryEmployeeBox;
        private System.Windows.Forms.TextBox DaysBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView SalaryList;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label LogoutText;
        private System.Windows.Forms.Panel panel3;
    }
}