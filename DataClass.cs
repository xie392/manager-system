using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Admin
{
    class DataClass
    {
        public static string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Admin.mdf;Integrated Security=True";
        static SqlConnection sqlConn;

        /// <summary>
        /// 执行sql语句，返回的是true或false
        /// </summary>
        /// <param name="connStr">连接数据库字符串</param>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        /// 
        private static bool sqlChuLi(string connStr, string sql)
        {
            try
            {

                sqlConn = new SqlConnection(connStr);                    // 实例化对象
                sqlConn.Open();                                          // 打开数据库
                SqlCommand sqlcomm = new SqlCommand(sql, sqlConn);       // 命令
                int result = 0;
                result = sqlcomm.ExecuteNonQuery();              // 在间接的执行SQL语句时取到受影响的行数提示        
                sqlConn.Close();                                // 关闭数据库
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "提醒", MessageBoxButtons.OKCancel);
                return false;
            }
        }

        /// <summary>
        /// 添加，返回的是true或false
        /// </summary>
        /// <param name="connStr">连接数据库字符串</param>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static bool SqlAdd(string connStr, string sql)
        {
            return sqlChuLi(connStr, sql);
        }

        /// <summary>
        /// 删除，返回的是true或false
        /// </summary>
        /// <param name="connStr">连接数据库字符串</param>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static bool SqlDel(string connStr, string sql)
        {
            return sqlChuLi(connStr, sql);
        }

        /// <summary>
        /// 修改，返回的是true或false
        /// </summary>
        /// <param name="connStr">连接数据库字符串</param>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static bool SqlUpDatee(string connStr, string sql)
        {
            return sqlChuLi(connStr, sql);
        }

        /// <summary>
        /// 查询，返回的是DataSet
        /// </summary>
        /// <param name="connStr">连接数据库字符串</param>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static DataSet SqlSetSelcet(string connStr, string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConn = new SqlConnection(connStr);
                sqlConn.Open();
                SqlCommand Com = new SqlCommand(sql, sqlConn);
                SqlDataAdapter SqlDa = new SqlDataAdapter(Com);
                SqlDa.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                sqlConn.Close();
            }
        }

        /// <summary>
        /// 查询，返回的是true或false
        /// </summary>
        /// <param name="connStr">连接数据库字符串</param>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static bool Sqlselect(string connStr, string sql)
        {
            int result = SqlSetSelcet(connStr, sql).Tables[0].Rows.Count;
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 查询，返回的true,false
        /// </summary>
        /// <param name="connStr">连接数据库字符串</param>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public static bool Sqllogin(string connStr, string sql)
        {
            try
            {
                sqlConn = new SqlConnection(connStr);
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                
                cmd.CommandText = sql;
                SqlDataReader dr = cmd.ExecuteReader();
                //用dr的read函数，每执行一次，返回一个包含下一行数据的集合dr，在执行read函数之前，dr并不是集合
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }


        
        
}
