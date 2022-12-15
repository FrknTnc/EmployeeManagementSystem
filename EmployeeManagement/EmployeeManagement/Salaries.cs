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
    public partial class Salaries : Form
    {
        Functions connection;
        public Salaries()
        {
            InitializeComponent();
            connection = new Functions();
            ShowSalaries();
            GetEmployees();
        }

        private void GetEmployees()
        {
            string Query = "select * from Employee";
            SalaryEmployeeBox.DisplayMember = connection.GetData(Query).Columns["EmployeeName"].ToString();
            SalaryEmployeeBox.ValueMember = connection.GetData(Query).Columns["EmployeeID"].ToString();
            SalaryEmployeeBox.DataSource = connection.GetData(Query);
        }

        int dailySalary = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "select EmployeeSalary from Employee where EmployeeName = {0}";
            Query = String.Format(Query, SalaryEmployeeBox.SelectedValue.ToString());
            foreach(DataRow dataRow in connection.GetData(Query).Rows)
            {
                dailySalary = Convert.ToInt32(dataRow["EmployeeSalary"].ToString());
            }
            //MessageBox.Show("" + Salaryy);
            //SalaryEmployeeBox.DataSource = connection.GetData(Query);
            

            if(DaysBox.Text == "")
            {
                AmountBox.Text = (d * dailySalary) + " TL";
            }else if(Convert.ToInt32(DaysBox.Text) > 31 )
            {
                MessageBox.Show("Days Can not be Greater Then 31 ");
            }
            else
            {
                d = Convert.ToInt32(DaysBox.Text);
                AmountBox.Text = "" + (d * dailySalary) + " TL";
            }
        }

        private void ShowSalaries()
        {
            string Query = "Select * from SalaryTable";
            SalaryList.DataSource = connection.GetData(Query);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int d = 1;
        private void AddSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if(SalaryEmployeeBox.SelectedIndex == -1 || DaysBox.Text == "" || PeriodDate.Text == "" )
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    Period = PeriodDate.Value.Date.Month.ToString() + "-" + PeriodDate.Value.Date.Year.ToString();
                    int Amount = dailySalary * (Convert.ToInt32(PeriodDate.Text));
                    int Days = Convert.ToInt32(DaysBox.Text);
                    string Query = "insert into SalaryTable values({0},{1}, '{2}',{3}, '{4}')";
                    Query = string.Format(Query, SalaryEmployeeBox.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    connection.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Salary Paid !!!");
                    DaysBox.Text = "";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SalaryEmployeeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DaysBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LogoutText_Click(object sender, EventArgs e)
        {

        }
    }
}
