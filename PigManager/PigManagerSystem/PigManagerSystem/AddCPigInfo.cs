using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using PigManagerSystem.Unity;

namespace PigManagerSystem
{
    public partial class AddCPigInfo : Form
    {
        public AddCPigInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateText())
                {
                    int eraId = 0;
                    if (txtEarId.Text.Length != 0)
                    {
                        eraId = Convert.ToInt32(this.txtEarId.Text.Trim());
                    }
                    int inHouseDate = 0;
                    if (txtday.Text.Length != 0)
                    {
                        inHouseDate = Convert.ToInt32(txtday.Text.Trim());
                    }
                    int inHouseWeek = 0;
                    if (txtWeek.Text.Length != 0)
                    {
                        inHouseWeek = Convert.ToInt32(txtWeek.Text.Trim());
                    }
                    int inPigstyNumber = 0;
                    if (txtColumn.Text.Length != 0)
                    {
                        inPigstyNumber = Convert.ToInt32(txtColumn.Text.Trim());
                    }
                    int inCount = 0;
                    if (txtheadage.Text.Length != 0)
                    {
                        inCount = Convert.ToInt32(txtheadage.Text.Trim());
                    }
                    int dateAge = 0;
                    if (txtAge.Text.Length != 0)
                    {
                        dateAge = Convert.ToInt32(txtAge.Text.Trim());
                    }
                    bool deathRegister = false;
                    if (checkBox1.Checked)
                    {
                        deathRegister = true;
                    }

                    bool SellRegister = false;
                    if (checkBox2.Checked)
                    {
                        SellRegister = true;
                    }

                    int turnInPigstyDate = 0;
                    if (txtfatColumnDate.Text.Length != 0)
                    {
                        turnInPigstyDate = Convert.ToInt32(txtfatColumnDate.Text.Trim());
                    }

                    int turnInPigstyWeek = 0;
                    if (txtFatColumnWeek.Text.Length != 0)
                    {
                        turnInPigstyWeek = Convert.ToInt32(txtFatColumnWeek.Text.Trim());
                    }
                    int turnOutCount = 0;
                    if (textBox1.Text.Length != 0)
                    {
                        turnOutCount = Convert.ToInt32(textBox1.Text.Trim());
                    }
                    int survivalRate = 0;
                    if (txtsurrvieRate.Text.Length != 0)
                    {
                        survivalRate = Convert.ToInt32(txtsurrvieRate.Text.Trim());
                    }

                    string remark = "";
                    if (txtRemark.Text.Length != 0)
                    {
                        remark = txtRemark.Text.Trim();
                    }

                    string sqlStr = "insert into childCarePig(c_pigId,c_inHouseDate,c_inHouseWeek,c_inPigstyNumber,c_inCount,c_dateAge,c_deathRegister,c_SellRegister,c_turnInPigstyDate,c_turnInPigstyWeek,c_turnOutCount,c_survivalRate,c_remark)"
                                    + "values('" + eraId + "','" + inHouseDate + "','" + inHouseWeek + "','" + inPigstyNumber + "','" + inCount + "','" + dateAge + "'," + deathRegister + "," + SellRegister + ",'" + turnInPigstyDate + "','" + turnInPigstyWeek + "','" + turnOutCount + "','" + survivalRate + "','" + remark + "')";
                    string checkSqlStr = "select * from childCarePig where c_pigId =" + txtEarId.Text + "";
                    DataTable checkResult = SqlHelper.ExcuteQueryToDataTable(checkSqlStr);
                    if (checkResult.Rows.Count > 0)
                    {
                        MessageBox.Show("保育猪耳号不能重复,请重新输入", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlHelper.ExecuteSql(sqlStr);
                        MessageBox.Show("添加成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序出现了不可预计的错误" + ex, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEarId_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private bool ValidateText()
        {
            if (this.txtEarId.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtEarId, "输入内容不能为空");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.txtEarId.Text))
            {
                this.errorProvider1.SetError(txtEarId, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.txtday.Text))
            {
                this.errorProvider1.SetError(txtday, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.txtWeek.Text))
            {
                this.errorProvider1.SetError(txtWeek, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.txtColumn.Text))
            {
                this.errorProvider1.SetError(txtColumn, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.txtheadage.Text))
            {
                this.errorProvider1.SetError(txtheadage, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.txtAge.Text))
            {
                this.errorProvider1.SetError(txtAge, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.txtfatColumnDate.Text))
            {
                this.errorProvider1.SetError(txtfatColumnDate, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.txtFatColumnWeek.Text))
            {
                this.errorProvider1.SetError(txtFatColumnWeek, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.txtsurrvieRate.Text))
            {
                this.errorProvider1.SetError(txtsurrvieRate, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox1.Text))
            {
                this.errorProvider1.SetError(textBox1, "输入数据必须为数字");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtday_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtWeek_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtColumn_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtheadage_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtfatColumnDate_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtFatColumnWeek_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtsurrvieRate_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

    }
}
