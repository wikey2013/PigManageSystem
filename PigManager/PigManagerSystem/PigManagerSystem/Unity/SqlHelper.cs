using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop;
using PigManagerSystem.Unity;

namespace PigManagerSystem
{
    public class SqlHelper
    {
        //private static string filePath = @"E:\数据库\PigDataBase.accdb";
        private static string filePath = ConfigHelp.GetDataFileString();
        private static string conStr = "Provider=Microsoft.Ace.OleDb.12.0;" + @"Data Source=" + filePath + ";" + "Persist Security Info=False;";

        /// <summary>
        /// 执行SQL语句,add update delete
        /// </summary>
        /// <param name="sqlStr"></param>
        public static void ExecuteSql(string sqlStr)
        {
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand())   
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = sqlStr;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// 执行SQL语句,返回dataset
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public static DataSet ExcuteQuery(string sqlStr)
        {
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlStr;
                    cmd.CommandType = CommandType.Text;
                    DataSet dt = new DataSet();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// 执行SQL语句,返回dataTable
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public static DataTable ExcuteQueryToDataTable(string sqlStr)
        {
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sqlStr;
                    cmd.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static OleDbDataReader ExcuteQuerySqlToDataReader(string sqlStr)
        {
            OleDbConnection conn = new OleDbConnection(conStr);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.TableDirect;
            cmd.CommandText = sqlStr;
            cmd.Connection = conn;
            OleDbDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public static OleDbDataReader UserLogin(string userName, string pwd)
        {
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string loginSqlStr = "select * from UserLogin where userName = '" + userName + "' and userPwd='" + pwd + "'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = loginSqlStr;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader dr = cmd.ExecuteReader();
                return dr;
            }
        }

        /// <summary>
        /// 将datagridview的数据导出到Excel中
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void SetToExcel(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "xls";
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出Excel文件到";
            saveFileDialog.ShowDialog();
            Stream myStream = saveFileDialog.OpenFile();
            using (StreamWriter sw = new StreamWriter(myStream, Encoding.GetEncoding("gb2312")))
            {
                string str = "";
                try
                {
                    for (int i = 0; i < dataGridView.ColumnCount; i++)
                    {
                        if (i > 0)
                        {
                            str += "\t";
                        }
                        str += dataGridView.Columns[i].HeaderText;
                    }
                    sw.WriteLine(str);
                    for (int j = 0; j < dataGridView.Rows.Count - 1; j++)
                    {
                        string tempStr = "";
                        for (int k = 0; k < dataGridView.Columns.Count; k++)
                        {
                            if (k > 0)
                            {
                                tempStr += "\t";
                            }
                            tempStr += dataGridView.Rows[j].Cells[k].Value.ToString();
                        }
                        sw.WriteLine(tempStr);
                    }
                }
                catch (Exception e)
                {
                    
                }
                finally
                {
                    //myStream.Close();
                    //myStream.Dispose();
                }
            }
        }


        /// <summary>
        /// 读取excel信息
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DataTable ReadExcelToDateTable(string path)
        {
            DataTable dt = new DataTable();
            dt.TableName = "Excel";
            var app = new Microsoft.Office.Interop.Excel.Application();
            var obj = Missing.Value;
            try
            {
                var workBook = app.Workbooks.Open(path, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj);
                var sheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);
                DataRow newRow = null;
                DataColumn newColumn = null;
                for (int i = 2; i <= sheet.UsedRange.Rows.Count; i++)
                {
                    newRow = dt.NewRow();
                    for (int j = 1; j <= sheet.UsedRange.Columns.Count; j++)
                    {
                        if (i == 2 && j == 1)
                        {
                            for (int k = 1; k <= sheet.UsedRange.Columns.Count; k++)
                            {
                                string str = (sheet.UsedRange[1, k] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                                newColumn = new DataColumn(str);
                                newRow.Table.Columns.Add(newColumn);
                            }
                        }
                        Microsoft.Office.Interop.Excel.Range range = sheet.Cells[i, j] as Microsoft.Office.Interop.Excel.Range;
                        if (range != null && !"".Equals(range.Text.ToString()))
                        {
                            newRow[j - 1] = range.Value2;
                        }
                    }
                    dt.Rows.Add(newRow);
                }
                app.Quit();
                int generation = GC.GetGeneration(app);
                GC.Collect(generation);
                return dt;
            }
            catch (System.NullReferenceException ec)
            {
                MessageBox.Show("导入的Excel文档表头为空,请导入正确的文档,错误原因:" + ec.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取信息失败,失败原因为:" + ex.Message);
                return null;
            }
        }
    }
}