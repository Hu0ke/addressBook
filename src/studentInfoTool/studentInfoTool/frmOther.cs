using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace studentInfoTool
{
    public partial class frmOther : Form
    {
        public frmOther(string str)
        {
            InitializeComponent();
            this.Text = str;
        }

        private void frmOther_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("..\\..\\pic\\tubiao.ico");
            Random rd = new Random();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile("..\\..\\pic\\beijing" + rd.Next(0, 2).ToString().Trim() + ".jpg");
            if (this .Text =="关于 ZIME通讯录系统")
            {
                txtInfo.Text = "ZIME 通讯录管理系统 2017\r\n版本\n© 2017 407神奇寝室 \r\n保留所有权利 \r\n\r\n" +
                    "警告：本计算机程序受版权法和国际条约保护。如未经授权而擅自复制或传播本程序(或其中任何部分)，" +
                    "将受到严厉的民事和刑事制裁，并将在法律许可的最大限度内受到起诉。";
            }
            else if (this .Text =="使用帮助")
            {
                txtInfo.Text = "ZIME 通讯录管理系统 2017\r\n版本\n© 2017 407神奇寝室 \r\n保留所有权利 \r\n\r\n" +
                    "警告：本计算机程序受版权法和国际条约保护。如未经授权而擅自复制或传播本程序(或其中任何部分)，" +
                    "将受到严厉的民事和刑事制裁，并将在法律许可的最大限度内受到起诉。";
            }
            else if (this .Text == "隐私条例")
            {
                txtInfo.Text = "» 更改个人资料、密码保护\r\n"+

                    "会员可以随时登录本网站对会员的个人资料作出查看或修改。为保护会员数据的隐私，会员将需要输入会员号码及个人密码，以获取或更改会员的个人资料。会员需留意，任何以会员的登记名称及密码登录本网站，本网站均视为由该会员所发出。会员有责任妥善保管帐号及密码。如会员发现或怀疑会员的登记名称及密码被误用，会员有责任通知本网站。如本网站发现或怀疑会员的登记名称及密码被误用，本网站亦有权终止会员的服务。 \r\n"+

                    "» 隐私政策的修改\r\n" + "本网站可在必要时随时对保护隐私及数据安全政策声明作出修改，并将新的声明公布于本网站中，以便会员能随时知悉我们如何利用有关数据。如本网站决定于新的条款下使用会员已提供的数据，本网站将提前通知会员，会员可选择是否接受本网站调整后的政策并允许本网站根据调整后的政策使用会员的数据。若在本网站向会员送达通知时所要求的合理时间内，会员未明确表示反对的，则视为会员接受调整后的政策。";
            }
            else if (this.Text == "用户反馈")
            {
                txtInfo.ReadOnly = false;
                txtInfo.Text = "";
            }
            else
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}