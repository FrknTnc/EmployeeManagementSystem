namespace EmployeeManagement
{
    partial class Departments
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
            this.label2 = new System.Windows.Forms.Label();
            this.DepartmentNameTable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepartmentList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployeeText = new System.Windows.Forms.Label();
            this.DepartmentsText = new System.Windows.Forms.Label();
            this.SalaryText = new System.Windows.Forms.Label();
            this.LogoutText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.getBranchID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(325, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Department Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DepartmentNameTable
            // 
            this.DepartmentNameTable.BackColor = System.Drawing.Color.Lavender;
            this.DepartmentNameTable.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmentNameTable.Location = new System.Drawing.Point(329, 269);
            this.DepartmentNameTable.Name = "DepartmentNameTable";
            this.DepartmentNameTable.Size = new System.Drawing.Size(338, 46);
            this.DepartmentNameTable.TabIndex = 45;
            this.DepartmentNameTable.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(808, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Department List";
            // 
            // DepartmentList
            // 
            this.DepartmentList.ColumnHeadersHeight = 45;
            this.DepartmentList.Location = new System.Drawing.Point(755, 214);
            this.DepartmentList.Name = "DepartmentList";
            this.DepartmentList.RowHeadersWidth = 45;
            this.DepartmentList.Size = new System.Drawing.Size(814, 506);
            this.DepartmentList.TabIndex = 62;
            this.DepartmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DptList_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.EmployeeText);
            this.panel3.Controls.Add(this.DepartmentsText);
            this.panel3.Controls.Add(this.SalaryText);
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 727);
            this.panel3.TabIndex = 68;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Lavender;
            this.label11.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(17, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 23);
            this.label11.TabIndex = 72;
            this.label11.Text = "Add Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Lavender;
            this.label10.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(12, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 23);
            this.label10.TabIndex = 8066;
            this.label10.Text = "Delete Project";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Lavender;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(12, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "Update Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "Add Project";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Lavender;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(12, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 23);
            this.label8.TabIndex = 73;
            this.label8.Text = "Delete Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lavender;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 23);
            this.label7.TabIndex = 72;
            this.label7.Text = "Update Employee";
            // 
            // EmployeeText
            // 
            this.EmployeeText.AutoSize = true;
            this.EmployeeText.BackColor = System.Drawing.Color.Lavender;
            this.EmployeeText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmployeeText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EmployeeText.Location = new System.Drawing.Point(12, 179);
            this.EmployeeText.Name = "EmployeeText";
            this.EmployeeText.Size = new System.Drawing.Size(151, 23);
            this.EmployeeText.TabIndex = 64;
            this.EmployeeText.Text = "Add Employee";
            this.EmployeeText.Click += new System.EventHandler(this.EmployeeText_Click);
            // 
            // DepartmentsText
            // 
            this.DepartmentsText.AutoSize = true;
            this.DepartmentsText.BackColor = System.Drawing.Color.Lavender;
            this.DepartmentsText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmentsText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DepartmentsText.Location = new System.Drawing.Point(12, 297);
            this.DepartmentsText.Name = "DepartmentsText";
            this.DepartmentsText.Size = new System.Drawing.Size(183, 23);
            this.DepartmentsText.TabIndex = 8065;
            this.DepartmentsText.Text = "Add Departments";
            this.DepartmentsText.Click += new System.EventHandler(this.label5_Click);
            // 
            // SalaryText
            // 
            this.SalaryText.AutoSize = true;
            this.SalaryText.BackColor = System.Drawing.Color.Lavender;
            this.SalaryText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalaryText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SalaryText.Location = new System.Drawing.Point(12, 457);
            this.SalaryText.Name = "SalaryText";
            this.SalaryText.Size = new System.Drawing.Size(118, 23);
            this.SalaryText.TabIndex = 66;
            this.SalaryText.Text = "SalaryText";
            this.SalaryText.Click += new System.EventHandler(this.SalaryText_Click);
            // 
            // LogoutText
            // 
            this.LogoutText.AutoSize = true;
            this.LogoutText.BackColor = System.Drawing.Color.Lavender;
            this.LogoutText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogoutText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LogoutText.Location = new System.Drawing.Point(545, 626);
            this.LogoutText.Name = "LogoutText";
            this.LogoutText.Size = new System.Drawing.Size(122, 23);
            this.LogoutText.TabIndex = 67;
            this.LogoutText.Text = "LogoutText";
            this.LogoutText.Click += new System.EventHandler(this.LogoutText_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(351, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 51);
            this.button1.TabIndex = 63;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork__2_;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 783);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 52);
            this.panel2.TabIndex = 60;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UpdateButton.Location = new System.Drawing.Point(351, 532);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(165, 51);
            this.UpdateButton.TabIndex = 59;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddButton.Location = new System.Drawing.Point(351, 464);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(165, 51);
            this.AddButton.TabIndex = 58;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(424, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 118);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(86, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(325, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Branch ID";
            // 
            // getBranchID
            // 
            this.getBranchID.FormattingEnabled = true;
            this.getBranchID.Location = new System.Drawing.Point(329, 361);
            this.getBranchID.Name = "getBranchID";
            this.getBranchID.Size = new System.Drawing.Size(338, 28);
            this.getBranchID.TabIndex = 72;
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 835);
            this.Controls.Add(this.getBranchID);
            this.Controls.Add(this.LogoutText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DepartmentList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartmentNameTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Departments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepartmentNameTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DepartmentList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EmployeeText;
        private System.Windows.Forms.Label DepartmentsText;
        private System.Windows.Forms.Label SalaryText;
        private System.Windows.Forms.Label LogoutText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox getBranchID;
    }
}