using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; // 引入命名空间
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.InteropServices;

namespace Admin
{
    public partial class Login : Form
    {
        //  创建记住密码文件和历史记录文件
        private string filepath = System.Environment.CurrentDirectory + "\\data.bin";
        private string file = System.Environment.CurrentDirectory + "\\history.bin";

        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录效验
        /// </summary>
        private void login_btn_Click(object sender, EventArgs e)
        {
            // 获取变量（账号、密码、记住密码、自动登录）
            var userid = txt_id.Text.Trim();
            var userpwd = txt_pwd.Text.Trim();
            var isremeber = rem_pwd.Checked;
            var isauto = is_auto.Checked;
            this.cel_btn.Visible = true;         //  隐藏按钮显示
            this.login_btn.Visible = false;      // 登录按钮隐藏
            
            // 校验空值
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(userpwd))
            {
                //	当账号或密码为空时，提示信息和提示图片显示，确定按钮下移
                this.Null_Label.Visible = true;     // 提示文字
                this.picwarn.Visible = true;        // 提示图片
                this.login_btn.Visible = true;      // 登录按钮显示
                this.cel_btn.Visible = false;       //  隐藏按钮隐藏
                return;
                //this.del_btn.Enabled = false;
            }
            else
            {
                string sql = "select * from AdminInfo where Uid='" + userid + "' and Pwd='" + userpwd + "'";

                if (DataClass.Sqllogin(DataClass.strConn, sql) == true)
                {
                    //登录成功，校验是否记录文件。
                    if (File.Exists(filepath)) File.Delete(filepath); //如果存在文件，则删除
                    if (isremeber)//记住密码，则重新记录文件
                    {
                        var strs = new List<string>();
                        strs.Add(userid);
                        strs.Add(userpwd);
                        strs.Add(isremeber ? "1" : "0");
                        strs.Add(isauto ? "1" : "0");
                        File.AppendAllLines(filepath, strs);
                        //为了避免添加重复项，还得先读取文件校验
                        var flag = false;//表示没有此ID
                        if (File.Exists(file))
                        {
                            var strlist = File.ReadAllLines(file);
                            foreach (var str in strlist)
                            {
                                //每一行的str内容就是 001,001,1；需要根据逗号切割取第一个
                                var id = str.Split(',')[0];
                                if (id == userid)//如果文件中该ID，则不重复添加
                                {
                                    flag = true;//表示该ID已经存在
                                }
                            }
                        }
                        if (!flag)//如果没有该ID，则添加
                            File.AppendAllText(file, string.Join(",", strs) + "\n");
                    }

                    //过三秒显示主窗口
                    timer1 = new System.Timers.Timer();
                    timer1.Interval = 3000;
                    timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
                    timer1.Start();

                }
                else
                {
                    this.login_btn.Visible = true;      // 登录按钮显示
                    this.cel_btn.Visible = false;       //  隐藏按钮隐藏
                    MessageBox.Show("登录失败！");
                }
            }

        }

                        


        // 窗口实现自由拖动效果
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void top_pel_MouseDown(object sender, MouseEventArgs e)
        {
            // 用try实现，如果有异常则报出异常
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //  密码框聚焦
        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {
            this.Wrong_Label.Visible = false;           // 红色提示1：账号或密码错误
            this.Null_Label.Visible = false;            // 红色提示2：账号或密码不能为空
            this.picwarn.Visible = false;              // 红色提示2：红色感叹号
            this.login_btn.Visible = true;           // 登录按钮显示
            this.cel_btn.Visible = false;           //  隐藏按钮隐藏
        } 
        //  账号框聚焦
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            this.Wrong_Label.Visible = false;           // 红色提示1：账号或密码错误
            this.Null_Label.Visible = false;            // 红色提示2：账号或密码不能为空
            this.picwarn.Visible = false;              // 红色提示2：红色感叹号
            this.login_btn.Visible = true;           // 登录按钮显示
            this.cel_btn.Visible = false;           //  隐藏按钮隐藏
        }

        /// <summary>
        ///   延迟几秒登录，使使用者有时间点击取消按钮
        /// </summary>
        System.Timers.Timer timer1;
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer1.Stop();
            Invoke(new Action(() =>
            {
                Main frm = new Main();
                frm.Show();
                Hide();

            }));  //调试的时候在线程里直接操作界面会报错，加个Invoke就不会报错了

        }

        //  点击账号框加载历史账号
        private void txt_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            //选择ID时就不再是添加了，而是根据文件读取密码到密码框，所以先清空密码框，再读
            this.txt_pwd.Clear();
            var id = this.txt_id.Text;
            var strs = File.ReadAllLines(file);
            foreach (var str in strs)
            {
                var _id = str.Split(',')[0];
                if (id == _id)
                {
                    var pwd = str.Split(',')[1];
                    this.txt_pwd.Text = pwd;
                    return;//找到密码，就不再继续循环
                }
            }
        }

        //  页面显示世触发
        private void Login_Shown(object sender, EventArgs e)
        {
            //加载历史账号
            if (File.Exists(file))
            {
                //  读取历史文件
                var strs = File.ReadAllLines(file);
                foreach (var str in strs)
                {
                    var id = str.Split(',')[0];
                    this.txt_id.Items.Add(id);
                }
            }
            if (!File.Exists(filepath)) return;
            var lines = File.ReadAllLines(filepath);
            this.txt_id.Text = lines[0];
            this.txt_pwd.Text = lines[1];
            if (lines[2] == "1")
            {
                this.rem_pwd.Checked = true;
            }
            else
            {
                this.rem_pwd.Checked = false;
            }

            if (lines[3] == "1")
            {
                this.is_auto.Checked = true;
                this.login_btn.PerformClick();
                //Hide();
            }
            else
            {
                this.is_auto.Checked = false;
            }
        }

        //  自动登录
        private void is_auto_CheckedChanged(object sender, EventArgs e)
        {
            this.rem_pwd.Checked = true;
        }

         // 取消按钮
        private void cel_btn_Click(object sender, EventArgs e)
        {
            this.login_btn.Visible = true;
            this.cel_btn.Visible = false;
            timer1.Stop();
        }

    }
}
