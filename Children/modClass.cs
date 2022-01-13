using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin.Children
{
    public partial class modClass : Form
    {
         public Action insertAction; 
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public modClass()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 有参数的构造函数
        /// </summary>
        /// <param name="depno">编号</param>
        /// <param name="depname"></param>
        /// <param name="depboss"></param>
        /// <param name="depNumber"></param>
        public modClass(string depno, string depname, string depboss, string depNumber): this()
        {
            // TODO: Complete member initialization
            this.Dep_txt.Text = depno;
            this.name_txt.Text = depname;
            this.box_txt.Text = depboss;
            this.num_txt.Text = depNumber;
        }

        private void modClass_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string id = this.Dep_txt.Text.Trim();
            string name = this.name_txt.Text.Trim();
            string root = this.box_txt.Text.Trim();
            string num = this.num_txt.Text.Trim();
        
            if (string.IsNullOrEmpty(id) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(root) ||
                string.IsNullOrEmpty(num))
            {
                MessageBox.Show("文本不能留空！");
            }
            else
            {
                string sql = "UPDATE ClassInfo SET  ClassName ='" + name + "', ClassBoss = '" + root + "', ClassNumber = '" + num + "'  WHERE  ClassId = '" + id + "'";

                if (DataClass.SqlUpDatee(DataClass.strConn, sql) == true)
                {
                    MessageBox.Show("修改成功");
                    if (insertAction != null) insertAction();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("部门编号不正确，修改失败！");
                }

            }
        }

        private void cel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
