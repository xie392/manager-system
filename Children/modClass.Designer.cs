namespace Admin.Children
{
    partial class modClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modClass));
            this.cel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.num_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dep_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cel_btn
            // 
            this.cel_btn.Location = new System.Drawing.Point(56, 246);
            this.cel_btn.Name = "cel_btn";
            this.cel_btn.Size = new System.Drawing.Size(158, 30);
            this.cel_btn.TabIndex = 19;
            this.cel_btn.Text = "取消";
            this.cel_btn.UseVisualStyleBackColor = true;
            this.cel_btn.Click += new System.EventHandler(this.cel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(337, 246);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(158, 30);
            this.save_btn.TabIndex = 18;
            this.save_btn.Text = "保存";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "部门人数：";
            // 
            // num_txt
            // 
            this.num_txt.Location = new System.Drawing.Point(164, 187);
            this.num_txt.Margin = new System.Windows.Forms.Padding(4);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(331, 32);
            this.num_txt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "部门经理：";
            // 
            // box_txt
            // 
            this.box_txt.Location = new System.Drawing.Point(164, 133);
            this.box_txt.Margin = new System.Windows.Forms.Padding(4);
            this.box_txt.Name = "box_txt";
            this.box_txt.Size = new System.Drawing.Size(331, 32);
            this.box_txt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "部门名称：";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(164, 78);
            this.name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(331, 32);
            this.name_txt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "部门编号：";
            // 
            // Dep_txt
            // 
            this.Dep_txt.Enabled = false;
            this.Dep_txt.Location = new System.Drawing.Point(164, 23);
            this.Dep_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Dep_txt.Name = "Dep_txt";
            this.Dep_txt.ReadOnly = true;
            this.Dep_txt.Size = new System.Drawing.Size(331, 32);
            this.Dep_txt.TabIndex = 10;
            // 
            // modClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 305);
            this.Controls.Add(this.cel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dep_txt);
            this.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改部门";
            this.Load += new System.EventHandler(this.modClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dep_txt;
    }
}