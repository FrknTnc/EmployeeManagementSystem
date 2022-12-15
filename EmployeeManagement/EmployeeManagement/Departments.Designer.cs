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
            this.BranchText = new System.Windows.Forms.Label();
            this.ProjectText = new System.Windows.Forms.Label();
            this.EmployeeText = new System.Windows.Forms.Label();
            this.DepartmentsText = new System.Windows.Forms.Label();
            this.SalaryText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.getBranchID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(278, 154);
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
            this.DepartmentNameTable.Location = new System.Drawing.Point(282, 192);
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
            this.label3.Location = new System.Drawing.Point(841, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Department List";
            // 
            // DepartmentList
            // 
            this.DepartmentList.ColumnHeadersHeight = 45;
            this.DepartmentList.Location = new System.Drawing.Point(762, 192);
            this.DepartmentList.Name = "DepartmentList";
            this.DepartmentList.RowHeadersWidth = 45;
            this.DepartmentList.Size = new System.Drawing.Size(336, 486);
            this.DepartmentList.TabIndex = 62;
            this.DepartmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DptList_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.panel3.Controls.Add(this.BranchText);
            this.panel3.Controls.Add(this.ProjectText);
            this.panel3.Controls.Add(this.EmployeeText);
            this.panel3.Controls.Add(this.DepartmentsText);
            this.panel3.Controls.Add(this.SalaryText);
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 727);
            this.panel3.TabIndex = 68;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.BranchText.Click += new System.EventHandler(this.BranchText_Click);
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
            this.ProjectText.Click += new System.EventHandler(this.ProjectText_Click);
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
            this.EmployeeText.Click += new System.EventHandler(this.EmployeeText_Click);
            // 
            // DepartmentsText
            // 
            this.DepartmentsText.BackColor = System.Drawing.Color.RoyalBlue;
            this.DepartmentsText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmentsText.ForeColor = System.Drawing.Color.AliceBlue;
            this.DepartmentsText.Location = new System.Drawing.Point(0, 245);
            this.DepartmentsText.Name = "DepartmentsText";
            this.DepartmentsText.Size = new System.Drawing.Size(185, 30);
            this.DepartmentsText.TabIndex = 8065;
            this.DepartmentsText.Text = "DEPARTMENT";
            this.DepartmentsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DepartmentsText.Click += new System.EventHandler(this.label5_Click);
            // 
            // SalaryText
            // 
            this.SalaryText.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalaryText.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalaryText.ForeColor = System.Drawing.Color.AliceBlue;
            this.SalaryText.Location = new System.Drawing.Point(0, 400);
            this.SalaryText.Name = "SalaryText";
            this.SalaryText.Size = new System.Drawing.Size(185, 30);
            this.SalaryText.TabIndex = 66;
            this.SalaryText.Text = "SALARY";
            this.SalaryText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalaryText.Click += new System.EventHandler(this.SalaryText_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(364, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 51);
            this.button1.TabIndex = 63;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork__2_;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 784);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 52);
            this.panel2.TabIndex = 60;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Khaki;
            this.UpdateButton.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UpdateButton.Location = new System.Drawing.Point(364, 521);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(165, 51);
            this.UpdateButton.TabIndex = 59;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddButton.BackgroundImage = global::EmployeeManagement.Properties.Resources.teamwork;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddButton.Location = new System.Drawing.Point(364, 443);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(165, 51);
            this.AddButton.TabIndex = 58;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
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
            this.panel1.Size = new System.Drawing.Size(1384, 72);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(443, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
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
            this.label6.Location = new System.Drawing.Point(278, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Branch ID";
            // 
            // getBranchID
            // 
            this.getBranchID.BackColor = System.Drawing.Color.Lavender;
            this.getBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getBranchID.FormattingEnabled = true;
            this.getBranchID.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.getBranchID.Location = new System.Drawing.Point(282, 319);
            this.getBranchID.Name = "getBranchID";
            this.getBranchID.Size = new System.Drawing.Size(338, 45);
            this.getBranchID.TabIndex = 73;
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 836);
            this.Controls.Add(this.getBranchID);
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
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Departments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DepartmentList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EmployeeText;
        private System.Windows.Forms.Label DepartmentsText;
        private System.Windows.Forms.Label SalaryText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ProjectText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BranchText;
        private System.Windows.Forms.ComboBox getBranchID;
    }
}