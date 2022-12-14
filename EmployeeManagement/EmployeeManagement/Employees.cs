using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Employees : Form
    {
        Functions connection;
        public Employees()
        {
            InitializeComponent();
            connection = new Functions();
            ShowEmployees();
            GetDepartment();
        }

        private void ShowEmployees()
        {
            try
            {
                string Query = "Select * from Employee";
                EmployeeList.DataSource = connection.GetData(Query);
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void GetBranch()
        {
            string Query = "select * from Branch";

        }

        private void GetDepartment()
        {
            string Query = "select * from Department";
            DepartmentBox.DisplayMember = connection.GetData(Query).Columns["DepartmentName"].ToString();
            DepartmentBox.ValueMember = connection.GetData(Query).Columns["DepartmentID"].ToString();
            DepartmentBox.DataSource = connection.GetData(Query);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeNameBox.Text == "" || GenderBox.SelectedIndex == -1 || DepartmentBox.SelectedIndex == -1 || SalaryBox.Text == "")
                {
                    MessageBox.Show("Missing Data !!");
                }
                else
                {
                    string EmpName = EmployeeNameBox.Text;
                    string EmpGender = GenderBox.SelectedItem.ToString();
                    int EmpDepartment = Convert.ToInt32(DepartmentBox.SelectedValue.ToString());
                    string EmpBirthday = DateBox1.Value.ToString();
                    string EmpJoinDate = DateBox2.Value.ToString();
                    int EmpSalary = Convert.ToInt32(SalaryBox.Text);

                    string Query = "insert into Employee values('{0}','{1}', '{2}','{3}', '{4}','{5}')";
                    Query = string.Format(Query, EmpName, EmpGender, EmpDepartment, EmpBirthday, EmpJoinDate, EmpSalary );
                    connection.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Added !!!");
                    EmployeeNameBox.Text = "";
                    SalaryBox.Text = "";
                    GenderBox.SelectedIndex = -1;
                    DepartmentBox.SelectedIndex = -1;


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeNameBox.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenderBox.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepartmentBox.Text = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DateBox1.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            DateBox2.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            SalaryBox.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();

            if (EmployeeNameBox.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data !!");
                }
                else
                {

                    string Query = "Delete from Employee where EmployeeID = {0}";
                    Query = string.Format(Query, Key);
                    connection.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Deleted !!!");
                    EmployeeNameBox.Text = "";
                    SalaryBox.Text = "";
                    GenderBox.SelectedIndex = -1;
                    DepartmentBox.SelectedIndex = -1;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeNameBox.Text == "" || GenderBox.SelectedIndex == -1 || DepartmentBox.SelectedIndex == -1 || SalaryBox.Text == "")
                {
                    MessageBox.Show("Missing Data !!");
                }
                else
                {
                    string EmpName = EmployeeNameBox.Text;
                    string EmpGender = GenderBox.SelectedItem.ToString();
                    int EmpDepartment = Convert.ToInt32(DepartmentBox.SelectedValue.ToString());
                    string EmpBirthday = DateBox1.Value.ToString();
                    string EmpJoinDate = DateBox2.Value.ToString();
                    int EmpSalary = Convert.ToInt32(SalaryBox.Text);

                    string Query = "Update Employee set EmployeeName = '{0}', EmployeeGender='{1}', EmployeeDepartment = '{2}', EmployeeBirthday = '{3}', EmployeeStartDate =  '{4}', EmployeeSalary='{5}' where EmployeeID = {6}";
                    Query = string.Format(Query, EmpName, EmpGender, EmpDepartment, EmpBirthday, EmpJoinDate, EmpSalary, Key);
                    connection.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Updated !!!");
                    EmployeeNameBox.Text = "";
                    SalaryBox.Text = "";
                    GenderBox.SelectedIndex = -1;
                    DepartmentBox.SelectedIndex = -1;


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Employee_EmployeeClick(object sender, EventArgs e)
        {
            Employees Object = new Employees();
            Object.Show();
            this.Hide();
        }

        private void Employee_SalaryClick(object sender, EventArgs e)
        {
            Salaries Object = new Salaries();
            Object.Show();
            this.Hide();
        }
    }
}
