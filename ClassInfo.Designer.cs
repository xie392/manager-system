namespace Admin
{
    partial class ClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassInfo));
            this.back_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.mod_btn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassBoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Teal;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(609, 95);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(135, 33);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "返回";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Teal;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(70, 95);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(135, 33);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "添加";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Teal;
            this.del_btn.Enabled = false;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(249, 95);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(135, 33);
            this.del_btn.TabIndex = 2;
            this.del_btn.Text = "删除";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // mod_btn
            // 
            this.mod_btn.BackColor = System.Drawing.Color.Teal;
            this.mod_btn.Enabled = false;
            this.mod_btn.FlatAppearance.BorderSize = 0;
            this.mod_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.mod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mod_btn.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mod_btn.ForeColor = System.Drawing.Color.White;
            this.mod_btn.Location = new System.Drawing.Point(429, 95);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(135, 33);
            this.mod_btn.TabIndex = 3;
            this.mod_btn.Text = "修改";
            this.mod_btn.UseVisualStyleBackColor = false;
            this.mod_btn.Click += new System.EventHandler(this.mod_btn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassId,
            this.ClassName,
            this.ClassBoss,
            this.ClassNumber});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView.Location = new System.Drawing.Point(0, 161);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(817, 392);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "部门编号";
            this.ClassId.Name = "ClassId";
            this.ClassId.Width = 180;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "部门名称";
            this.ClassName.Name = "ClassName";
            this.ClassName.Width = 180;
            // 
            // ClassBoss
            // 
            this.ClassBoss.DataPropertyName = "ClassBoss";
            this.ClassBoss.HeaderText = "部门经理";
            this.ClassBoss.Name = "ClassBoss";
            this.ClassBoss.Width = 180;
            // 
            // ClassNumber
            // 
            this.ClassNumber.DataPropertyName = "ClassNumber";
            this.ClassNumber.HeaderText = "部门人数";
            this.ClassNumber.Name = "ClassNumber";
            this.ClassNumber.Width = 180;
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search_txt.ForeColor = System.Drawing.Color.Silver;
            this.search_txt.Location = new System.Drawing.Point(167, 27);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(458, 38);
            this.search_txt.TabIndex = 5;
            this.search_txt.Tag = "";
            this.search_txt.Text = "请输入部门名称";
            this.search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_txt.Click += new System.EventHandler(this.search_txt_Click);
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.White;
            this.search_btn.BackgroundImage = global::Admin.Properties.Resources.搜索__1;
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.ForeColor = System.Drawing.Color.Transparent;
            this.search_btn.Location = new System.Drawing.Point(623, 28);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(40, 30);
            this.search_btn.TabIndex = 6;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_id.ForeColor = System.Drawing.Color.Silver;
            this.txt_id.Location = new System.Drawing.Point(34, 28);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(84, 38);
            this.txt_id.TabIndex = 8;
            this.txt_id.Tag = "";
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.Visible = false;
            // 
            // ClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Admin.Properties.Resources.ku;
            this.ClientSize = new System.Drawing.Size(817, 553);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.mod_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.back_btn);
            this.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ClassInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.ClassInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button mod_btn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassBoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNumber;
        private System.Windows.Forms.TextBox txt_id;
    }
}