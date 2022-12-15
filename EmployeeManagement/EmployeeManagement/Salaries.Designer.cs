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
            this.SalaryEmployeeBox = new System.Windows.Forms.ComboBox();
            this.DaysBox = new System.Windows.Forms.TextBox();
            this.SalaryList = new System.Windows.Forms.DataGridView();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BranchText = new System.Windows.Forms.Label();
            this.ProjectText = new System.Windows.Forms.Label();
            this.EmployeeText = new System.Windows.Forms.Label();
            this.DepartmentsText = new System.Windows.Forms.Label();
            this.SalaryText = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeriodDate
            // 
            this.PeriodDate.CalendarFont = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodDate.CalendarTitleBackColor = System.Drawing.Color.Lavender;
            this.PeriodDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodDate.Location = new System.Drawing.Point(234, 368);
            this.PeriodDate.Name = "PeriodDate";
            this.PeriodDate.Size = new System.Drawing.Size(338, 26);
            this.PeriodDate.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(230, 421);
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
            this.label4.Location = new System.Drawing.Point(230, 337);
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
            this.label3.Location = new System.Drawing.Point(230, 240);
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
            this.label2.Location = new System.Drawing.Point(230, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Employee";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UpdateSalary
            // 
            this.UpdateSalary.BackColor = System.Drawing.Color.Khaki;
            this.UpdateSalary.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.UpdateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSalary.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSalary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UpdateSalary.Location = new System.Drawing.Point(313, 604);
            this.UpdateSalary.Name = "UpdateSalary";
            this.UpdateSalary.Size = new System.Drawing.Size(165, 51);
            this.UpdateSalary.TabIndex = 59;
            this.UpdateSalary.Text = "UPDATE";
            this.UpdateSalary.UseVisualStyleBackColor = false;
            // 
            // AddSalary
            // 
            this.AddSalary.BackColor = System.Drawing.Color.LightGreen;
            this.AddSalary.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.AddSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSalary.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSalary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddSalary.Location = new System.Drawing.Point(313, 527);
            this.AddSalary.Name = "AddSalary";
            this.AddSalary.Size = new System.Drawing.Size(165, 51);
            this.AddSalary.TabIndex = 58;
            this.AddSalary.Text = "ADD";
            this.AddSalary.UseVisualStyleBackColor = false;
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
            this.panel1.Size = new System.Drawing.Size(1384, 72);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(441, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(531, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            // 
            // SalaryEmployeeBox
            // 
            this.SalaryEmployeeBox.BackColor = System.Drawing.Color.Lavender;
            this.SalaryEmployeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalaryEmployeeBox.FormattingEnabled = true;
            this.SalaryEmployeeBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SalaryEmployeeBox.Location = new System.Drawing.Point(234, 169);
            this.SalaryEmployeeBox.Name = "SalaryEmployeeBox";
            this.SalaryEmployeeBox.Size = new System.Drawing.Size(338, 45);
            this.SalaryEmployeeBox.TabIndex = 60;
            this.SalaryEmployeeBox.SelectedIndexChanged += new System.EventHandler(this.SalaryEmployeeBox_SelectedIndexChanged);
            // 
            // DaysBox
            // 
            this.DaysBox.BackColor = System.Drawing.Color.Lavender;
            this.DaysBox.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DaysBox.Location = new System.Drawing.Point(234, 266);
            this.DaysBox.Name = "DaysBox";
            this.DaysBox.Size = new System.Drawing.Size(338, 46);
            this.DaysBox.TabIndex = 61;
            this.DaysBox.TextChanged += new System.EventHandler(this.DaysBox_TextChanged);
            // 
            // SalaryList
            // 
            this.SalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryList.Location = new System.Drawing.Point(606, 169);
            this.SalaryList.Name = "SalaryList";
            this.SalaryList.Size = new System.Drawing.Size(729, 512);
            this.SalaryList.TabIndex = 65;
            this.SalaryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentList_CellContentClick);
            // 
            // AmountBox
            // 
            this.AmountBox.BackColor = System.Drawing.Color.Lavender;
            this.AmountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountBox.Enabled = false;
            this.AmountBox.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AmountBox.Location = new System.Drawing.Point(234, 447);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(338, 39);
            this.AmountBox.TabIndex = 66;
            this.AmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(98, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.panel2.Controls.Add(this.BranchText);
            this.panel2.Controls.Add(this.ProjectText);
            this.panel2.Controls.Add(this.EmployeeText);
            this.panel2.Controls.Add(this.DepartmentsText);
            this.panel2.Controls.Add(this.SalaryText);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 738);
            this.panel2.TabIndex = 71;
            // 
            // BranchText
            // 
            this.BranchText.BackColor = System.Drawing.Color.MidnightBlue;
            this.BranchText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BranchText.ForeColor = System.Drawing.Color.AliceBlue;
            this.BranchText.Location = new System.Drawing.Point(0, 195);
            this.BranchText.Name = "BranchText";
            this.BranchText.Size = new System.Drawing.Size(185, 30);
            this.BranchText.TabIndex = 72;
            this.BranchText.Text = "BRANCH";
            this.BranchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectText
            // 
            this.ProjectText.BackColor = System.Drawing.Color.MidnightBlue;
            this.ProjectText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProjectText.ForeColor = System.Drawing.Color.AliceBlue;
            this.ProjectText.Location = new System.Drawing.Point(0, 350);
            this.ProjectText.Name = "ProjectText";
            this.ProjectText.Size = new System.Drawing.Size(185, 30);
            this.ProjectText.TabIndex = 68;
            this.ProjectText.Text = "PROJECT";
            this.ProjectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeText
            // 
            this.EmployeeText.BackColor = System.Drawing.Color.MidnightBlue;
            this.EmployeeText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmployeeText.ForeColor = System.Drawing.Color.AliceBlue;
            this.EmployeeText.Location = new System.Drawing.Point(0, 297);
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
            this.DepartmentsText.Location = new System.Drawing.Point(0, 245);
            this.DepartmentsText.Name = "DepartmentsText";
            this.DepartmentsText.Size = new System.Drawing.Size(185, 30);
            this.DepartmentsText.TabIndex = 8065;
            this.DepartmentsText.Text = "DEPARTMENT";
            this.DepartmentsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalaryText
            // 
            this.SalaryText.BackColor = System.Drawing.Color.RoyalBlue;
            this.SalaryText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalaryText.ForeColor = System.Drawing.Color.AliceBlue;
            this.SalaryText.Location = new System.Drawing.Point(0, 400);
            this.SalaryText.Name = "SalaryText";
            this.SalaryText.Size = new System.Drawing.Size(185, 30);
            this.SalaryText.TabIndex = 66;
            this.SalaryText.Text = "SALARY";
            this.SalaryText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork__2_;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 784);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1384, 52);
            this.panel4.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(911, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 77;
            this.label8.Text = "Salary List";
            // 
            // Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 836);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Salaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salaries";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryList)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox SalaryEmployeeBox;
        private System.Windows.Forms.TextBox DaysBox;
        private System.Windows.Forms.DataGridView SalaryList;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BranchText;
        private System.Windows.Forms.Label ProjectText;
        private System.Windows.Forms.Label EmployeeText;
        private System.Windows.Forms.Label DepartmentsText;
        private System.Windows.Forms.Label SalaryText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
    }
}