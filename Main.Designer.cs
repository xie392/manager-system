namespace Admin
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Class_btn = new System.Windows.Forms.Button();
            this.Salary_btn = new System.Windows.Forms.Button();
            this.Pwd_btn = new System.Windows.Forms.Button();
            this.Employ_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Class_btn
            // 
            this.Class_btn.BackgroundImage = global::Admin.Properties.Resources._213;
            this.Class_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Class_btn.FlatAppearance.BorderSize = 0;
            this.Class_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Class_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Class_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class_btn.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.Class_btn.ForeColor = System.Drawing.Color.White;
            this.Class_btn.Location = new System.Drawing.Point(71, 55);
            this.Class_btn.Name = "Class_btn";
            this.Class_btn.Size = new System.Drawing.Size(176, 70);
            this.Class_btn.TabIndex = 0;
            this.Class_btn.Text = "部门管理";
            this.Class_btn.UseVisualStyleBackColor = true;
            this.Class_btn.Click += new System.EventHandler(this.Class_btn_Click);
            // 
            // Salary_btn
            // 
            this.Salary_btn.BackgroundImage = global::Admin.Properties.Resources._213;
            this.Salary_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salary_btn.FlatAppearance.BorderSize = 0;
            this.Salary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Salary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Salary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salary_btn.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.Salary_btn.ForeColor = System.Drawing.Color.White;
            this.Salary_btn.Location = new System.Drawing.Point(71, 200);
            this.Salary_btn.Name = "Salary_btn";
            this.Salary_btn.Size = new System.Drawing.Size(176, 70);
            this.Salary_btn.TabIndex = 1;
            this.Salary_btn.Text = "工资管理";
            this.Salary_btn.UseVisualStyleBackColor = true;
            this.Salary_btn.Click += new System.EventHandler(this.Salary_btn_Click);
            // 
            // Pwd_btn
            // 
            this.Pwd_btn.BackgroundImage = global::Admin.Properties.Resources._213;
            this.Pwd_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pwd_btn.FlatAppearance.BorderSize = 0;
            this.Pwd_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Pwd_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Pwd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pwd_btn.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.Pwd_btn.ForeColor = System.Drawing.Color.White;
            this.Pwd_btn.Location = new System.Drawing.Point(321, 200);
            this.Pwd_btn.Name = "Pwd_btn";
            this.Pwd_btn.Size = new System.Drawing.Size(176, 70);
            this.Pwd_btn.TabIndex = 2;
            this.Pwd_btn.Text = "密码管理";
            this.Pwd_btn.UseVisualStyleBackColor = true;
            this.Pwd_btn.Click += new System.EventHandler(this.Pwd_btn_Click);
            // 
            // Employ_btn
            // 
            this.Employ_btn.BackgroundImage = global::Admin.Properties.Resources._213;
            this.Employ_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Employ_btn.FlatAppearance.BorderSize = 0;
            this.Employ_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Employ_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Employ_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employ_btn.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.Employ_btn.ForeColor = System.Drawing.Color.White;
            this.Employ_btn.Location = new System.Drawing.Point(321, 55);
            this.Employ_btn.Name = "Employ_btn";
            this.Employ_btn.Size = new System.Drawing.Size(176, 70);
            this.Employ_btn.TabIndex = 4;
            this.Employ_btn.Text = "员工管理";
            this.Employ_btn.UseVisualStyleBackColor = true;
            this.Employ_btn.Click += new System.EventHandler(this.Employ_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Admin.Properties.Resources.u;
            this.ClientSize = new System.Drawing.Size(567, 344);
            this.Controls.Add(this.Employ_btn);
            this.Controls.Add(this.Pwd_btn);
            this.Controls.Add(this.Salary_btn);
            this.Controls.Add(this.Class_btn);
            this.Font = new System.Drawing.Font("宋体", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人事工资管理系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Class_btn;
        private System.Windows.Forms.Button Salary_btn;
        private System.Windows.Forms.Button Pwd_btn;
        private System.Windows.Forms.Button Employ_btn;


    }
}