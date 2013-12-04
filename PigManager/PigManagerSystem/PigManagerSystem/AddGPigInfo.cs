using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PigManagerSystem.Unity;

namespace PigManagerSystem
{
    public partial class AddGPigInfo : Form
    {
        public AddGPigInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateText())
                {
                    int pigId = 0;
                    if (textBox1.Text.Length != 0)
                    {
                        pigId = Convert.ToInt32(this.textBox1.Text.Trim());
                    }
                    DateTime turnInTime = Convert.ToDateTime(dateTimePicker1.Text);

                    int turnInWeek = 0;
                    if (textBox3.Text.Length != 0)
                    {
                        turnInWeek = Convert.ToInt32(textBox3.Text.Trim());
                    }
                    int inPigstyNumber = 0;
                    if (textBox4.Text.Length != 0)
                    {
                        inPigstyNumber = Convert.ToInt32(textBox4.Text.Trim());
                    }
                    int turnInCount = 0;
                    if (textBox5.Text.Length != 0)
                    {
                        turnInCount = Convert.ToInt32(textBox5.Text.Trim());
                    }
                    int dateAge = 0;
                    if (textBox6.Text.Length != 0)
                    {
                        dateAge = Convert.ToInt32(textBox6.Text.Trim());
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


                    int survivalRate = 0;
                    if (textBox7.Text.Length != 0)
                    {
                        survivalRate = Convert.ToInt32(textBox7.Text.Trim());
                    }

                    string remark = "";
                    if (textBox8.Text.Length != 0)
                    {
                        remark = textBox8.Text.Trim();
                    }

                    string sqlStr = "insert into growingAndFatteningPigs(g_pigId,g_turnInTime,g_turnInWeek,g_inPigstyNumber,g_turnInCount,g_dateAge,g_deathRegister,g_SellRegister,g_survivalRate,g_remark)"
                                    + "values('" + pigId + "','" + turnInTime + "','" + turnInWeek + "','" + inPigstyNumber + "','" + turnInCount + "','" + dateAge + "'," + deathRegister + "," + SellRegister + ",'" + survivalRate + "','" + remark + "')";
                    string checkSqlStr = "select * from growingAndFatteningPigs where g_pigId =" + textBox1.Text + "";
                    DataTable checkResult = SqlHelper.ExcuteQueryToDataTable(checkSqlStr);
                    if (checkResult.Rows.Count > 0)
                    {
                        MessageBox.Show("育肥猪耳号不能重复,请重新输入", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private bool ValidateText()
        {
            if (textBox1.Text.Length == 0)
            {
                this.errorProvider1.SetError(textBox1, "输入内容不能为空");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox1.Text))
            {
                this.errorProvider1.SetError(textBox1, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox3.Text))
            {
                this.errorProvider1.SetError(textBox3, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox4.Text))
            {
                this.errorProvider1.SetError(textBox4, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox5.Text))
            {
                this.errorProvider1.SetError(textBox5, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox6.Text))
            {
                this.errorProvider1.SetError(textBox6, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox7.Text))
            {
                this.errorProvider1.SetError(textBox7, "输入数据必须为数字");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }
    }
}
