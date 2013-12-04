using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigManagerSystem
{
    public partial class ImportExcelData : Form
    {
        private string path = "";
        private DataTable excelData = null;
        private int _tableType;
        public ImportExcelData(int tableType)
        {
            this._tableType = tableType;
            InitializeComponent();
        }

        private void InitData()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = "xls";
            open.Filter = "Excel文件(*.xls)|*.xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
            }
             excelData=SqlHelper.ReadExcelToDateTable(path);
            this.dataGridView1.DataSource = excelData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //导入到数据库中
            string tableName;
            

            try
            {
                for (int i = 0; i < excelData.Rows.Count; i++)
                {
                    if (_tableType == 1)
                    {
                        tableName = "monthPigRegister";
                    }
                    else if (_tableType == 2)
                    {
                        tableName = "childCarePig";
                    }
                    else if(_tableType==3)
                    {
                        int pigId =Convert.ToInt32(excelData.Rows[i][0]);
                        DateTime turnInTime = Convert.ToDateTime(excelData.Rows[i][1]);
                        int turnWeek = Convert.ToInt32(excelData.Rows[i][2]);
                        int inPigstyNumber = Convert.ToInt32(excelData.Rows[i][3]);
                        int turnInCount = Convert.ToInt32(excelData.Rows[i][4]);
                        int dateAge = Convert.ToInt32(excelData.Rows[i][5]);
                        bool deathRegister = Convert.ToBoolean(excelData.Rows[i][6]);
                        bool SellRegister = Convert.ToBoolean(excelData.Rows[i][7]);
                        int survivalRate = Convert.ToInt32(excelData.Rows[i][8]);
                        string remark = excelData.Rows[i][9].ToString();
                        string sqlStr = "insert into growingAndFatteningPigs(g_pigId,g_turnInTime,g_turnInWeek,g_inPigstyNumber,g_turnInCount,g_dateAge,g_deathRegister,g_SellRegister,g_survivalRate,g_remark)"
                          + "values('" + pigId + "','" + turnInTime + "','" + turnWeek + "','" + inPigstyNumber + "','" + turnInCount + "','" + dateAge + "'," + deathRegister + "," + SellRegister + ",'" + survivalRate + "','" + remark + "')";
                        SqlHelper.ExecuteSql(sqlStr);
                    }
                }
                MessageBox.Show("添加入库成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入数据有误,请重新导入");
            }
           
        }

        private void ImportExcelData_Load(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
