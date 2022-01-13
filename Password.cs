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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            string old = this.old_pwd.Text.Trim();
            string newpwd = this.new_pwd.Text.Trim();
            string pwd = this.pwd.Text.Trim();

            if (string.IsNullOrEmpty(old) ||
                string.IsNullOrEmpty(newpwd) ||
                string.IsNullOrEmpty(pwd)  && newpwd == pwd )
            {
                MessageBox.Show("文本不能留空！");
            }
            else
            {
                string sql = "UPDATE AdminInfo SET Pwd ='" + pwd + "'  WHERE  Uid = Uid ";

                if (DataClass.SqlUpDatee(DataClass.strConn, sql) == true)
                {
                    MessageBox.Show("修改密码成功!请重新登录！");
                    Login f = new Login();
                    f.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }

            }
        }
    }
}
