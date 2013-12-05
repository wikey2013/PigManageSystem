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
    public partial class SystemSetingForm : Form
    {
        public SystemSetingForm()
        {
            InitializeComponent();
            //this.Load += new EventHandler(SystemSetingForm_Load);
        }

        void SystemSetingForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = ConfigHelp.GetDataFileString();
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "数据库文件(*.accdb)|*.accdb";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = openFile.FileName;
            }
        }

        private void btSure_Click(object sender, EventArgs e)
        {
            string filePath = "";
            if (textBox1.Text.Length != 0)
            {
                filePath = textBox1.Text.Trim();
            }
            ConfigHelp.SetDataFileString(filePath);

            if (checkBox1.Checked)
            {
                //设置开机启动
                string path = AppDomain.CurrentDomain.BaseDirectory + "/PigManagerSystem.exe";
                ComHelp.SetAutoRun("PigManagerSystem", path);
            }
            else if (checkBox1.Checked == false)
            {
                ComHelp.DeleteAutoRun("PigManagerSystem");
            }


            if (checkBox2.Checked)
            {
                //设置定时关机
                string time = textBox2.Text + ":" + textBox3.Text + ":" + textBox4.Text;
                System.Diagnostics.Process.Start("cmd.exe", "/c at " + time + " Shutdown -s ");
            }
            MessageBox.Show("设置成功！！!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
