namespace oth_win_control
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_winname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_left = new System.Windows.Forms.TextBox();
            this.tb_top = new System.Windows.Forms.TextBox();
            this.tb_right = new System.Windows.Forms.TextBox();
            this.tb_bottom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_winname
            // 
            this.tb_winname.Location = new System.Drawing.Point(22, 24);
            this.tb_winname.Name = "tb_winname";
            this.tb_winname.Size = new System.Drawing.Size(211, 21);
            this.tb_winname.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "移动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_left
            // 
            this.tb_left.Location = new System.Drawing.Point(22, 62);
            this.tb_left.Name = "tb_left";
            this.tb_left.Size = new System.Drawing.Size(66, 21);
            this.tb_left.TabIndex = 2;
            // 
            // tb_top
            // 
            this.tb_top.Location = new System.Drawing.Point(104, 62);
            this.tb_top.Name = "tb_top";
            this.tb_top.Size = new System.Drawing.Size(66, 21);
            this.tb_top.TabIndex = 3;
            // 
            // tb_right
            // 
            this.tb_right.Location = new System.Drawing.Point(185, 62);
            this.tb_right.Name = "tb_right";
            this.tb_right.Size = new System.Drawing.Size(66, 21);
            this.tb_right.TabIndex = 4;
            // 
            // tb_bottom
            // 
            this.tb_bottom.Location = new System.Drawing.Point(266, 62);
            this.tb_bottom.Name = "tb_bottom";
            this.tb_bottom.Size = new System.Drawing.Size(66, 21);
            this.tb_bottom.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 95);
            this.Controls.Add(this.tb_bottom);
            this.Controls.Add(this.tb_right);
            this.Controls.Add(this.tb_top);
            this.Controls.Add(this.tb_left);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_winname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_winname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_left;
        private System.Windows.Forms.TextBox tb_top;
        private System.Windows.Forms.TextBox tb_right;
        private System.Windows.Forms.TextBox tb_bottom;
    }
}

