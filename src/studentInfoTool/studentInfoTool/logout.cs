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
    public partial class logout : Form
    {
        SqlData tools = new SqlData();

        public logout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = user_tb.Text.Trim();
            string pass = pass_tb.Text.Trim();
            string lookinto = "select * from contractUser where userName='"+ user +"' and userMiMa = '"+ pass +"'";
            DataSet lkinto = tools.ExceDS(lookinto);
            if (lkinto.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("您的账号或密码有误，请查验后在试", "错误");
            }
            else
            {
                DialogResult TorF = MessageBox.Show("您真的要注销账户吗？？？(注销账户后，一切资料将丢失)", "请确认", MessageBoxButtons.OKCancel);
                    if(TorF ==DialogResult .OK   )
                    {
                        string del = "delete from contractUser where userName='"+user +"' and userMiMa = '"+pass +"'";
                        tools.ExecuteNonQuery(del ) ;
                        MessageBox.Show("您的账号已注销", "注销成功");
                    }
            }
        }

        private void logout_FormClosed(object sender, FormClosedEventArgs e)//关闭当前窗体返回登陆界面
        {
            frmLogin f = new frmLogin();
            f.Show();
        }


    }
}