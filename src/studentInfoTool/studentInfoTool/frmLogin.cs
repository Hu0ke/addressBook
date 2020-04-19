using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentInfoTool
{
    public partial class frmLogin : Form
    {
        SqlData tools = new SqlData();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)//当鼠标在label3停留时，更改字体样式
        {      
            Font f = new Font("宋体", 9, FontStyle.Underline);
            label3.Font = f;
            label3.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)//当鼠标离开label3时，回复原来样式
        {   
            Font f = new Font("宋体", 9, FontStyle.Regular);
            label3.Font = f;
            label3.ForeColor = Color.Black ;
        }

        private void label3_Click(object sender, EventArgs e)//单击注册文本时，跳出注册界面
        {
            frmRegister reg = new frmRegister();
            reg.Show();
            this.Hide();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)//退出窗体时，防止误操作，弹出确认窗体(有问题未解决)
        {
            DialogResult r = MessageBox.Show("您是否要退出通讯录系统？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            Font f = new Font("宋体", 9, FontStyle.Underline);
            label4.Font = f;
            label4.ForeColor = Color.Blue;
        }//当鼠标经过label4时，字体变成蓝色加下划线

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Font f = new Font("宋体", 9, FontStyle.Regular);
            label4.Font = f;
            label4.ForeColor = Color.Black;
        }//当鼠标离开label4时，字体恢复

        private void label4_Click(object sender, EventArgs e)//单击注销账号，弹出注销账号窗体
        {
            frmLogout f = new frmLogout();
            f.Show();
            this.Hide();
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)//当鼠标在label5停留时，更改字体样式
        {
            Font f = new Font("宋体", 9, FontStyle.Underline);
            label5.Font = f;
            label5.ForeColor = Color.Blue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)//当鼠标离开label5时，恢复字体
        {
            Font f = new Font("宋体", 9, FontStyle.Regular);
            label5.Font = f;
            label5.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmModify f = new frmModify();
            f.Show();
            this.Hide();
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            txtUserPd.PasswordChar = '\0';
        }

        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            txtUserPd.PasswordChar = Convert.ToChar("*");
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("..\\..\\pic\\tubiao.ico");
            Random rd= new Random ();
            this.BackgroundImageLayout = ImageLayout .Stretch;
            this.BackgroundImage = Image.FromFile("..\\..\\pic\\beijing" + rd.Next(0, 2).ToString().Trim() + ".jpg");
            pictureBox1.Load("..\\..\\pic\\touxiang" + rd.Next(0, 2).ToString().Trim() + ".jpg");
            txtUserName.Focus();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (login(txtUserName, txtUserPd))
            {
                frmMain fm= new frmMain(txtUserName.Text.Trim().ToString());
                this.Hide();   
                fm.Show();
                MessageBox.Show("\n用户【" + txtUserName.Text.Trim().ToString() + "】登录成功!\n", "登录成功");
            }
        }

        private Boolean login(TextBox txtUserName, TextBox txtUserPd)
        {

            if (!txtCheck("login"))
            {
                MessageBox.Show("账号或密码不得为空，请输入账号密码", "登录错误"); ; return false;
            }
            else
            {
                string user = txtUserName.Text.Trim();
                string Password = txtUserPd.Text.Trim();
                string yz = "select * from contractUser where userName='" + user + "' and userPd='" + Password + "'";

                DataSet sd = tools.ExceDS(yz);
                if (sd.Tables[0].Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("您的用户名或密码错误，请输入正确的账号密码", "验证错误", MessageBoxButtons.OK);
                    txtUserPd.Clear();
                    return false;
                }
            }
        }//登录验证功能

        public Boolean txtCheck(string cmd)
        {
            if (cmd == "login")
            {
                if (txtUserName.Text.Trim().Length > 6 || txtUserPd.Text.Trim().Length > 6) return true; else return false;
            }
            else if (cmd == "modify")
            {
                return false;
            }
            else
                return false;
        }//geshi验证功能

    }
}