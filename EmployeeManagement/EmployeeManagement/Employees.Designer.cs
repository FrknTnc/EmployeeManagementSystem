namespace EmployeeManagement
{
    partial class Employees
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
            this.EmployeeNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.DepartmentBox = new System.Windows.Forms.ComboBox();
            this.DateBox2 = new System.Windows.Forms.DateTimePicker();
            this.DateBox1 = new System.Windows.Forms.DateTimePicker();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.LogoutText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeNameBox
            // 
            this.EmployeeNameBox.BackColor = System.Drawing.Color.Lavender;
            this.EmployeeNameBox.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmployeeNameBox.Location = new System.Drawing.Point(91, 203);
            this.EmployeeNameBox.Name = "EmployeeNameBox";
            this.EmployeeNameBox.Size = new System.Drawing.Size(338, 46);
            this.EmployeeNameBox.TabIndex = 4;
            this.EmployeeNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(87, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(87, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(87, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date of Birth";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(87, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(87, 585);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Daily Salary";
            // 
            // SalaryBox
            // 
            this.SalaryBox.BackColor = System.Drawing.Color.Lavender;
            this.SalaryBox.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalaryBox.Location = new System.Drawing.Point(91, 611);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(338, 46);
            this.SalaryBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(87, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Start Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagement.Properties.Resources.smart_card;
            this.pictureBox1.Location = new System.Drawing.Point(195, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 118);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork__2_;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 783);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 52);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork__2_;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GenderBox
            // 
            this.GenderBox.BackColor = System.Drawing.Color.Lavender;
            this.GenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(91, 287);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(338, 45);
            this.GenderBox.TabIndex = 19;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.BackColor = System.Drawing.Color.Lavender;
            this.DepartmentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmentBox.FormattingEnabled = true;
            this.DepartmentBox.Location = new System.Drawing.Point(91, 373);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(338, 45);
            this.DepartmentBox.TabIndex = 20;
            // 
            // DateBox2
            // 
            this.DateBox2.CalendarFont = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox2.CalendarTitleBackColor = System.Drawing.Color.Lavender;
            this.DateBox2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBox2.Location = new System.Drawing.Point(91, 537);
            this.DateBox2.Name = "DateBox2";
            this.DateBox2.Size = new System.Drawing.Size(338, 20);
            this.DateBox2.TabIndex = 40;
            // 
            // DateBox1
            // 
            this.DateBox1.CalendarFont = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox1.CalendarTitleBackColor = System.Drawing.Color.Lavender;
            this.DateBox1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBox1.Location = new System.Drawing.Point(91, 466);
            this.DateBox1.Name = "DateBox1";
            this.DateBox1.Size = new System.Drawing.Size(338, 20);
            this.DateBox1.TabIndex = 45;
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddEmployee.Location = new System.Drawing.Point(91, 663);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(165, 51);
            this.AddEmployee.TabIndex = 42;
            this.AddEmployee.Text = "ADD";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.UpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmployee.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UpdateEmployee.Location = new System.Drawing.Point(265, 663);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(164, 51);
            this.UpdateEmployee.TabIndex = 43;
            this.UpdateEmployee.Text = "UPDATE";
            this.UpdateEmployee.UseVisualStyleBackColor = true;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Location = new System.Drawing.Point(497, 203);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(814, 482);
            this.EmployeeList.TabIndex = 63;
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.DeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmployee.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DeleteEmployee.Location = new System.Drawing.Point(181, 720);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(164, 51);
            this.DeleteEmployee.TabIndex = 64;
            this.DeleteEmployee.Text = "DELETE";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // LogoutText
            // 
            this.LogoutText.AutoSize = true;
            this.LogoutText.BackColor = System.Drawing.Color.Lavender;
            this.LogoutText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogoutText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LogoutText.Location = new System.Drawing.Point(674, 10);
            this.LogoutText.Name = "LogoutText";
            this.LogoutText.Size = new System.Drawing.Size(122, 23);
            this.LogoutText.TabIndex = 72;
            this.LogoutText.Text = "LogoutText";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Lavender;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(494, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 71;
            this.label9.Text = "Salary";
            this.label9.Click += new System.EventHandler(this.Employee_SalaryClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Lavender;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(241, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 70;
            this.label8.Text = "Department";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Lavender;
            this.label10.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(17, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 69;
            this.label10.Text = "Employee";
            this.label10.Click += new System.EventHandler(this.Employee_EmployeeClick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.LogoutText);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(497, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 42);
            this.panel3.TabIndex = 73;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 835);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DeleteEmployee);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.DateBox1);
            this.Controls.Add(this.DateBox2);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeNameBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SalaryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.ComboBox DepartmentBox;
        private System.Windows.Forms.DateTimePicker DateBox2;
        private System.Windows.Forms.DateTimePicker DateBox1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.Label LogoutText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
    }
}