namespace studentInfoTool
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnSearch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账户CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切换用户CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.不显示默认ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.如何使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本产品ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.关于我们AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户反馈RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们AToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.关于我们AToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtQQ = new System.Windows.Forms.TextBox();
            this.txtShortM = new System.Windows.Forms.TextBox();
            this.txtWeiXin = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询记录(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(873, 482);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加记录(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(7, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 33);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "更新记录(&U)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除记录(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(7, 20);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(116, 33);
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "显示所有记录(&R)";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账户CToolStripMenuItem,
            this.背景显示ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.工具ToolStripMenuItem.Text = "管理(&M)";
            // 
            // 账户CToolStripMenuItem
            // 
            this.账户CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码MToolStripMenuItem,
            this.切换用户CToolStripMenuItem});
            this.账户CToolStripMenuItem.Name = "账户CToolStripMenuItem";
            this.账户CToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.账户CToolStripMenuItem.Text = "账户(&C)";
            // 
            // 修改密码MToolStripMenuItem
            // 
            this.修改密码MToolStripMenuItem.Name = "修改密码MToolStripMenuItem";
            this.修改密码MToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.修改密码MToolStripMenuItem.Text = "修改密码(&M)";
            this.修改密码MToolStripMenuItem.Click += new System.EventHandler(this.修改密码MToolStripMenuItem_Click);
            // 
            // 切换用户CToolStripMenuItem
            // 
            this.切换用户CToolStripMenuItem.Name = "切换用户CToolStripMenuItem";
            this.切换用户CToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.切换用户CToolStripMenuItem.Text = "切换用户(&C)";
            this.切换用户CToolStripMenuItem.Click += new System.EventHandler(this.切换用户CToolStripMenuItem_Click);
            // 
            // 背景显示ToolStripMenuItem
            // 
            this.背景显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.不显示默认ToolStripMenuItem});
            this.背景显示ToolStripMenuItem.Name = "背景显示ToolStripMenuItem";
            this.背景显示ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.背景显示ToolStripMenuItem.Text = "背景显示(&S)";
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 不显示默认ToolStripMenuItem
            // 
            this.不显示默认ToolStripMenuItem.Name = "不显示默认ToolStripMenuItem";
            this.不显示默认ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.不显示默认ToolStripMenuItem.Text = "不显示(默认)";
            this.不显示默认ToolStripMenuItem.Click += new System.EventHandler(this.不显示默认ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.如何使用ToolStripMenuItem,
            this.关于本产品ToolStripMenuItem,
            this.关于我们AToolStripMenuItem,
            this.用户反馈RToolStripMenuItem,
            this.关于我们AToolStripMenuItem2,
            this.关于我们AToolStripMenuItem3});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 如何使用ToolStripMenuItem
            // 
            this.如何使用ToolStripMenuItem.Name = "如何使用ToolStripMenuItem";
            this.如何使用ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.如何使用ToolStripMenuItem.Text = "如何使用(&U)";
            this.如何使用ToolStripMenuItem.Click += new System.EventHandler(this.如何使用ToolStripMenuItem_Click);
            // 
            // 关于本产品ToolStripMenuItem
            // 
            this.关于本产品ToolStripMenuItem.Name = "关于本产品ToolStripMenuItem";
            this.关于本产品ToolStripMenuItem.Size = new System.Drawing.Size(133, 6);
            // 
            // 关于我们AToolStripMenuItem
            // 
            this.关于我们AToolStripMenuItem.Name = "关于我们AToolStripMenuItem";
            this.关于我们AToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关于我们AToolStripMenuItem.Text = "隐私条例(&P)";
            this.关于我们AToolStripMenuItem.Click += new System.EventHandler(this.关于我们AToolStripMenuItem_Click);
            // 
            // 用户反馈RToolStripMenuItem
            // 
            this.用户反馈RToolStripMenuItem.Name = "用户反馈RToolStripMenuItem";
            this.用户反馈RToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.用户反馈RToolStripMenuItem.Text = "用户反馈(&R)";
            this.用户反馈RToolStripMenuItem.Click += new System.EventHandler(this.用户反馈RToolStripMenuItem_Click);
            // 
            // 关于我们AToolStripMenuItem2
            // 
            this.关于我们AToolStripMenuItem2.Name = "关于我们AToolStripMenuItem2";
            this.关于我们AToolStripMenuItem2.Size = new System.Drawing.Size(133, 6);
            // 
            // 关于我们AToolStripMenuItem3
            // 
            this.关于我们AToolStripMenuItem3.Name = "关于我们AToolStripMenuItem3";
            this.关于我们AToolStripMenuItem3.Size = new System.Drawing.Size(136, 22);
            this.关于我们AToolStripMenuItem3.Text = "关于我们(&A)";
            this.关于我们AToolStripMenuItem3.Click += new System.EventHandler(this.关于我们AToolStripMenuItem3_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 19);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(79, 21);
            this.txtName.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnShowAll);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(891, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 491);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 452);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 33);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "清空文本(&C)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(110, 67);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(79, 20);
            this.cmbYear.TabIndex = 18;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(195, 68);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(52, 20);
            this.cmbMonth.TabIndex = 19;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(253, 67);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(52, 20);
            this.cmbDay.TabIndex = 20;
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(254, 20);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(52, 20);
            this.cmbSex.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSex);
            this.groupBox1.Controls.Add(this.cmbDay);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 105);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "*出生年月:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(195, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "*性别:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "*姓名:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtQQ);
            this.groupBox3.Controls.Add(this.txtShortM);
            this.groupBox3.Controls.Add(this.txtWeiXin);
            this.groupBox3.Controls.Add(this.txtTel);
            this.groupBox3.Controls.Add(this.txtMobile);
            this.groupBox3.Location = new System.Drawing.Point(352, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 105);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(169, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "邮箱:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(169, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "微信:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(169, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Q  Q:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "短号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "座机:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "手机:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(223, 69);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 21);
            this.txtEmail.TabIndex = 42;
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(223, 20);
            this.txtQQ.MaxLength = 13;
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(100, 21);
            this.txtQQ.TabIndex = 40;
            // 
            // txtShortM
            // 
            this.txtShortM.Location = new System.Drawing.Point(61, 68);
            this.txtShortM.MaxLength = 6;
            this.txtShortM.Name = "txtShortM";
            this.txtShortM.Size = new System.Drawing.Size(99, 21);
            this.txtShortM.TabIndex = 39;
            // 
            // txtWeiXin
            // 
            this.txtWeiXin.Location = new System.Drawing.Point(223, 44);
            this.txtWeiXin.MaxLength = 19;
            this.txtWeiXin.Name = "txtWeiXin";
            this.txtWeiXin.Size = new System.Drawing.Size(100, 21);
            this.txtWeiXin.TabIndex = 41;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(61, 44);
            this.txtTel.MaxLength = 13;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(99, 21);
            this.txtTel.TabIndex = 38;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(61, 20);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(99, 21);
            this.txtMobile.TabIndex = 37;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cmbCity);
            this.groupBox4.Controls.Add(this.cmbProvince);
            this.groupBox4.Controls.Add(this.cmbDistrict);
            this.groupBox4.Controls.Add(this.txtDetail);
            this.groupBox4.Location = new System.Drawing.Point(693, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 105);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(17, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 32);
            this.label12.TabIndex = 49;
            this.label12.Text = "详细\r\n地址";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("楷体_GB2312", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "省市区:";
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(157, 18);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(79, 20);
            this.cmbCity.TabIndex = 35;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged_1);
            // 
            // cmbProvince
            // 
            this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(72, 18);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(79, 20);
            this.cmbProvince.TabIndex = 34;
            this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged_1);
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(242, 18);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(79, 20);
            this.cmbDistrict.TabIndex = 36;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(72, 42);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(249, 47);
            this.txtDetail.TabIndex = 37;
            // 
            // 账户ToolStripMenuItem
            // 
            this.账户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem});
            this.账户ToolStripMenuItem.Name = "账户ToolStripMenuItem";
            this.账户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.账户ToolStripMenuItem.Text = "账户(&A)";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码(&M)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 627);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtQQ;
        private System.Windows.Forms.TextBox txtShortM;
        private System.Windows.Forms.TextBox txtWeiXin;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 如何使用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 关于本产品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户反馈RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 关于我们AToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 关于我们AToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账户CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切换用户CToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem 背景显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 不显示默认ToolStripMenuItem;
    }
}