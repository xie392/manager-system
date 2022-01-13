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
    public partial class newEmploy : Form
    {
        public Action insertAction;
        public newEmploy()
        {
            InitializeComponent();
        }

        private void newEmploy_Load(object sender, EventArgs e)
        {

        }

        //保存
        private void save_btn_Click(object sender, EventArgs e)
        {
            string id = this.userId.Text.Trim();            // 员工编号
            string name = this.userName.Text.Trim();        // 姓名
            string age = this.userAge.Text.Trim();          // 年龄
            string sex = this.userSex.Text.Trim();          // 性别
            string face = this.userFace.Text.Trim();      // 政治面貌
            string userBoth = this.userBoth.Text.Trim();    // 出生日期
            string userDep = this.userDep.Text.Trim();      // 所属部门
            string userAdress = this.userAdress.Text.Trim(); // 地址
            string userPhone = this.userPhone.Text.Trim();     // 手机号码
            string userShenfen = this.userShenfen.Text.Trim();  // 身份证
            string userIn = this.userIn.Text.Trim();        // 入职时间
            string userEmail = this.userEmail.Text.Trim();  // 邮箱
            //效验空值
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age)
               || string.IsNullOrEmpty(sex) || string.IsNullOrEmpty(userBoth) ||
               string.IsNullOrEmpty(userDep) || string.IsNullOrEmpty(userAdress) ||
               string.IsNullOrEmpty(userPhone) || string.IsNullOrEmpty(userShenfen) ||
               string.IsNullOrEmpty(userIn))
            {
                MessageBox.Show("文本不能留空！");
            }
            else {
                string sql = "insert into EmployInfo (UseId,Name,Sex,Age,Hiredate,Birthday,Face,ClassName,Address,Phone,Id,Email) values  ('" + id + "','" + name + "','" + sex + "','" + age + "','" + userIn + "','" + userBoth + "','" + face + "','" + userDep + "','" + userAdress + "','" + userPhone + "','" + userShenfen + "','" + userEmail + "')";
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
