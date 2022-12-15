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
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BranchText = new System.Windows.Forms.Label();
            this.ProjectText = new System.Windows.Forms.Label();
            this.EmployeeText = new System.Windows.Forms.Label();
            this.DepartmentsText = new System.Windows.Forms.Label();
            this.SalaryText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeNameBox
            // 
            this.EmployeeNameBox.BackColor = System.Drawing.Color.Lavender;
            this.EmployeeNameBox.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmployeeNameBox.Location = new System.Drawing.Point(236, 126);
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
            this.label2.Location = new System.Drawing.Point(232, 100);
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
            this.label3.Location = new System.Drawing.Point(232, 193);
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
            this.label4.Location = new System.Drawing.Point(232, 375);
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
            this.label5.Location = new System.Drawing.Point(232, 286);
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
            this.label6.Location = new System.Drawing.Point(232, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Daily Salary";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SalaryBox
            // 
            this.SalaryBox.BackColor = System.Drawing.Color.Lavender;
            this.SalaryBox.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalaryBox.Location = new System.Drawing.Point(236, 527);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(338, 46);
            this.SalaryBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(232, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Start Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork__2_;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 784);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 52);
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
            this.panel1.Size = new System.Drawing.Size(1384, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(439, 19);
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
            this.GenderBox.Location = new System.Drawing.Point(236, 219);
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
            this.DepartmentBox.Location = new System.Drawing.Point(236, 312);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(338, 45);
            this.DepartmentBox.TabIndex = 20;
            // 
            // DateBox2
            // 
            this.DateBox2.CalendarFont = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox2.CalendarTitleBackColor = System.Drawing.Color.Lavender;
            this.DateBox2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBox2.Location = new System.Drawing.Point(236, 462);
            this.DateBox2.Name = "DateBox2";
            this.DateBox2.Size = new System.Drawing.Size(338, 20);
            this.DateBox2.TabIndex = 40;
            // 
            // DateBox1
            // 
            this.DateBox1.CalendarFont = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox1.CalendarTitleBackColor = System.Drawing.Color.Lavender;
            this.DateBox1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBox1.Location = new System.Drawing.Point(236, 400);
            this.DateBox1.Name = "DateBox1";
            this.DateBox1.Size = new System.Drawing.Size(338, 20);
            this.DateBox1.TabIndex = 45;
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackColor = System.Drawing.Color.LightGreen;
            this.AddEmployee.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddEmployee.Location = new System.Drawing.Point(314, 589);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(165, 51);
            this.AddEmployee.TabIndex = 42;
            this.AddEmployee.Text = "ADD";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.BackColor = System.Drawing.Color.Khaki;
            this.UpdateEmployee.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.UpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmployee.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UpdateEmployee.Location = new System.Drawing.Point(314, 646);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(165, 51);
            this.UpdateEmployee.TabIndex = 43;
            this.UpdateEmployee.Text = "UPDATE";
            this.UpdateEmployee.UseVisualStyleBackColor = false;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Location = new System.Drawing.Point(601, 193);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(743, 482);
            this.EmployeeList.TabIndex = 63;
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.BackColor = System.Drawing.Color.LightSalmon;
            this.DeleteEmployee.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.DeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmployee.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DeleteEmployee.Location = new System.Drawing.Point(315, 703);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(164, 51);
            this.DeleteEmployee.TabIndex = 64;
            this.DeleteEmployee.Text = "DELETE";
            this.DeleteEmployee.UseVisualStyleBackColor = false;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(683, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 23);
            this.label11.TabIndex = 75;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.panel4.Controls.Add(this.BranchText);
            this.panel4.Controls.Add(this.ProjectText);
            this.panel4.Controls.Add(this.EmployeeText);
            this.panel4.Controls.Add(this.DepartmentsText);
            this.panel4.Controls.Add(this.SalaryText);
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 742);
            this.panel4.TabIndex = 74;
            // 
            // BranchText
            // 
            this.BranchText.BackColor = System.Drawing.Color.MidnightBlue;
            this.BranchText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BranchText.ForeColor = System.Drawing.Color.AliceBlue;
            this.BranchText.Location = new System.Drawing.Point(0, 206);
            this.BranchText.Name = "BranchText";
            this.BranchText.Size = new System.Drawing.Size(185, 30);
            this.BranchText.TabIndex = 72;
            this.BranchText.Text = "BRANCH";
            this.BranchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BranchText.Click += new System.EventHandler(this.BranchText_Click);
            // 
            // ProjectText
            // 
            this.ProjectText.BackColor = System.Drawing.Color.MidnightBlue;
            this.ProjectText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProjectText.ForeColor = System.Drawing.Color.AliceBlue;
            this.ProjectText.Location = new System.Drawing.Point(0, 359);
            this.ProjectText.Name = "ProjectText";
            this.ProjectText.Size = new System.Drawing.Size(185, 30);
            this.ProjectText.TabIndex = 68;
            this.ProjectText.Text = "PROJECT";
            this.ProjectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProjectText.Click += new System.EventHandler(this.ProjectText_Click);
            // 
            // EmployeeText
            // 
            this.EmployeeText.BackColor = System.Drawing.Color.RoyalBlue;
            this.EmployeeText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmployeeText.ForeColor = System.Drawing.Color.AliceBlue;
            this.EmployeeText.Location = new System.Drawing.Point(0, 309);
            this.EmployeeText.Name = "EmployeeText";
            this.EmployeeText.Size = new System.Drawing.Size(185, 30);
            this.EmployeeText.TabIndex = 64;
            this.EmployeeText.Text = "EMPLOYEE";
            this.EmployeeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentsText
            // 
            this.DepartmentsText.BackColor = System.Drawing.Color.MidnightBlue;
            this.DepartmentsText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmentsText.ForeColor = System.Drawing.Color.AliceBlue;
            this.DepartmentsText.Location = new System.Drawing.Point(0, 256);
            this.DepartmentsText.Name = "DepartmentsText";
            this.DepartmentsText.Size = new System.Drawing.Size(185, 30);
            this.DepartmentsText.TabIndex = 8065;
            this.DepartmentsText.Text = "DEPARTMENT";
            this.DepartmentsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DepartmentsText.Click += new System.EventHandler(this.DepartmentsText_Click);
            // 
            // SalaryText
            // 
            this.SalaryText.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalaryText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalaryText.ForeColor = System.Drawing.Color.AliceBlue;
            this.SalaryText.Location = new System.Drawing.Point(0, 412);
            this.SalaryText.Name = "SalaryText";
            this.SalaryText.Size = new System.Drawing.Size(185, 30);
            this.SalaryText.TabIndex = 66;
            this.SalaryText.Text = "SALARY";
            this.SalaryText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalaryText.Click += new System.EventHandler(this.SalaryText_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(883, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 76;
            this.label8.Text = "Employee List";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 836);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeleteEmployee);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.DateBox1);
            this.Controls.Add(this.DateBox2);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeNameBox);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.ComboBox DepartmentBox;
        private System.Windows.Forms.DateTimePicker DateBox2;
        private System.Windows.Forms.DateTimePicker DateBox1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label BranchText;
        private System.Windows.Forms.Label ProjectText;
        private System.Windows.Forms.Label EmployeeText;
        private System.Windows.Forms.Label DepartmentsText;
        private System.Windows.Forms.Label SalaryText;
        private System.Windows.Forms.Label label8;
    }
}