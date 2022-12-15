using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Departments : Form
    {
        Functions connection;
        public Departments()
        {
            InitializeComponent();
            connection = new Functions();
            ShowDepartments();
        }

        private void ShowDepartments()
        {
            string Query = "Select * from Department";
            DepartmentList.DataSource = connection.GetData(Query);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepartmentNameTable.Text == "")
                {
                    MessageBox.Show("Missing Data Entered !");
                }
                else
                {
                    string departmentText = DepartmentNameTable.Text;
                    string Query = "insert into Department values('{0}')";
                    Query = string.Format(Query, DepartmentNameTable.Text);
                    connection.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added !");
                    DepartmentNameTable.Text = "";
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        int Key = 0;
        private void DptList_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

            DepartmentList.CurrentRow.Selected= true;
            DepartmentNameTable.Text = DepartmentList.Rows[e.RowIndex].Cells["DepartmentName"].Value.ToString();

            if(DepartmentNameTable.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepartmentList.SelectedRows[0].Cells[0].Value.ToString());
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartmentNameTable.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    string departmentText = DepartmentNameTable.Text;
                    string Query = "Delete from Department where DepartmentID = {0}";
                    Query = string.Format(Query, Key);
                    connection.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted !!!");
                    DepartmentNameTable.Text = "";

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartmentNameTable.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    string departmentText = DepartmentNameTable.Text;
                    string Query = "Update Department set DepartmentName= '{0}' where DepartmentID = {1}";
                    Query = string.Format(Query, DepartmentNameTable.Text, Key);
                    connection.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated !!!");
                    DepartmentNameTable.Text = "";

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void EmployeeText_Click(object sender, EventArgs e)
        {
            Employees Object = new Employees();
            Object.Show();
            this.Hide();
        }

        private void SalaryText_Click(object sender, EventArgs e)
        {
            Salaries Object = new Salaries();
            Object.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LogoutText_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectText_Click(object sender, EventArgs e)
        {
            Works Object = new Works();
            Object.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BranchText_Click(object sender, EventArgs e)
        {
            Branch Object = new Branch();
            Object.Show();
            this.Hide();
        }
    }
}
