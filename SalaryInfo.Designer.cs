namespace Admin
{
    partial class SalaryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryInfo));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LengthMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EverydayMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubsidyMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SocialMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Name,
            this.Year,
            this.Month,
            this.Basic,
            this.Worktime,
            this.LengthMoney,
            this.OtherMoney,
            this.Workday,
            this.EverydayMoney,
            this.SubsidyMoney,
            this.HouseMoney,
            this.TaxMoney,
            this.SocialMoney,
            this.Salary,
            this.state});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView.Location = new System.Drawing.Point(0, 179);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(872, 386);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "员工编号";
            this.UserId.Name = "UserId";
            this.UserId.Width = 50;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "员工姓名";
            this.Name.Name = "Name";
            this.Name.Width = 50;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "工资年份";
            this.Year.Name = "Year";
            this.Year.Width = 50;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "工资月份";
            this.Month.Name = "Month";
            this.Month.Width = 50;
            // 
            // Basic
            // 
            this.Basic.DataPropertyName = "Basic";
            this.Basic.HeaderText = "基本工资";
            this.Basic.Name = "Basic";
            this.Basic.Width = 50;
            // 
            // Worktime
            // 
            this.Worktime.DataPropertyName = "Worktime";
            this.Worktime.HeaderText = "加班工资";
            this.Worktime.Name = "Worktime";
            this.Worktime.Width = 50;
            // 
            // LengthMoney
            // 
            this.LengthMoney.DataPropertyName = "LengthMoney";
            this.LengthMoney.HeaderText = "工龄工资";
            this.LengthMoney.Name = "LengthMoney";
            this.LengthMoney.Width = 50;
            // 
            // OtherMoney
            // 
            this.OtherMoney.DataPropertyName = "OtherMoney";
            this.OtherMoney.HeaderText = "其它薪金";
            this.OtherMoney.Name = "OtherMoney";
            this.OtherMoney.Width = 50;
            // 
            // Workday
            // 
            this.Workday.DataPropertyName = "Workday";
            this.Workday.HeaderText = "出勤天数";
            this.Workday.Name = "Workday";
            this.Workday.Width = 50;
            // 
            // EverydayMoney
            // 
            this.EverydayMoney.DataPropertyName = "EverydayMoney";
            this.EverydayMoney.HeaderText = "全勤奖";
            this.EverydayMoney.Name = "EverydayMoney";
            this.EverydayMoney.Width = 50;
            // 
            // SubsidyMoney
            // 
            this.SubsidyMoney.DataPropertyName = "SubsidyMoney";
            this.SubsidyMoney.HeaderText = "岗位补贴";
            this.SubsidyMoney.Name = "SubsidyMoney";
            this.SubsidyMoney.Width = 50;
            // 
            // HouseMoney
            // 
            this.HouseMoney.DataPropertyName = "HouseMoney";
            this.HouseMoney.HeaderText = "住房公积金";
            this.HouseMoney.Name = "HouseMoney";
            this.HouseMoney.Width = 50;
            // 
            // TaxMoney
            // 
            this.TaxMoney.DataPropertyName = "TaxMoney";
            this.TaxMoney.HeaderText = "个人所得税";
            this.TaxMoney.Name = "TaxMoney";
            this.TaxMoney.Width = 50;
            // 
            // SocialMoney
            // 
            this.SocialMoney.DataPropertyName = "SocialMoney";
            this.SocialMoney.HeaderText = "社保";
            this.SocialMoney.Name = "SocialMoney";
            this.SocialMoney.Width = 50;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "实发工资";
            this.Salary.Name = "Salary";
            this.Salary.Width = 50;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "发放状态";
            this.state.Name = "state";
            this.state.Width = 50;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Teal;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(74, 42);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(186, 48);
            this.add_btn.TabIndex = 15;
            this.add_btn.Text = "发放";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Teal;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(322, 42);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(186, 48);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "返回";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(757, 87);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(145, 32);
            this.txtId.TabIndex = 19;
            this.txtId.Visible = false;
            // 
            // SalaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Admin.Properties.Resources.ku;
            this.ClientSize = new System.Drawing.Size(872, 565);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.back_btn);
            this.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工资管理";
            this.Load += new System.EventHandler(this.SalaryInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worktime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LengthMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workday;
        private System.Windows.Forms.DataGridViewTextBoxColumn EverydayMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubsidyMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocialMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}