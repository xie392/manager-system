using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Admin.Children;

namespace Admin
{
    public partial class ClassInfo : Form
    {
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter sda;

        public ClassInfo()
        {
            InitializeComponent();
        }

        private void ClassInfo_Load(object sender, EventArgs e)
        {
            RefreshAction();
            search_txt.LostFocus += new EventHandler(search_txt_LostFocus);
        }

        void search_txt_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search_txt.Text))
            {
                this.search_txt.Text = "请输入部门名称";
                this.search_txt.ForeColor = Color.Silver;
            }
        }

        //  返回按钮
        private void back_btn_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        //  搜索框点击时把提示清除，并且把文字颜色改为黑色
        private void search_txt_Click(object sender, EventArgs e)
        {
            if (this.search_txt.Text.Trim() == "请输入部门名称")
            {
                this.search_txt.Text = "";
                this.search_txt.ForeColor = Color.Black;
            }
        }


        //  添加按钮
        private void add_btn_Click(object sender, EventArgs e)
        {
            newClass f1 = new newClass();
            f1.insertAction = RefreshAction;
            f1.Show();
            this.search_txt.Text = "请输入部门名称";
            this.search_txt.ForeColor = Color.Silver;
        }

        private void RefreshAction()
        {
            string connStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Admin.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connStr);
            string sql = "select * from ClassInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "department");
            dataGridView.DataSource = ds.Tables["department"];

            //  只读
            dataGridView.ReadOnly = true;

            //  不允许添加行
            dataGridView.AllowUserToAddRows = false;
        }

        //修改
        private void mod_btn_Click(object sender, EventArgs e)
        {
            //获取选中的项，校验是否选中，如果没选中，不允许修改，如果选中，则将值传到修改窗体。
            if (dataGridView.SelectedRows == null || dataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("请选中要修改的项");
                return;
            }
            var selectindex = dataGridView.SelectedRows[0].Index;
            //获取改行的值
            var depno = dataGridView.Rows[selectindex].Cells["ClassId"].Value.ToString();
            var depname = dataGridView.Rows[selectindex].Cells["ClassName"].Value.ToString();
            var depboss = dataGridView.Rows[selectindex].Cells["ClassBoss"].Value.ToString();
            var depNumber = dataGridView.Rows[selectindex].Cells["ClassNumber"].Value.ToString();
            modClass f2 = new modClass(depno, depname, depboss, depNumber); //带参数
            f2.insertAction = RefreshAction;
            f2.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.search_txt.Text = "请输入部门名称";
            this.search_txt.ForeColor = Color.Silver;
            this.mod_btn.Enabled = true;
            this.del_btn.Enabled = true;
            dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Selected = true;
            if (this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                this.txt_id.Text = this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            this.search_txt.Text = "请输入部门名称";
            this.search_txt.ForeColor = Color.Silver;
        }

        //删除
        private void del_btn_Click(object sender, EventArgs e)
        {
            this.search_txt.Text = "请输入部门名称";
            this.search_txt.ForeColor = Color.Silver;
            this.mod_btn.Enabled = false;
            string txtid = this.txt_id.Text.Trim();
            string sql = "DELETE FROM ClassInfo WHERE ClassId = '" + txtid + "'";
            if (DataClass.SqlDel(DataClass.strConn, sql) == true)
            {
                MessageBox.Show("删除成功");
                RefreshAction();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
            this.del_btn.Enabled = false;
        }

        //   搜索
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.search_txt.Text)) this.search_txt.Text = "请输入部门名称";
            //this.search_txt.ForeColor = Color.Silver;
            string search = this.search_txt.Text.Trim();
            if (search == "请输入部门名称") search = "";
            string sql = "SELECT * FROM ClassInfo WHERE ClassName  Like  '%" + search + "%'";

            if (DataClass.Sqlselect(DataClass.strConn, sql) == true)
            {
                string connStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Admin.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(connStr);

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "department");
                dataGridView.DataSource = ds.Tables["department"];

                //  只读
                dataGridView.ReadOnly = true;

                //  不允许添加行
                dataGridView.AllowUserToAddRows = false;
            }
            else
            {
                MessageBox.Show("没有该部门！");
            }

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
