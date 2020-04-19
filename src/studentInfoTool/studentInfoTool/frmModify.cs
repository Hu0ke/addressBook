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
    public partial class frmModify : Form
    {
        SqlData tools = new SqlData();


        public frmModify()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//更改密码功能
        {
            if (u_tb.Text.Trim() != "" && old_pass.Text.Trim() != "" && new_pass.Text.Trim() != "")
            {
                pdModify();
            }
            else
            {
                MessageBox.Show("输入不能为空!");
            }
        }

        private void update_FormClosing(object sender, FormClosingEventArgs e)//关闭当前窗体，退回登陆界面
        {
            frmLogin  f = new frmLogin ();
            f.Show();
        }

        public void pdModify()
        {
            string user = u_tb.Text.Trim();
            string oldpass = old_pass.Text.Trim();
            string newpass = new_pass.Text.Trim();

            string lookintoUser = "select * from contractUser where userName='" + user + "'";
            string lookintoPass = "select * from contractUser where userName='" + user + "' and userPd = '" + oldpass + "'";

            DataSet lkuser= tools.ExceDS(lookintoUser);
            DataSet lkpass = tools.ExceDS(lookintoPass);

                if (lkuser.Tables[0].Rows.Count <= 0)//验证用户名是否存在
                {
                    MessageBox.Show("您输入的账户有误，请输入正确的账户", "账号错误");
                }
                else if (lkpass.Tables[0].Rows.Count <= 0)//验证密码是否正确
                {
                    MessageBox.Show("您输入的密码有误，请核对后重新输入密码", "密码错误");
                    old_pass.Clear();
                }
                else if (oldpass == newpass)//验证新旧密码不能相同
                {
                    MessageBox.Show("新密码不能与旧密码相同", "密码错误");
                    new_pass.Clear();
                    new_pass2.Clear();
                }
                else if (new_pass.Text.Trim() != new_pass2.Text.Trim())//验证重复密码与新密码相同
                {
                    MessageBox.Show("重复密码与新密码不相同，请重新输入", "新密码出错");
                }
                else//修改密码功能
                {
                    string revisePass = "update contractUser set userPd ='" + newpass + "' where userName='" + user + "'";
                    tools.ExecuteNonQuery(revisePass);
                    MessageBox.Show("恭喜你，密码更改成功\n正在跳转前往登录界面。。。。", "更改成功");
                    frmLogin f = new frmLogin();
                    f.Show();
                    this.Close();
                }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            u_tb.Clear();
            old_pass.Clear();
            new_pass.Clear();
            new_pass2.Clear();
        }

        private void frmModify_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("..\\..\\pic\\tubiao.ico");
            Random rd = new Random();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile("..\\..\\pic\\beijing" + rd.Next(0, 2).ToString().Trim() + ".jpg");
        }
    }
}