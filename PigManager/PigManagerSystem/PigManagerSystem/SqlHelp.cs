using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace PigManagerSystem
{
    public static class SqlHelp
    {

       private static string connectionString = "Provider=Microsoft.Ace.OleDb.12.0;" + @"Data Source=E:\数据库\PigDataBase.accdb;" + "Persist Security Info=False;";

        ///
        ///执行一个不需要返回值的SqlCommand命令，通过指定专用的连接字符串。
        /// 使用参数数组形式提供参数列表
        ///
        /// 使用示例：
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// 一个有效的数据库连接字符串
        /// SqlCommand命令类型 (存储过程， T-SQL语句， 等等。)
        /// 存储过程的名字或者 T-SQL 语句
        /// 以数组形式提供SqlCommand命令中用到的参数列表
        /// 返回一个数值表示此SqlCommand命令执行后影响的行数
        public static int ExcuteNoQuery(CommandType cmdType, string cmdText, params OleDbParameter[] paramList)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                PrepareCommand(conn, cmd, null, cmdType, cmdText, paramList);
                int resultValue = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return resultValue;
            }
        }

        /// <summary>
        /// 方法重载，限定查询时间，返回影响的记录数
        /// 客观的多并发查询时，可限制用户查询时间，以免对服务器增加负担
        /// </summary>
        /// <param name="Times">等待命令执行的时间，默认值为 30 秒。</param>
        /// <returns>影响的记录数</returns>
        public static int ExcuteQueryByTimes(CommandType cmdType, OleDbTransaction trans, string cmdText, int times, params OleDbParameter[] paramList)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                PrepareCommand(conn, cmd, trans, cmdType, cmdText, paramList);
                cmd.CommandTimeout = times;//默认限定查询时间
                int resultValue = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return resultValue;
            }
        }

        ///
        /// 执行一条返回结果集的SqlCommand命令，通过专用的连接字符串。
        /// 使用参数数组提供参数
        ///
        ///
        /// 使用示例： 
        ///  SqlDataReader r = ExecuteReader(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        ///
        /// 一个有效的数据库连接字符串
        /// SqlCommand命令类型 (存储过程， T-SQL语句， 等等。)
        /// 存储过程的名字或者 T-SQL 语句
        /// 以数组形式提供SqlCommand命令中用到的参数列表
        /// 返回一个包含结果的SqlDataReader
        public static OleDbDataReader ExcuteReader(CommandType cmdType, string cmdText, params OleDbParameter [] paramsList)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    PrepareCommand(conn, cmd, null, cmdType, cmdText, paramsList);
                    OleDbDataReader dataAp = cmd.ExecuteReader();
                    cmd.Parameters.Clear();
                    return dataAp;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }

        ///
        /// 执行一条返回第一条记录第一列的SqlCommand命令，通过已经存在的数据库连接。
        /// 使用参数数组提供参数
        ///
        ///
        /// 使用示例：
        ///  Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        ///
        /// 一个已经存在的数据库连接
        /// SqlCommand命令类型 (存储过程， T-SQL语句， 等等。)
        /// 存储过程的名字或者 T-SQL 语句
        /// 以数组形式提供SqlCommand命令中用到的参数列表
        /// 返回一个object类型的数据，可以通过 Convert.To{Type}方法转换类型
        public static object ExecuteScalar(CommandType cmdType, string cmdText, params OleDbParameter [] parpamsList)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    PrepareCommand(conn, cmd, null, cmdType, cmdText, parpamsList);
                    var data = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    return data;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// 执行Sql语句查询,返回DataSet
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="parpamsList"></param>
        /// <returns></returns>
        public static DataSet QueryDataSet(CommandType cmdType, string cmdText, params OleDbParameter[] parpamsList)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    PrepareCommand(conn, cmd, null, cmdType, cmdText, parpamsList);
                    DataSet dt = new DataSet();
                    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                    adp.Fill(dt);

                    cmd.Parameters.Clear();
                    return dt;
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// 执行SQL语句,返回dataTable类型
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="trans"></param>
        /// <param name="parpamsList"></param>
        /// <returns></returns>
        public static DataTable QueryDatTable(CommandType cmdType, string cmdText, OleDbTransaction trans, params OleDbParameter[] parpamsList)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    PrepareCommand(conn, cmd, trans, cmdType, cmdText, parpamsList);
                    DataTable dataTable = new DataTable();
                    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                    adp.Fill(dataTable);
                    cmd.Parameters.Clear();
                    return dataTable;
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// 执行SQL语句,返回dataView
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="trans"></param>
        /// <param name="parpamList"></param>
        /// <returns></returns>
        public static DataView QueryDataView(CommandType cmdType, string cmdText, OleDbTransaction trans, params OleDbParameter[] parpamList)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    PrepareCommand(conn, cmd, trans, cmdType, cmdText, parpamList);
                    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adp.Fill(dataTable);
                    DataView dview = new DataView(dataTable);
                    cmd.Parameters.Clear();
                    return dview;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        ///为执行命令准备参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmd"></param>
        /// <param name="trans"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameter"></param>
        private static void PrepareCommand(OleDbConnection conn, OleDbCommand cmd, OleDbTransaction trans, CommandType cmdType, string cmdText, OleDbParameter[] parameter)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }

            if (parameter != null)
            {
                foreach (var item in parameter)
                {
                    cmd.Parameters.Add(item);
                }
            }
        }
    }
}
