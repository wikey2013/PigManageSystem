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
    public partial class ChildPigInfoFrom : Form
    {
        public delegate void SendChildPigInfoHandler(List<PigInfo> pigList);
        public event SendChildPigInfoHandler SendEvent;
        public ChildPigInfoFrom()
        {
            InitializeComponent();
            this.Load += new EventHandler(ChildPigInfoFrom_Load);
        }

        void ChildPigInfoFrom_Load(object sender, EventArgs e)
        {
            InitCombobox(this.comboBox1);
            InitCombobox(this.comboBox2);
            InitCombobox(this.comboBox3);
            InitCombobox(this.comboBox4);
            InitCombobox(this.comboBox5);
            InitCombobox(this.comboBox6);
            InitCombobox(this.comboBox7);
            InitCombobox(this.comboBox8);
            InitCombobox(this.comboBox9);
            InitCombobox(this.comboBox10);
            InitCombobox(this.comboBox11);
            InitCombobox(this.comboBox12);
            InitCombobox(this.comboBox13);
            InitCombobox(this.comboBox14);
            InitCombobox(this.comboBox15);
            InitCombobox(this.comboBox16);
            InitCombobox(this.comboBox17);
            InitCombobox(this.comboBox18);
            InitCombobox(this.comboBox19);
            InitCombobox(this.comboBox20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                var childPigList = AddPigInfoList();

                if (SendEvent != null)
                {
                    SendEvent(childPigList);
                    this.Close();
                }
            }
        }

        private List<PigInfo> AddPigInfoList()
        {
            var pigList = new List<PigInfo>()
            {
                new PigInfo(){PigId=this.textBox1.Text.Trim(),PigType=this.comboBox1.SelectedItem.ToString(),IsDeath=this.checkBox1.Checked},
                new PigInfo(){PigId=this.textBox2.Text.Trim(),PigType=this.comboBox2.SelectedItem.ToString(),IsDeath=this.checkBox2.Checked},
                new PigInfo(){PigId=this.textBox3.Text.Trim(),PigType=this.comboBox3.SelectedItem.ToString(),IsDeath=this.checkBox3.Checked},
                new PigInfo(){PigId=this.textBox4.Text.Trim(),PigType=this.comboBox4.SelectedItem.ToString(),IsDeath=this.checkBox4.Checked},
                new PigInfo(){PigId=this.textBox5.Text.Trim(),PigType=this.comboBox5.SelectedItem.ToString(),IsDeath=this.checkBox5.Checked},
                new PigInfo(){PigId=this.textBox6.Text.Trim(),PigType=this.comboBox6.SelectedItem.ToString(),IsDeath=this.checkBox6.Checked},
                new PigInfo(){PigId=this.textBox7.Text.Trim(),PigType=this.comboBox7.SelectedItem.ToString(),IsDeath=this.checkBox7.Checked},
                new PigInfo(){PigId=this.textBox8.Text.Trim(),PigType=this.comboBox8.SelectedItem.ToString(),IsDeath=this.checkBox8.Checked},
                 new PigInfo(){PigId=this.textBox9.Text.Trim(),PigType=this.comboBox9.SelectedItem.ToString(),IsDeath=this.checkBox9.Checked},
                new PigInfo(){PigId=this.textBox10.Text.Trim(),PigType=this.comboBox10.SelectedItem.ToString(),IsDeath=this.checkBox10.Checked},
                new PigInfo(){PigId=this.textBox11.Text.Trim(),PigType=this.comboBox11.SelectedItem.ToString(),IsDeath=this.checkBox11.Checked},
                new PigInfo(){PigId=this.textBox12.Text.Trim(),PigType=this.comboBox12.SelectedItem.ToString(),IsDeath=this.checkBox12.Checked},
                new PigInfo(){PigId=this.textBox13.Text.Trim(),PigType=this.comboBox13.SelectedItem.ToString(),IsDeath=this.checkBox13.Checked},
                new PigInfo(){PigId=this.textBox14.Text.Trim(),PigType=this.comboBox14.SelectedItem.ToString(),IsDeath=this.checkBox14.Checked},
                new PigInfo(){PigId=this.textBox15.Text.Trim(),PigType=this.comboBox15.SelectedItem.ToString(),IsDeath=this.checkBox15.Checked},
                new PigInfo(){PigId=this.textBox16.Text.Trim(),PigType=this.comboBox16.SelectedItem.ToString(),IsDeath=this.checkBox16.Checked},
                 new PigInfo(){PigId=this.textBox17.Text.Trim(),PigType=this.comboBox17.SelectedItem.ToString(),IsDeath=this.checkBox17.Checked},
                new PigInfo(){PigId=this.textBox18.Text.Trim(),PigType=this.comboBox18.SelectedItem.ToString(),IsDeath=this.checkBox18.Checked},
                new PigInfo(){PigId=this.textBox19.Text.Trim(),PigType=this.comboBox19.SelectedItem.ToString(),IsDeath=this.checkBox19.Checked},
                new PigInfo(){PigId=this.textBox20.Text.Trim(),PigType=this.comboBox20.SelectedItem.ToString(),IsDeath=this.checkBox20.Checked},
            };
            return pigList;
        }

        private void InitCombobox(ComboBox comboBox)
        {
            comboBox.Items.Add("健仔");
            comboBox.Items.Add("弱仔");
            comboBox.Items.Add("死胎");
            comboBox.Items.Add("木乃伊");
            comboBox.SelectedIndex = 0;
        }

        private bool ValidateText()
        {
            if (!ComHelp.ValidateInt(this.textBox1.Text))
            {
                this.errorProvider1.SetError(textBox1, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox2.Text))
            {
                this.errorProvider1.SetError(textBox2, "输入数据必须为数字");
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
            else if (!ComHelp.ValidateInt(this.textBox8.Text))
            {
                this.errorProvider1.SetError(textBox8, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox9.Text))
            {
                this.errorProvider1.SetError(textBox9, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox10.Text))
            {
                this.errorProvider1.SetError(textBox10, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox11.Text))
            {
                this.errorProvider1.SetError(textBox11, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox12.Text))
            {
                this.errorProvider1.SetError(textBox12, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox13.Text))
            {
                this.errorProvider1.SetError(textBox13, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox14.Text))
            {
                this.errorProvider1.SetError(textBox14, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox15.Text))
            {
                this.errorProvider1.SetError(textBox15, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox16.Text))
            {
                this.errorProvider1.SetError(textBox16, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox17.Text))
            {
                this.errorProvider1.SetError(textBox17, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox18.Text))
            {
                this.errorProvider1.SetError(textBox18, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox19.Text))
            {
                this.errorProvider1.SetError(textBox19, "输入数据必须为数字");
                return false;
            }
            else if (!ComHelp.ValidateInt(this.textBox20.Text))
            {
                this.errorProvider1.SetError(textBox20, "输入数据必须为数字");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }
    }

    public class PigInfo
    {
        public string PigId { get; set; }
        public string PigType { get; set; }
        public bool IsDeath { get; set; }
    }
}
