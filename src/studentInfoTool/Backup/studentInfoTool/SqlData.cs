using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Collections;

/// <summary>
/// 数据库的底层连接类。
/// </summary>
public class SqlData
{
    #region---内部变量---
    public SqlConnection sqlcon;
    public SqlCommand sqlcmd;
    public SqlDataAdapter da;
    public SqlDataReader dr;
    SqlTransaction st;
    #endregion

    /// <summary>
    /// 初始化连接类的对象实例
    /// </summary>
    public SqlData()
    {
        //sqlcon = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog='ZIME';Data Source='(local)'");
        sqlcon = new SqlConnection(@" server = .\SQLEXPRESS;database = stdDataBase;integrated security=SSPI");
    }

    /// <summary>
    /// 返回一个给定的查询语句的结果集合
    /// </summary>
    public SqlDataReader ExecuteReader(string sql)
    {
        try
        {
            sqlcon.Open();
            sqlcmd = new SqlCommand(sql, sqlcon);
            dr = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {

        }
    }

    /// <summary>
    /// 无返回的查询语句
    /// </summary>
    public void ExecuteNonQuery(string sql)
    {
        try
        {
            sqlcon.Open();
            sqlcmd = new SqlCommand(sql, sqlcon);
            sqlcmd.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            sqlcon.Close();
        }
    }

    /// <summary>
    /// 返回一个对应语句查询的结果Set结合
    /// </summary>
    public DataSet ExceDS(string sql)
    {
        try
        {
            sqlcon.Open();
            da = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            sqlcon.Close();
        }
    }

    public Boolean ExecMultiInsert(ArrayList sqlSentenceSet)
    {
        try
        {
            sqlcon.Open();
            st = sqlcon.BeginTransaction();
            sqlcmd = sqlcon.CreateCommand();
            sqlcmd.Transaction = st;
            for (int i = 0; i < sqlSentenceSet.Count; i++)
            {
                sqlcmd.CommandText = sqlSentenceSet[i].ToString();
                sqlcmd.ExecuteNonQuery();
            }
            st.Commit();
            return true;
        }
        catch (Exception ex)
        {
            st.Rollback();
            return false;
        }
        finally
        {
            sqlcon.Close();
        }
    }

    /// <summary>
    /// 关闭数据库的连接
    /// </summary>
    public void SqlClose()
    {
        sqlcon.Close();
    }

  
}
