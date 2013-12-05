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
    public partial class PigInfoForm : Form
    {
        public PigInfoForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(PigInfoForm_Load);
        }

        private void PigInfoForm_Load(object sender, EventArgs e)
        {
            InitGridType();
        }

        private void InitGridType()
        {
            string sqlStr=string.Format("select * from growingAndFatteningPigs");
            var dt = SqlHelper.ExcuteQuery(sqlStr);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("ID", "编号");
            dataGridView1.Columns.Add("g_pigId", "耳号");
            dataGridView1.Columns.Add("g_turnInTime", "转入时间");
            dataGridView1.Columns.Add("g_turnInWeek", "转入周次");
            dataGridView1.Columns.Add("g_inPigstyNumber", "转入栏");

            dataGridView1.Columns.Add("g_turnInCount", "转入头数");
            dataGridView1.Columns.Add("g_dateAge", "日龄");
            dataGridView1.Columns.Add("g_deathRegister", "死亡登记");
            dataGridView1.Columns.Add("g_SellRegister", "销售登记");
            dataGridView1.Columns.Add("g_survivalRate", "育肥阶段成活率");
            dataGridView1.Columns.Add("g_remark", "备注");
            var btn1 = new DataGridViewButtonColumn()
            {
                Text = "编辑",
                UseColumnTextForButtonValue = true
            };
            var btn2 = new DataGridViewButtonColumn()
            {
                Text = "查看",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.AddRange(btn1);
            dataGridView1.Columns.AddRange(btn2);
            dataGridView1.Columns[12].HeaderText = "操作";
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Columns[1].DataPropertyName = "ID";
            dataGridView1.Columns[2].DataPropertyName = "g_pigId";
            dataGridView1.Columns[3].DataPropertyName = "g_turnInTime";
            dataGridView1.Columns[4].DataPropertyName = "g_turnInWeek";
            dataGridView1.Columns[5].DataPropertyName = "g_inPigstyNumber";
            dataGridView1.Columns[6].DataPropertyName = "g_turnInCount";
            dataGridView1.Columns[7].DataPropertyName = "g_dateAge";
            dataGridView1.Columns[8].DataPropertyName = "g_deathRegister";
            dataGridView1.Columns[9].DataPropertyName = "g_SellRegister";
            dataGridView1.Columns[10].DataPropertyName = "g_survivalRate";
            dataGridView1.Columns[11].DataPropertyName = "g_remark";

        }

        private void btnOutExcel_Click(object sender, EventArgs e)
        {
            SqlHelper.SetToExcel(this.dataGridView1);
        }

    }

    public class StudentClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public string Class { get; set; }
        public int MathScroe { get; set; }
        public int ChineseScroe { get; set; }
        public int EnglishScore { get; set; }
        public int ComputerScroe { get; set; }
        public int SumScroe { get; set; }
    }
}
