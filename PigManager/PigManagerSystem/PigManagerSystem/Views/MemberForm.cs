using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PigManagerSystem.Views;

namespace PigManagerSystem
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MemberForm_Load);
        }

        void MemberForm_Load(object sender, EventArgs e)
        {
            InitGridType();
        }

        private void InitGridType()
        {
            string sqlStr = string.Format("select top 19 * from growingAndFatteningPigs ");
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
            var btn3 = new DataGridViewButtonColumn()
            {
                Text = "销售",
                UseColumnTextForButtonValue = true
            };

            dataGridView1.Columns.AddRange(btn1);
            dataGridView1.Columns.AddRange(btn2);
            dataGridView1.Columns.AddRange(btn3);
            dataGridView1.Columns[11].HeaderText = "操作";
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Columns[0].DataPropertyName = "ID";
            dataGridView1.Columns[1].DataPropertyName = "g_pigId";
            dataGridView1.Columns[2].DataPropertyName = "g_turnInTime";
            dataGridView1.Columns[3].DataPropertyName = "g_turnInWeek";
            dataGridView1.Columns[4].DataPropertyName = "g_inPigstyNumber";
            dataGridView1.Columns[5].DataPropertyName = "g_turnInCount";
            dataGridView1.Columns[6].DataPropertyName = "g_dateAge";
            dataGridView1.Columns[7].DataPropertyName = "g_deathRegister";
            dataGridView1.Columns[8].DataPropertyName = "g_SellRegister";
            dataGridView1.Columns[9].DataPropertyName = "g_survivalRate";
            dataGridView1.Columns[10].DataPropertyName = "g_remark";
        }

        private void btnOutExcel_Click(object sender, EventArgs e)
        {
            SqlHelper.SetToExcel(this.dataGridView1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPigInfoForm add = new AddPigInfoForm();
            add.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int count = 10;
            if (count <= 0)
            {
                MessageBox.Show("请选择要删除的数据");
            }
            else
            {
                if (MessageBox.Show("确定删除所选数据？") == DialogResult.OK)
                {
                    //删除
                    MessageBox.Show("成功删除");
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("打印成功");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.txtBoxEarId.Text = "";
        }

    }
}
