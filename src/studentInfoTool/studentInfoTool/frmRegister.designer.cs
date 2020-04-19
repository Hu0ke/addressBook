namespace studentInfoTool
{
    partial class frmRegister
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
            this.user_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.pass_tb2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用 户 名";
            // 
            // user_tb
            // 
            this.user_tb.Location = new System.Drawing.Point(83, 80);
            this.user_tb.MaxLength = 16;
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(130, 21);
            this.user_tb.TabIndex = 1;
            this.user_tb.TextChanged += new System.EventHandler(this.user_tb_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "注 册(&R)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pass_tb
            // 
            this.pass_tb.Location = new System.Drawing.Point(83, 131);
            this.pass_tb.MaxLength = 32;
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(130, 21);
            this.pass_tb.TabIndex = 3;
            this.pass_tb.TextChanged += new System.EventHandler(this.pass_tb_TextChanged);
            // 
            // pass_tb2
            // 
            this.pass_tb2.Location = new System.Drawing.Point(83, 183);
            this.pass_tb2.MaxLength = 32;
            this.pass_tb2.Name = "pass_tb2";
            this.pass_tb2.Size = new System.Drawing.Size(130, 21);
            this.pass_tb2.TabIndex = 4;
            this.pass_tb2.TextChanged += new System.EventHandler(this.pass_tb2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "密    码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(268, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass_tb2);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.register_FormClosed);
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.TextBox pass_tb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}