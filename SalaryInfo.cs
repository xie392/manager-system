using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Admin.Children;
using System.Data.SqlClient;

namespace Admin
{
    public partial class SalaryInfo : Form
    {
        public Action insertAction; 
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter sda;
        public SalaryInfo()
        {
            InitializeComponent();
        }

        private void mod_btn_Click(object sender, EventArgs e)
        {

        }

        //返回
        private void back_btn_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void SalaryInfo_Load(object sender, EventArgs e)
        {
            RefreshAction();
            //search_txt.LostFocus += new EventHandler(search_txt_LostFocus);
        }

        private void RefreshAction()
        {
            string connStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Admin.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connStr);
            string sql = "select * from SalaryInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "department");
            dataGridView.DataSource = ds.Tables["department"];

            //  只读
            dataGridView.ReadOnly = true;

            //  不允许添加行
            dataGridView.AllowUserToAddRows = false;
        }
        // 发放工资
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows == null || dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要修改的项");
                return;
            }
            var id = this.txtId.Text;
            var selectindex = dataGridView.SelectedRows[0].Index;
            var state = dataGridView.Rows[selectindex].Cells["state"].Value.ToString();
            if (state == "未发放")
            {
                string sql = "UPDATE SalaryInfo SET state = '已发放 '  WHERE  UserId = '" + id + "'";

                if (DataClass.SqlUpDatee(DataClass.strConn, sql) == true)
                {
                    MessageBox.Show("发放成功！");
                    RefreshAction();
                    //if (insertAction != null) insertAction();
                    this.add_btn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("发放失败！");
                }
            }
            else 
            {
                MessageBox.Show("已发放！");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.add_btn.Enabled = true;
            //dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Selected = true;
            //MessageBox.Show(this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            //if (this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            //{
            //    this.txtId.Text = this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            //}
           
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.add_btn.Enabled = true;
            dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Selected = true;
            if (this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                this.txtId.Text = this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
