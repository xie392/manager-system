namespace Admin
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bottom_pel = new System.Windows.Forms.Panel();
            this.Wrong_Label = new System.Windows.Forms.Label();
            this.picwarn = new System.Windows.Forms.PictureBox();
            this.Null_Label = new System.Windows.Forms.Label();
            this.cel_btn = new System.Windows.Forms.Button();
            this.is_auto = new System.Windows.Forms.CheckBox();
            this.rem_pwd = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.ComboBox();
            this.bottom_pel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picwarn)).BeginInit();
            this.SuspendLayout();
            // 
            // bottom_pel
            // 
            this.bottom_pel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottom_pel.BackgroundImage = global::Admin.Properties.Resources.login;
            this.bottom_pel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottom_pel.Controls.Add(this.Wrong_Label);
            this.bottom_pel.Controls.Add(this.picwarn);
            this.bottom_pel.Controls.Add(this.Null_Label);
            this.bottom_pel.Controls.Add(this.cel_btn);
            this.bottom_pel.Controls.Add(this.is_auto);
            this.bottom_pel.Controls.Add(this.rem_pwd);
            this.bottom_pel.Controls.Add(this.login_btn);
            this.bottom_pel.Controls.Add(this.label3);
            this.bottom_pel.Controls.Add(this.label2);
            this.bottom_pel.Controls.Add(this.txt_pwd);
            this.bottom_pel.Controls.Add(this.txt_id);
            this.bottom_pel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_pel.Location = new System.Drawing.Point(0, 0);
            this.bottom_pel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bottom_pel.Name = "bottom_pel";
            this.bottom_pel.Size = new System.Drawing.Size(633, 336);
            this.bottom_pel.TabIndex = 1;
            // 
            // Wrong_Label
            // 
            this.Wrong_Label.AutoSize = true;
            this.Wrong_Label.BackColor = System.Drawing.Color.Transparent;
            this.Wrong_Label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Wrong_Label.ForeColor = System.Drawing.Color.Red;
            this.Wrong_Label.Location = new System.Drawing.Point(416, 242);
            this.Wrong_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Wrong_Label.Name = "Wrong_Label";
            this.Wrong_Label.Size = new System.Drawing.Size(127, 15);
            this.Wrong_Label.TabIndex = 10;
            this.Wrong_Label.Text = "账号或密码错误！";
            this.Wrong_Label.Visible = false;
            // 
            // picwarn
            // 
            this.picwarn.BackColor = System.Drawing.Color.Transparent;
            this.picwarn.Image = global::Admin.Properties.Resources.warn;
            this.picwarn.Location = new System.Drawing.Point(393, 240);
            this.picwarn.Name = "picwarn";
            this.picwarn.Size = new System.Drawing.Size(16, 16);
            this.picwarn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picwarn.TabIndex = 9;
            this.picwarn.TabStop = false;
            this.picwarn.Visible = false;
            // 
            // Null_Label
            // 
            this.Null_Label.AutoSize = true;
            this.Null_Label.BackColor = System.Drawing.Color.Transparent;
            this.Null_Label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Null_Label.ForeColor = System.Drawing.Color.Red;
            this.Null_Label.Location = new System.Drawing.Point(413, 242);
            this.Null_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Null_Label.Name = "Null_Label";
            this.Null_Label.Size = new System.Drawing.Size(157, 15);
            this.Null_Label.TabIndex = 8;
            this.Null_Label.Text = "账号或密码不能为空！";
            this.Null_Label.Visible = false;
            // 
            // cel_btn
            // 
            this.cel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cel_btn.FlatAppearance.BorderSize = 0;
            this.cel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cel_btn.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cel_btn.ForeColor = System.Drawing.Color.White;
            this.cel_btn.Location = new System.Drawing.Point(396, 199);
            this.cel_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cel_btn.Name = "cel_btn";
            this.cel_btn.Size = new System.Drawing.Size(212, 31);
            this.cel_btn.TabIndex = 7;
            this.cel_btn.Text = "取  消";
            this.cel_btn.UseVisualStyleBackColor = false;
            this.cel_btn.Visible = false;
            this.cel_btn.Click += new System.EventHandler(this.cel_btn_Click);
            // 
            // is_auto
            // 
            this.is_auto.AutoSize = true;
            this.is_auto.BackColor = System.Drawing.Color.Transparent;
            this.is_auto.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.is_auto.ForeColor = System.Drawing.Color.White;
            this.is_auto.Location = new System.Drawing.Point(540, 177);
            this.is_auto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.is_auto.Name = "is_auto";
            this.is_auto.Size = new System.Drawing.Size(85, 18);
            this.is_auto.TabIndex = 6;
            this.is_auto.Text = "自动登录";
            this.is_auto.UseVisualStyleBackColor = false;
            this.is_auto.CheckedChanged += new System.EventHandler(this.is_auto_CheckedChanged);
            // 
            // rem_pwd
            // 
            this.rem_pwd.AutoSize = true;
            this.rem_pwd.BackColor = System.Drawing.Color.Transparent;
            this.rem_pwd.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rem_pwd.ForeColor = System.Drawing.Color.White;
            this.rem_pwd.Location = new System.Drawing.Point(395, 177);
            this.rem_pwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rem_pwd.Name = "rem_pwd";
            this.rem_pwd.Size = new System.Drawing.Size(85, 18);
            this.rem_pwd.TabIndex = 5;
            this.rem_pwd.Text = "记住密码";
            this.rem_pwd.UseVisualStyleBackColor = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("华文中宋", 12F);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(395, 199);
            this.login_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(212, 31);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "登   录";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(392, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(394, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "账号：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.txt_pwd.Location = new System.Drawing.Point(395, 138);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(10, 5, 2, 3);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(213, 34);
            this.txt_pwd.TabIndex = 1;
            this.txt_pwd.TextChanged += new System.EventHandler(this.txt_pwd_TextChanged);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_id.FormattingEnabled = true;
            this.txt_id.Location = new System.Drawing.Point(395, 78);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(213, 35);
            this.txt_id.TabIndex = 0;
            this.txt_id.SelectedIndexChanged += new System.EventHandler(this.txt_id_SelectedIndexChanged);
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(633, 336);
            this.Controls.Add(this.bottom_pel);
            this.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人事工资管理系统";
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.bottom_pel.ResumeLayout(false);
            this.bottom_pel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picwarn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottom_pel;
        private System.Windows.Forms.Button cel_btn;
        private System.Windows.Forms.CheckBox is_auto;
        private System.Windows.Forms.CheckBox rem_pwd;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.ComboBox txt_id;
        private System.Windows.Forms.PictureBox picwarn;
        private System.Windows.Forms.Label Null_Label;
        private System.Windows.Forms.Label Wrong_Label;
    }
}

