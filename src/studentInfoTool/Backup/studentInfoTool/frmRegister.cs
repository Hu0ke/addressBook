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
    public partial class frmRegister : Form
    {
        SqlData tools = new SqlData();
        string username;
        string password1;
        string password2;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                username = user_tb.Text.Trim();
                string cha = "select * from contractUser where userName='" + username + "'";
                DataSet ds = tools.ExceDS(cha);
                if (user_tb.Text.Length <= 0 || pass_tb.Text.Length <= 0 || pass_tb2.Text.Length <= 0)//检查用户名密码是否为空
                {
                    MessageBox.Show("用户名或密码不可为空，请重新输入", "用户名密码不可为空");
                }
                else if (user_tb.Text.Length < 6 || pass_tb.Text.Length < 6 || pass_tb2.Text.Length < 6)
                {
                    MessageBox.Show("用户名密码需要大于六个字符，请重新输入用户名密码", "注册错误");//检查用户名密码是否小于六个字符
                }
                else if (ds.Tables[0].Rows.Count > 0)//验证用户名是否重复
                {
                    MessageBox.Show("用户名已被注册，请更改用户名", "注册失败", MessageBoxButtons.OK);
                }
                else if (password1 != password2)//验证重复密码和密码是否相同
                {
                    MessageBox.Show("两次密码不相同，请重新输入密码", "注册失败", MessageBoxButtons.OK);
                    pass_tb.Clear();
                    pass_tb2.Clear();
                }
                else//向数据库添加数据，即注册功能
                {
                    string zc = "insert into contractUser (userName,userPd) values ('" + username + "','" + password1 + "')";
                    tools.ExecuteNonQuery(zc);
                    MessageBox.Show("恭喜你注册账号成功\n正在进行跳转，请稍后。。。。");
                    this.Hide();
                    frmLogin  f = new frmLogin ();
                    f.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("系统错误，请稍后再试", "系统错误");
            }
            finally 
            {
                
            }

        }//注册功能

        private void user_tb_TextChanged(object sender, EventArgs e)//更新用户名文本框
        {
             username = user_tb.Text.Trim();
        }

        private void pass_tb_TextChanged(object sender, EventArgs e)//更新密码文本框
        {

            password1 = pass_tb.Text.Trim();

        }

        private void pass_tb2_TextChanged(object sender, EventArgs e)//更新确认密码文本框
        {

            password2 = pass_tb2.Text.Trim();
        }


        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            frmLogin  f = new frmLogin ();
            f.Show(); 
        }

        private void register_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("..\\..\\pic\\tubiao.ico");
            Random rd = new Random();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile("..\\..\\pic\\beijing" + rd.Next(0, 2).ToString().Trim() + ".jpg");
        }

    }
}