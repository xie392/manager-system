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
    public partial class modEmploy : Form
    {
        public Action insertAction; 
        public modEmploy()
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
        public modEmploy(string UseId, string Name, string Sex, string Age,string Hiredate,string Birthday,string Face,string ClassName,string Address,string Phone,string Id,string Email):this()
        {
            // TODO: Complete member initialization
            this.userId.Text = UseId;
            this.userName.Text = Name;
            this.userSex.Text = Sex;
            this.userAge.Text = Age;
            this.userIn.Text = Hiredate;
            this.userBoth.Text = Birthday;
            this.userFace.Text = Face;
            this.userDep.Text = ClassName;
            this.userAdress.Text = Address;
            this.userPhone.Text = Phone;
            this.userShenfen.Text = Id;
            this.userEmail.Text = Email;
        }


        private void modEmploy_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

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
                // UseId,Name,Sex,Age,Hiredate,Birthday,Face,ClassName,Address,Phone,Id,Email
                string sql = "UPDATE EmployInfo SET  Name ='" + name + "', Sex = '" + sex + "', Age = '" + age + "', Hiredate = '" + userIn + "', Birthday = '" + userBoth + "', Face = '" + face + "', ClassName = '" + userDep + "', Address = '" + userAdress + "', Phone = '" + userPhone + "', Id = '" + userShenfen + "',Email = '" + userEmail + "'  WHERE  UseId = '" + id + "'";
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
        //取消
        private void cel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
