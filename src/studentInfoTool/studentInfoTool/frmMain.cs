using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

/*
 *
string sheng = ((DataRowView)cmbProvince.SelectedItem)["ProvinceName"].ToString();
string shi = ((DataRowView)cmbCity .SelectedItem)["CityName"].ToString();
string qu = ((DataRowView)cmbDistrict.SelectedItem)["DistrictName"].ToString();
 * 
 */

namespace studentInfoTool
{
    public partial class frmMain : Form
    {
        SqlData sqlda= new SqlData ();
        dataSet setda = new dataSet();
        DateTime t = DateTime.Now;
        frmOther fo = new frmOther("关于 ZIME通讯录系统");
        string userName1; 

        public frmMain(string userName)
        {
            InitializeComponent();
            this.Text = "欢迎你," + userName.ToString() + "!" +" --ZIME通讯录系统";
            userName1 = userName;
            Bind_DropDownList(cmbProvince, "select * from [S_Province] order by [ProvinceID] ASC", "ProvinceName", "ProvinceID");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            fo.Close(); fo.Dispose();
            this.Icon = new Icon("..\\..\\pic\\tubiao.ico");
            Random rd = new Random();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1 .BackColor =Color.FromArgb(rd.Next(64,256),rd .Next (64,256),rd.Next (64,256));//256RGB三色原光 强度越高 颜色越亮 255,255,255为白色

            Bin_dataGridView();
            cmbBirthAdd(1);
            txtclear();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cc = MessageBox.Show("您是否要退出通讯录系统？", "退出", MessageBoxButtons.OKCancel);
            if (cc == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
        //绑定数据视图
        public void Bin_dataGridView()
        {
            try
            {
                string sqlcmd = "select * from contractBaseInformation";
                DataSet ds = sqlda.ExceDS(sqlcmd);
                dataGridView1.DataSource = ds.Tables[0];
                changeHeader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常,请稍后尝试!");
            }
            finally
            {

            }
        }

        public void changeHeader()
        {
            dataGridView1.Columns[0].HeaderText = "序号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "出生日期";
            dataGridView1.Columns[4].HeaderText = "手机";
            dataGridView1.Columns[5].HeaderText = "座机";
            dataGridView1.Columns[6].HeaderText = "手机短号";
            dataGridView1.Columns[7].HeaderText = "QQ";
            dataGridView1.Columns[8].HeaderText = "电子邮箱";
            dataGridView1.Columns[9].HeaderText = "微信";
            dataGridView1.Columns[10].HeaderText = "省份号";
            dataGridView1.Columns[11].HeaderText = "城市号";
            dataGridView1.Columns[12].HeaderText = "区域号";
            dataGridView1.Columns[13].HeaderText = "家庭地址";
        }

        public void Bind_DropDownList(ComboBox cbb, string sqlstring, string disString, string valString)
        {
            try
            {
                DataSet ds = sqlda.ExceDS(sqlstring);
                cbb.DisplayMember = disString;
                cbb.ValueMember = valString;
                cbb.DataSource = ds.Tables[0];
                //cbb.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                sqlda.SqlClose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t1 = DateTime.Now;
            this.Text = "欢迎你," + userName1.ToString() + "!" + " 【ZIME通讯录系统】【" + t1.ToString() + "】"; 
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBirthAdd(2);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBirthAdd(3);
        }

        /// <summary>
        /// 将年月日填充到comboList控件
        /// </summary>
        public void cmbBirthAdd(int x)
        {
            int[] days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (x == 1)
            {
                cmbYear.Items.Clear();
                cmbMonth.Items.Clear();
                cmbDay.Items.Clear();
                for (int i = 1900; i <= Convert.ToInt32(t.Year); i++)
                {
                    cmbYear.Items.Add(i.ToString());
                }
            }
            else if (x == 2)
            {
                cmbMonth.Items.Clear();
                cmbDay.Items.Clear();
                for (int i = 1; i <= 12; i++)
                {
                    cmbMonth.Items.Add(i.ToString());
                }
            }
            else
            {
                cmbDay.Items.Clear();
                IsLeapYear(Convert.ToInt32(cmbYear.Text.Substring(0, 4)), ref days);
                for (int i = 1; i <= days[cmbMonth.SelectedIndex]; i++)
                {
                    cmbDay.Items.Add(i.ToString());
                }
            }
        }

        public void IsLeapYear(int year, ref int[] days)
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                days[1] = 29;
            }
        }

        private void cmbProvince_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Bind_DropDownList(cmbCity, "select * from [S_City] where [ProvinceID]='" + cmbProvince.SelectedValue.ToString() + " ' ", "CityName", "CityID");
        }

        private void cmbCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Bind_DropDownList(cmbDistrict, "select * from [S_District] where [CityID]='" + cmbCity.SelectedValue.ToString() + " ' ", "DistrictName", "DistrictID");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) dataFill();
        }

        /// <summary>
        /// 将选中的数据填充到用户界面的输入控件
        /// </summary>
        public void dataFill()
        {
            try
            {
                string sqlcmdProvince = "select ProvinceName from [S_Province] where [ProvinceID]='" + dataGridView1.CurrentRow.Cells[10].Value.ToString().Trim() + " '";
                string sqlcmdCity = "select CityName from [S_City] where [CityId]='" + dataGridView1.CurrentRow.Cells[11].Value.ToString().Trim() + " '";
                string sqlcmdDistrict = "select DistrictName from [S_District] where [DistrictId]='" + dataGridView1.CurrentRow.Cells[12].Value.ToString().Trim() + " '";

                DataSet ds1 = sqlda.ExceDS(sqlcmdProvince);
                DataSet ds2 = sqlda.ExceDS(sqlcmdCity);
                DataSet ds3 = sqlda.ExceDS(sqlcmdDistrict);

                //    0   1     2     3       4    5      6     7     8      9        10      11          12          13
                //   id,cName,cSex,cBirth,cMobile,cTel,cShortM,cQQ,cEmail,cWeiXin,cAddProId,cAddCityId,cAddAreaId,cAddDetail

                groupBox1.Text = "【No." + dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() + "/共" + dataGridView1.RowCount.ToString() + "条】";
                txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                cmbSex.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();

                cmbYear.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim()).Year.ToString().Trim();
                cmbMonth.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim()).Month.ToString().Trim();
                cmbDay.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim()).Day.ToString().Trim();

                txtMobile.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
                txtTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
                txtShortM.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtQQ.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString().Trim();
                txtWeiXin.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString().Trim();

                if (ds1.Tables[0].Rows.Count > 0) {cmbProvince.Text = ds1.Tables[0].Rows[0]["ProvinceName"].ToString().Trim();}
                if (ds2.Tables[0].Rows.Count > 0) {cmbCity.Text = ds2.Tables[0].Rows[0]["CityName"].ToString().Trim();}
                if (ds3.Tables[0].Rows.Count > 0) { cmbDistrict.Text = ds3.Tables[0].Rows[0]["DistrictName"].ToString().Trim(); }

                txtDetail.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString().Trim();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("数据库异常,请稍后尝试!");
            }
            finally
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCheck(ref txtName) && txtCheck(ref txtMobile) && txtCheck(ref txtTel) && txtCheck(ref txtShortM)
                && txtCheck(ref txtQQ) && txtCheck(ref txtEmail) && txtCheck(ref txtWeiXin) && txtCheck(ref txtDetail)
                && cmbCheck(cmbYear) && cmbCheck(cmbMonth) && cmbCheck(cmbDay) && cmbCheck(cmbSex))
            {
                setda.Add(txtName, txtMobile, txtTel, txtShortM, txtQQ, txtEmail, txtWeiXin, txtDetail, cmbSex, cmbYear, cmbMonth, cmbDay, cmbProvince, cmbCity, cmbDistrict);
                Bin_dataGridView();
                dataGridView1.Rows[0].Selected =false;
                dataGridView1 .Rows [dataGridView1 .Rows .Count -1].Selected =true;
                MessageBox.Show("成功添加1条记录");
                txtclear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要更新记录吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    int it = dataGridView1.CurrentRow.Index;
                    if (txtCheck(ref txtName) && txtCheck(ref txtMobile) && txtCheck(ref txtTel) && txtCheck(ref txtShortM)
                        && txtCheck(ref txtQQ) && txtCheck(ref txtEmail) && txtCheck(ref txtWeiXin) && txtCheck(ref txtDetail)
                        && cmbCheck(cmbYear) && cmbCheck(cmbMonth) && cmbCheck(cmbDay) && cmbCheck(cmbSex))
                    {
                        setda.update(txtName, txtMobile, txtTel, txtShortM, txtQQ, txtEmail, txtWeiXin, txtDetail, cmbSex, cmbYear, cmbMonth, cmbDay, cmbProvince, cmbCity, cmbDistrict, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim()));
                        Bin_dataGridView();
                        if (dataGridView1.Rows.Count > 0) dataGridView1.Rows[0].Selected = false;
                        dataGridView1.Rows[it].Selected = true;
                        MessageBox.Show("成功更新第" + dataGridView1.Rows[it].Cells [0].Value .ToString().Trim() + "条记录");
                        txtclear();
                    }
                }
                else
                {
                    MessageBox.Show("未选择任何行!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除记录吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    //MessageBox.Show(dataGridView1.CurrentRow.Index.ToString ());
                    //int it = dataGridView1.CurrentRow.Index;
                    //int it2 =dataGridView1 .Rows .Count ;
                        //MessageBox.Show(dataGridView1 .SelectedRows .Count.ToString ());
                        //int k = dataGridView1.SelectedRows.Count;

                    //由于多选情况复杂导致手动获取焦点困难，这里变向使用了remove方法，因为selectedrows集合是动态的，所以必须提前保存变量s+倒序删除
                    int s = dataGridView1.SelectedRows.Count - 1;
                    for (int i = s; i >= 0; i--)
                    {
                        setda.delete(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value.ToString().Trim()));
                        dataGridView1 .Rows .Remove(dataGridView1 .SelectedRows [i]);
                    }
                        /*Bin_dataGridView();
                        if (dataGridView1.Rows.Count > 0) dataGridView1.Rows[0].Selected = false;
                        if (it2 - k > 0)
                        {
                            if (dataGridView1.Rows.Count > 0)
                            {
                                if (it2 - k - (it2 - it) - 1 > dataGridView1.Rows.Count - 1)
                                {
                                    dataGridView1.Rows[it2 - k - (it2 - it) - 1].Selected = true;//总数-删除数-排除数
                                }
                                else
                                {
                                    if (it > 0) dataGridView1.Rows[it - 1].Selected = true;//总数-删除数-排除数
                                }
                            }
                        }*/
                    }
                    /*
                    else if (dataGridView1.CurrentRow.Index >= 0)
                    {
                        delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim()));
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow );
                        //Bin_dataGridView();
                        //if (dataGridView1.Rows.Count > 0) dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = false;
                        //if (it> 0) { dataGridView1.Rows[it - 1].Selected = true; }
                    }
                    */
                else
                {
                    MessageBox.Show("未选择任何行!");
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Bin_dataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setda.search(getSqlcmd(),dataGridView1);
            MessageBox.Show("成功查询到"+dataGridView1.Rows.Count .ToString ().Trim () +"条记录!");
        }

        public string getSqlcmd()
        {
            string sqlcmd = "select * from contractBaseInformation where";
            if (txtCheckSearch(ref txtName) /*&&txtName .Text .Trim ()!=""*/) { sqlcmd = sqlcmd + " cName LIKE '%" + txtName.Text.Trim() + "% '"; }
            if (txtCheckSearch(ref txtMobile) /*&& txtMobile.Text.Trim() != ""*/) { sqlcmd = sqlcmd + " AND cMobile LIKE '%" + txtMobile.Text.Trim() + "% '"; }
            if (txtCheckSearch(ref txtTel) /*&& txtTel.Text.Trim() != ""*/) { sqlcmd = sqlcmd + " AND cTel LIKE '%" + txtTel.Text.Trim() + "% '"; }
            if (txtCheckSearch(ref txtShortM) /*&& txtShortM.Text.Trim() != ""*/) { sqlcmd = sqlcmd + " AND cShortM LIKE '%" + txtShortM.Text.Trim() + "% '"; }
            if (txtCheckSearch(ref txtQQ) /*&& txtQQ.Text.Trim() != ""*/) { sqlcmd = sqlcmd + " AND cQQ LIKE '%" + txtQQ.Text.Trim() + "% '"; }
            if (txtCheckSearch(ref txtEmail) /*&& txtEmail.Text.Trim() != ""*/) { sqlcmd = sqlcmd + " AND cEmail LIKE '%" + txtEmail.Text.Trim() + "% '"; }
            if (txtCheckSearch(ref txtWeiXin) /*&& txtWeiXin.Text.Trim() != ""*/) { sqlcmd = sqlcmd + " AND cWeiXin LIKE '%" + txtWeiXin.Text.Trim() + "% '"; }
            if (txtCheckSearch(ref txtDetail) /*&& txtDetail.Text.Trim() != ""*/) { sqlcmd = sqlcmd + " AND cAddDetail LIKE '%" + txtDetail.Text.Trim() + "% '"; }

            if (cmbSex.Text !=""){ sqlcmd = sqlcmd + " AND cSex LIKE '" + cmbSex.Text.Trim() + "'"; };

            if (cmbYear.Text !="" && cmbMonth.Text=="" && cmbDay.Text=="")
            {
                //DateTime dt = Convert.ToDateTime(cmbYear.Text.ToString() + "-" + cmbMonth.Text.ToString() + "-" + cmbDay.Text.ToString());
                string dt = cmbYear.Text.ToString();
                sqlcmd = sqlcmd + " AND convert(varchar,cBirth,121) like '%" + dt.ToString().Trim() + "%'";
            }
            else if (cmbYear.Text != "" && cmbMonth.Text != "" && cmbDay.Text == "")
            {
                //DateTime dt = Convert.ToDateTime(cmbYear.Text.ToString() + "-" + cmbMonth.Text.ToString() + "-" + cmbDay.Text.ToString());
                string mm;
                if (cmbMonth.Text.Length == 1) { mm = "0" + cmbMonth.Text.ToString(); } else { mm = cmbMonth.Text.ToString(); }
                string dt = cmbYear.Text.ToString() + "-"+mm.ToString();
                sqlcmd = sqlcmd + " AND convert(varchar,cBirth,121) like '%" + dt.ToString().Trim() + "%'";
            }
            else if (cmbYear.Text != "" && cmbMonth.Text != "" && cmbDay.Text != "")
            {
                //DateTime dt = Convert.ToDateTime(cmbYear.Text.ToString() + "-" + cmbMonth.Text.ToString() + "-" + cmbDay.Text.ToString());
                string mm,dd;
                if (cmbMonth.Text.Length == 1) { mm = "0" + cmbMonth.Text.ToString(); } else { mm = cmbMonth.Text.ToString(); }
                if (cmbDay.Text.Length == 1) { dd = "0" + cmbDay.Text.ToString(); } else { dd = cmbDay.Text.ToString(); }
                string dt = cmbYear.Text.ToString() + "-" + mm.ToString() + "-" + dd.ToString ();
                sqlcmd = sqlcmd + " AND convert(varchar,cBirth,121) like '%" + dt.ToString().Trim() + "%'";
            }
            //**************
            string sqlcmdProvince = "select ProvinceID from [S_Province] where [ProvinceName]='" + cmbProvince.Text.ToString().Trim() + " '";
            string sqlcmdCity = "select CityID from [S_City] where [CityName]='" + cmbCity.Text.ToString().Trim() + " '";
            string sqlcmdDistrict = "select DistrictID from [S_District] where [DistrictName]='" + cmbDistrict.Text.ToString().Trim() + " '";

            DataSet ds1 = sqlda.ExceDS(sqlcmdProvince);
            DataSet ds2 = sqlda.ExceDS(sqlcmdCity);
            DataSet ds3 = sqlda.ExceDS(sqlcmdDistrict);

            int p = 0, c = 0, d = 0;

            if (ds1.Tables[0].Rows.Count > 0) { p = Convert.ToInt32(ds1.Tables[0].Rows[0]["ProvinceID"].ToString().Trim()); }
            if (ds2.Tables[0].Rows.Count > 0) { c = Convert.ToInt32(ds2.Tables[0].Rows[0]["CityID"].ToString().Trim()); }
            if (ds3.Tables[0].Rows.Count > 0) { d = Convert.ToInt32(ds3.Tables[0].Rows[0]["DistrictID"].ToString().Trim()); }
            //**************
            if (cmbProvince.Text.ToString().Trim() != "") { sqlcmd = sqlcmd + " AND cAddProId = '" + p.ToString().Trim() + "'"; };
            if (cmbCity.Text.ToString().Trim() != "") { sqlcmd = sqlcmd + " AND cAddCityId = '" + c.ToString().Trim() + "'"; };
            if (cmbDistrict.Text.ToString().Trim() != "") { sqlcmd = sqlcmd + " AND cAddAreaId = '" + d.ToString().Trim() + "'"; };

            MessageBox.Show(sqlcmd .ToString ());
            return sqlcmd;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtclear();
        }

        /// <summary>
        /// 输入一个文本框控件,检测内容是否合法
        /// </summary>
        public Boolean txtCheck(ref TextBox a)
        {
            string str = a.Text.ToString().Trim();
            if (a.Name == "txtName" )
            {
                if (!(Regex.IsMatch(str, "^[\u4e00-\u9fa5]+$"))) { MessageBox.Show("姓名格式错误或为空！", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtMobile" )
            {
                if (!(Regex.IsMatch(str, "^\\d{11}$") || str == "")) { MessageBox.Show("手机号码格式错误！,11位的电话号码", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtTel")
            {
                if (!(Regex.IsMatch(str, "^(\\d{3,4}-)?\\d{7,8}$") || str == "")) { MessageBox.Show("座机号码格式错误，x(3-4)-x(7-8)！", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtShortM")
            {
                if (!(Regex.IsMatch(str, "^\\d{6}$") || str == "")) { MessageBox.Show("手机短号格式错误！,6位的手机短号", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtQQ")
            {
                if (!(Regex.IsMatch(str, "[1-9][0-9]{4,}") || str == "")) { MessageBox.Show("QQ格式错误,10000开始的数字号码!", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtEmail")
            {
                if (!(Regex.IsMatch(str, "^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$") || str == "")) { MessageBox.Show("Email格式错误！", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtWeiXin")
            {
                if (!(Regex.IsMatch(str, "^[a-zA-Z]{1}[-_a-z-_A-Z\\d_]{5,19}$") || str == "")) { MessageBox.Show("微信号格式错误,5位以上英文开头字符串，包括数字英文下划线！", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtDetail")
            {
                return true;
            }
            else
            {
                return false  ;
            }
        }

        public Boolean txtCheckSearch(ref TextBox a)
        {
            string str = a.Text.ToString().Trim();
            if (a.Name == "txtName")
            {
                if (!(Regex.IsMatch(str, "^[\u4e00-\u9fa5]+$") || str == "")) { MessageBox.Show("姓名格式错误或为空！", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtMobile")
            {
                if (!(Regex.IsMatch(str, "^\\d{11}&") || str == "")) { MessageBox.Show("手机号码格式错误！,11位的电话号码", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtTel")
            {
                if (!(Regex.IsMatch(str, "^(\\d{3,4}-)?\\d{7,8}$") || str == "")) { MessageBox.Show("座机号码格式错误，x(3-4)-x(7-8)！", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtShortM")
            {
                if (!(Regex.IsMatch(str, "^\\d{6}$") || str == "")) { MessageBox.Show("手机短号格式错误！,6位的手机短号", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtQQ")
            {
                if (!(Regex.IsMatch(str, "[1-9][0-9]{4,}") || str == "")) { MessageBox.Show("QQ格式错误,10000开始的数字号码!", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtEmail")
            {
                if (!(Regex.IsMatch(str, "^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$") || str == "")) { MessageBox.Show("Email格式错误！", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtWeiXin")
            {
                if (!(Regex.IsMatch(str, "^[a-zA-Z]{1}[-_a-z-_A-Z\\d_]{5,19}$") || str == "")) { MessageBox.Show("微信号格式错误,5位以上英文开头字符串，包括数字英文下划线！", "数据格式错误！"); a.Clear(); return false; } else return true;
            }
            else if (a.Name == "txtDetail")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean cmbCheck(ComboBox a)
        {
            if (a.Name == "cmbYear" || a.Name == "cmbMonth" || a.Name == "cmbDay" ||a.Name =="cmbSex")
            {
                if (a.SelectedIndex == -1) { MessageBox.Show("性别及出生年月不能为空!", "数据格式错误！"); return false; } else return true;
            }
            else
            {
                return false ;
            }
        }

        public void txtclear()
        {
            groupBox1.Text= "";
            txtName.Clear();
            txtMobile.Clear();
            txtTel.Clear();
            txtShortM.Clear();
            txtQQ.Clear();
            txtEmail.Clear();
            txtDetail.Clear();
            txtWeiXin.Clear();

            cmbSex.SelectedIndex = -1;

            cmbYear.SelectedIndex = -1;
            cmbMonth.Items.Clear();
            //cmbMonth.SelectedIndex = -1;
            //cmbDay.SelectedIndex = -1;

            //cmbProvince.SelectedIndex = -1;
            //cmbCity.SelectedIndex = -1;
            //cmbDistrict.SelectedIndex = -1;
        }
        private void 修改密码MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            frmModify f2 = new frmModify();
            f2.Show();
        }

        private void 切换用户CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();//关闭窗体 释放资源
            this.Close();
            new frmLogin().Show();
        }

        private void 关于我们AToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fo.Close(); fo.Dispose();//关闭窗体 释放资源
            fo = new frmOther("关于 ZIME通讯录系统");
            fo.Show();
        }

        private void 用户反馈RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fo.Close(); fo.Dispose();
            fo = new frmOther("用户反馈");
            fo.Show();
        }

        private void 关于我们AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fo.Close(); fo.Dispose();
            fo = new frmOther("隐私条例");
            fo.Show();
        }

        private void 如何使用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fo.Close(); fo.Dispose();
            fo = new frmOther("使用帮助");
            fo.Show();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            this.BackgroundImage = Image.FromFile("..\\..\\pic\\beijing" + rd.Next(0, 2).ToString().Trim() + ".jpg");
            menuStrip1.BackColor = Color.Transparent;
        }

        private void 不显示默认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            this.BackgroundImage = null;
            menuStrip1.BackColor = Color.FromArgb(rd.Next(64, 256), rd.Next(64, 256), rd.Next(64, 256));//256RGB三色原光 强度越高 颜色越亮 255,255,255为白色
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}