using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Class_btn_Click(object sender, EventArgs e)
        {
            ClassInfo f1 = new ClassInfo();
            f1.Show();
            this.Hide();
        }

        private void Employ_btn_Click(object sender, EventArgs e)
        {
            EmployInfo f2 = new EmployInfo();
            f2.Show();
            this.Hide();
        }

        private void Salary_btn_Click(object sender, EventArgs e)
        {
            SalaryInfo f3 = new SalaryInfo();
            f3.Show();
            this.Hide();
        }

        private void Pwd_btn_Click(object sender, EventArgs e)
        {
            Password f4 = new Password();
            f4.Show();
            this.Hide();
        }


    }
}
