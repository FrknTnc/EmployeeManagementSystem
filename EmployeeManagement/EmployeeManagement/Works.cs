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
    public partial class Works : Form
    {
        public Works()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BranchText_Click(object sender, EventArgs e)
        {
            Branch Object = new Branch();
            Object.Show();
            this.Hide();
        }

        private void DepartmentsText_Click(object sender, EventArgs e)
        {
            Departments Object = new Departments();
            Object.Show();
            this.Hide();
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
    }
}
