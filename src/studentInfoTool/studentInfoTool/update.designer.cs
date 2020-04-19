namespace studentInfoTool
{
    partial class update
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.u_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.old_pass = new System.Windows.Forms.TextBox();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.new_pass2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "修改密码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // u_tb
            // 
            this.u_tb.Location = new System.Drawing.Point(106, 52);
            this.u_tb.Name = "u_tb";
            this.u_tb.Size = new System.Drawing.Size(131, 21);
            this.u_tb.TabIndex = 2;
            this.u_tb.TextChanged += new System.EventHandler(this.u_tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "旧密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "新密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(37, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "确认密码";
            // 
            // old_pass
            // 
            this.old_pass.Location = new System.Drawing.Point(106, 88);
            this.old_pass.Name = "old_pass";
            this.old_pass.Size = new System.Drawing.Size(131, 21);
            this.old_pass.TabIndex = 6;
            this.old_pass.TextChanged += new System.EventHandler(this.old_pass_TextChanged);
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(106, 124);
            this.new_pass.Name = "new_pass";
            this.new_pass.PasswordChar = '*';
            this.new_pass.Size = new System.Drawing.Size(131, 21);
            this.new_pass.TabIndex = 7;
            this.new_pass.TextChanged += new System.EventHandler(this.new_pass_TextChanged);
            // 
            // new_pass2
            // 
            this.new_pass2.Location = new System.Drawing.Point(106, 160);
            this.new_pass2.Name = "new_pass2";
            this.new_pass2.PasswordChar = '*';
            this.new_pass2.Size = new System.Drawing.Size(131, 21);
            this.new_pass2.TabIndex = 8;
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 309);
            this.Controls.Add(this.new_pass2);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.old_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.u_tb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "update";
            this.Text = "修改密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.update_FormClosing);
            this.Load += new System.EventHandler(this.update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox u_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox old_pass;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.TextBox new_pass2;
    }
}