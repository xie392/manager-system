using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admin.Children
{
    public partial class newClass : Form
    {
        public Action insertAction;
        public newClass()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="DataClassr">连接数据库和执行sql命令的类</param>
        /// <param name="e"></param>
        private void save_btn_Click(object sender, EventArgs e)
        {
            string id = this.Dep_txt.Text.Trim();
            string name = this.name_txt.Text.Trim();
            string root = this.box_txt.Text.Trim();
            string num = this.num_txt.Text.Trim();

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(root) ||
                string.IsNullOrEmpty(num))
            {
                MessageBox.Show("文本不能留空！");
            }
            else
            {
                string sql = "insert into ClassInfo (ClassId,ClassName,ClassBoss,ClassNumber) values  ('" + id + "','" + name + "','" + root + "','" + num + "')";
                if (DataClass.SqlAdd(DataClass.strConn, sql) == true)
                {
                    MessageBox.Show("保存成功");
                    if (insertAction != null) insertAction();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败");
                }

            }

        }

        private void cel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
