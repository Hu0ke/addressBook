using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentInfoTool
{
    class dataSet
    {
        SqlData sqlda = new SqlData();

        public void Add(TextBox a1, TextBox a2, TextBox a3, TextBox a4, TextBox a5,
                TextBox a6, TextBox a7, TextBox a8,
                ComboBox b1, ComboBox b2, ComboBox b3, ComboBox b4, ComboBox b5,
                ComboBox b6, ComboBox b7)
        {
            try
            {
                string sqlcmdProvince = "select ProvinceID from [S_Province] where [ProvinceName]='" + b5.Text.ToString().Trim() + " '";
                string sqlcmdCity = "select CityID from [S_City] where [CityName]='" + b6.Text.ToString().Trim() + " '";
                string sqlcmdDistrict = "select DistrictID from [S_District] where [DistrictName]='" + b7.Text.ToString().Trim() + " '";

                DataSet ds1 = sqlda.ExceDS(sqlcmdProvince);
                DataSet ds2 = sqlda.ExceDS(sqlcmdCity);
                DataSet ds3 = sqlda.ExceDS(sqlcmdDistrict);

                int pp = 0, cc = 0, dd = 0;

                if (ds1.Tables[0].Rows.Count > 0) { pp = Convert.ToInt32(ds1.Tables[0].Rows[0]["ProvinceID"].ToString().Trim()); }
                if (ds2.Tables[0].Rows.Count > 0) { cc = Convert.ToInt32(ds2.Tables[0].Rows[0]["CityID"].ToString().Trim()); }
                if (ds3.Tables[0].Rows.Count > 0) { dd = Convert.ToInt32(ds3.Tables[0].Rows[0]["DistrictID"].ToString().Trim()); }

                //DateTime dt = Convert.ToDateTime("1998-10-25");

                DateTime dt = Convert.ToDateTime(b2.Text.ToString() + "-" + b3.Text.ToString() + "-" + b4.Text.ToString());
                string zd = "cName,cSex,cBirth,cMobile,cTel,cShortM,cQQ,cEmail,cWeiXin,cAddProId,cAddCityId,cAddAreaId,cAddDetail";
                string value = "'" + a1.Text.ToString().Trim() + "','" + b1.Text.ToString().Trim() + "','" + dt.ToString().Trim() + "','" + a2.Text.ToString().Trim() + "','" + a3.Text.ToString().Trim() + "'," +
                                "'" + a4.Text.ToString().Trim() + "' ,'" + a5.Text.ToString().Trim() + "','" + a6.Text.ToString().Trim() + "','" + a7.Text.ToString().Trim() + "','" + pp.ToString().Trim() + "'," +
                                "'" + cc.ToString().Trim() + "','" + dd.ToString().Trim() + "','" + a8.Text.ToString().Trim() + "'";

                string sqlcmd = "insert into contractBaseInformation(" + zd + ") values(" + value + ")";
                sqlda.ExceDS(sqlcmd);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常,请稍后尝试!");
            }
            finally
            {

            }
        }

        public void update(TextBox a1, TextBox a2, TextBox a3, TextBox a4, TextBox a5,
                        TextBox a6, TextBox a7, TextBox a8,
                        ComboBox b1, ComboBox b2, ComboBox b3, ComboBox b4, ComboBox b5,
                        ComboBox b6, ComboBox b7, int id)
        {
            try
            {
                string sqlcmdProvince = "select ProvinceID from [S_Province] where [ProvinceName]='" + b5.Text.ToString().Trim() + " '";
                string sqlcmdCity = "select CityID from [S_City] where [CityName]='" + b6.Text.ToString().Trim() + " '";
                string sqlcmdDistrict = "select DistrictID from [S_District] where [DistrictName]='" + b7.Text.ToString().Trim() + " '";

                DataSet ds1 = sqlda.ExceDS(sqlcmdProvince);
                DataSet ds2 = sqlda.ExceDS(sqlcmdCity);
                DataSet ds3 = sqlda.ExceDS(sqlcmdDistrict);

                int pp = 0, cc = 0, dd = 0;

                if (ds1.Tables[0].Rows.Count > 0) { pp = Convert.ToInt32(ds1.Tables[0].Rows[0]["ProvinceID"].ToString().Trim()); }
                if (ds2.Tables[0].Rows.Count > 0) { cc = Convert.ToInt32(ds2.Tables[0].Rows[0]["CityID"].ToString().Trim()); }
                if (ds3.Tables[0].Rows.Count > 0) { dd = Convert.ToInt32(ds3.Tables[0].Rows[0]["DistrictID"].ToString().Trim()); }

                //DateTime dt = Convert.ToDateTime("1998-10-25");

                DateTime dt = Convert.ToDateTime(b2.Text.ToString() + "-" + b3.Text.ToString() + "-" + b4.Text.ToString());
                string sqlcmd = "update contractBaseInformation set cName='" + a1.Text.ToString().Trim() + "' ,cSex='" + b1.Text.ToString().Trim() + "',cBirth='" + dt.ToString().Trim() + "',cMobile='" + a2.Text.ToString().Trim() + "'," +
                    "cTel='" + a3.Text.ToString().Trim() + "',cShortM='" + a4.Text.ToString().Trim() + "' ,cQQ='" + a5.Text.ToString().Trim() + "',cEmail='" + a6.Text.ToString().Trim() + "',cWeiXin='" + a7.Text.ToString().Trim() + "'," +
                    "cAddProId='" + pp.ToString().Trim() + "',cAddCityId='" + cc.ToString().Trim() + "',cAddAreaId='" + dd.ToString().Trim() + "',cAddDetail ='" + a8.Text.ToString().Trim() + "'  where id='" + id.ToString() + "'";
                sqlda.ExceDS(sqlcmd);
                //MessageBox.Show(sqlcmd);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常,请稍后尝试!");
            }
            finally
            {

            }
        }

        public void delete(int y)
        {
            try
            {
                string sqlcmd = "delete from contractBaseInformation where id= '" + y.ToString().Trim() + "'";
                sqlda.ExceDS(sqlcmd);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常,请稍后尝试!");
            }
            finally
            {
            }
        }

        public void search(string sqlcmd,DataGridView dataGridView1)
        {
            try
            {
                DataSet ds = sqlda.ExceDS(sqlcmd);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常,请稍后尝试!");
            }
            finally
            {

            }
        }
    }
}
