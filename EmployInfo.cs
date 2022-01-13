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
    public partial class EmployInfo : Form
    {
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter sda;


        public EmployInfo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void EmployInfo_Load(object sender, EventArgs e)
        {
            RefreshAction();
        }

        private void RefreshAction()
        {
            string connStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Admin.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connStr);
            string sql = "select * from EmployInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "department");
            dataGridView.DataSource = ds.Tables["department"];

            //  只读
            dataGridView.ReadOnly = true;

            //  不允许添加行
            dataGridView.AllowUserToAddRows = false;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.search_txt.Text = "请输入你要查找的员工姓名";
            this.search_txt.ForeColor = Color.Silver;
            this.mod_btn.Enabled = true;
            this.del_btn.Enabled = true;
            dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Selected = true;
            this.search_txt.Text = "请输入你要查找的员工姓名";
            this.search_txt.ForeColor = Color.Silver;
            if (this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "") {
                this.txtId.Text = this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            
        }

        //  搜索框点击时把提示清除，并且把文字颜色改为黑色
        private void search_txt_Click(object sender, EventArgs e)
        {
            this.search_txt.Text = "";
            this.search_txt.ForeColor = Color.Black;
        }
        //添加
        private void add_btn_Click(object sender, EventArgs e)
        {
            newEmploy f = new newEmploy();
            f.insertAction = RefreshAction;
            f.Show();
       
           
        }
        //修改
        private void mod_btn_Click(object sender, EventArgs e)
        {
            // 获取选中的项，校验是否选中，如果没选中，不允许修改，如果选中，则将值传到修改窗体。
            if (dataGridView.SelectedRows == null || dataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("请选中要修改的项");
                return;
            }
            var selectindex = dataGridView.SelectedRows[0].Index;
            //获取改行的值

            //UseId,Name,Sex,Age,Hiredate,Birthday,Face,ClassName,Address,Phone,Id,Email
            var UseId = dataGridView.Rows[selectindex].Cells["UseId"].Value.ToString();
            var Name = dataGridView.Rows[selectindex].Cells["Name"].Value.ToString();
            var Sex = dataGridView.Rows[selectindex].Cells["Sex"].Value.ToString();
            var Age = dataGridView.Rows[selectindex].Cells["Age"].Value.ToString();
            var Hiredate = dataGridView.Rows[selectindex].Cells["Hiredate"].Value.ToString();
            var Birthday = dataGridView.Rows[selectindex].Cells["Birthday"].Value.ToString();
            var Face = dataGridView.Rows[selectindex].Cells["Face"].Value.ToString();
            var ClassName = dataGridView.Rows[selectindex].Cells["ClassName"].Value.ToString();
            var Address = dataGridView.Rows[selectindex].Cells["Address"].Value.ToString();
            var Phone = dataGridView.Rows[selectindex].Cells["Phone"].Value.ToString();
            var Id = dataGridView.Rows[selectindex].Cells["Id"].Value.ToString();
            var Email = dataGridView.Rows[selectindex].Cells["Email"].Value.ToString();
            modEmploy f = new modEmploy(UseId, Name, Sex, Age, Hiredate, Birthday, Face, ClassName, Address, Phone, Id, Email);
            f.insertAction = RefreshAction;
            f.Show();

        }

        //删除
        private void del_btn_Click(object sender, EventArgs e)
        {
            this.search_txt.Text = "请输入你要查找的员工姓名";
            this.search_txt.ForeColor = Color.Silver;
            string txtid = this.txtId.Text.Trim();
            string sql = "DELETE FROM EmployInfo WHERE UseId = '" + txtid + "'";
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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_txt_Click_1(object sender, EventArgs e)
        {
            if (this.search_txt.Text.Trim() == "请输入你要查找的员工姓名")
            {
                this.search_txt.Text = "";
                this.search_txt.ForeColor = Color.Silver;
            }
        }
        //搜索
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.search_txt.Text)) this.search_txt.Text = "请输入你要查找的员工姓名";
            string search = this.search_txt.Text.Trim();
            if (search == "请输入你要查找的员工姓名") search = "";
            string sql = "SELECT * FROM EmployInfo WHERE Name Like  '%" + search + "%'";
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
                MessageBox.Show("没有该员工！");
            }
        }

    }
}
