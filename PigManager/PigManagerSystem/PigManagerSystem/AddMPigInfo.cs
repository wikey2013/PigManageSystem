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
    public partial class AddMPigInfo : Form
    {
        public List<PigInfo> childPigList = new List<PigInfo>();
        ChildPigInfoFrom childForm = new ChildPigInfoFrom();
        public AddMPigInfo()
        {
            InitializeComponent();
            //this.Load += new EventHandler(AddMPigInfo_Load);
            childForm.SendEvent += new ChildPigInfoFrom.SendChildPigInfoHandler(childForm_SendEvent);
        }

       private  void childForm_SendEvent(List<PigInfo> pigList)
        {
            this.childPigList = pigList;
        }

        void AddMPigInfo_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            //string[] first = { "a", "b", "c" };
            //string[] second = { "1", "2", "3" };
            AddChildPigControl[] controlList = { new AddChildPigControl(), new AddChildPigControl(), new AddChildPigControl() };
            //item.SubItems.AddRange(first);
            //item.SubItems.AddRange(second);
            //listView1.Controls.AddRange(controlList);
        }

        private void AddMotherPigInfo()
        {
            try
            {
                int earId = Convert.ToInt32(txtBoxEarId.Text.Trim());//耳号
                string pigType = txtBoxType.Text.Trim();//品种
                DateTime pigBirthDay = Convert.ToDateTime(dpBirthTime.Text);//出生时间
                int pigDayAge = Convert.ToInt32(txtBoxDayAge.Text.Trim());//日龄
                int parity = 0;
                if (txtBoxfetusWeek.Text != "")
                {
                    parity = Convert.ToInt32(txtBoxfetusWeek.Text.Trim());//胎次
                }
                int boarPigId = 0;
                if (txtBoxBoar.Text != "")
                {
                    boarPigId = Convert.ToInt32(txtBoxBoar.Text.Trim());//与配公猪
                }
                DateTime exDateChildbirth = Convert.ToDateTime(dpExpectDate.Text);//预产期
                DateTime deliveryDate = Convert.ToDateTime(dpDelivery.Text);//分娩日期
                int deliveryWeekEnd = 0;
                if (txtDeliverWeek.Text != "")
                {
                    deliveryWeekEnd = Convert.ToInt32(txtDeliverWeek.Text);//分娩周次
                }
                int deliveryHouse = 0;
                if (txtBoxHouse.Text != "")
                {
                    deliveryHouse = Convert.ToInt32(txtBoxHouse.Text.Trim());//分娩所在栏舍
                }
                int deliveryPigCount = 0;
                if (txtBoxHousePigCount.Text != "")
                {
                    deliveryPigCount = Convert.ToInt32(txtBoxHousePigCount.Text);//
                }
                int fromMilkDay = 0;
                if (txtBoxFromMilk.Text != "")
                {
                    fromMilkDay = Convert.ToInt32(txtBoxFromMilk.Text.Trim());
                }
                int fromMilkWeek = 0;
                if (txtBoxFromMilkWeek.Text != "")
                {
                    fromMilkWeek = Convert.ToInt32(txtBoxFromMilkWeek.Text.Trim());
                }
                int nurseDayCount = 0;
                if (txtBoxNurseDay.Text != "")
                {
                    nurseDayCount = Convert.ToInt32(txtBoxNurseDay.Text);
                }
                int inHouseDate = 0;
                if (txtBoxHouseDay.Text != "")
                {
                    inHouseDate = Convert.ToInt32(txtBoxHouseDay.Text.Trim());
                }
                int inHouseWeek = 0;
                if (txtBoxHouseWeek.Text != "")
                {
                    inHouseWeek = Convert.ToInt32(txtBoxHouseWeek.Text.Trim());
                }
                int fromMilkLiveChCount = 0;
                if (txtBoxLivePig.Text != "")
                {
                    fromMilkLiveChCount = Convert.ToInt32(txtBoxLivePig.Text.Trim());
                }
                string pigWeakHistory = txtBoxWeakHistory.Text.Trim();
                DateTime pigWeedOutDay = Convert.ToDateTime(dpWeedOutday.Text);
                string weedOutReason = txtBoxweedReason.Text;
                string remark = txtBoxRemark.Text;
                int goodPig = 0;
                if (txtBoxGoodPigCount.Text != "")
                {
                    goodPig = Convert.ToInt32(txtBoxGoodPigCount.Text);
                }
                int weakPig = 0;
                if (txtBoxWeakPigCount.Text != "")
                {
                    weakPig = Convert.ToInt32(txtBoxWeakPigCount.Text.Trim());
                }
                int deathPig = 0;
                if (txtBoxDeathPigCount.Text != "")
                {
                    deathPig = Convert.ToInt32(txtBoxDeathPigCount.Text.Trim());
                }
                int mummyPigCount = 0;
                if (txtBoxMummyCount.Text != "")
                {
                    mummyPigCount = Convert.ToInt32(txtBoxMummyCount.Text.Trim());
                }
                int freakChPig = 0;
                if (txtBoxFreakCount.Text != "")
                {
                    freakChPig = Convert.ToInt32(txtBoxFreakCount.Text);
                }
                int livePig = 0;
                if (txtBoxLivePigCount.Text != "")
                {
                    livePig = Convert.ToInt32(txtBoxLivePigCount.Text);
                }

                int totalCount = livePig + goodPig + weakPig + mummyPigCount + deathPig + freakChPig;
                double livePigRate = 0;
                double goodPigRate = 0;
                double inHousePigRate = 0;
                double fromMilkPigRate = 0;
                if (totalCount != 0)
                {
                    livePigRate = livePig / totalCount;
                    goodPigRate = goodPig / totalCount;
                    inHousePigRate = deliveryPigCount / totalCount;//转保育舍日活仔成活率
                    fromMilkPigRate = fromMilkLiveChCount / totalCount;//离奶日活仔成活率
                }

                string sqlString = @"insert into monthPigRegister(m_pigId,m_pigType,m_pigBirthDay,m_pigDayAge,m_parity,
                                m_boarId,m_exDateChildbirth,m_deliveryDate,m_deliveryWeekEnd,
                                m_deliveryHouse,m_deliveryPigCount,m_liveChPigCount,m_goodChPigCount,
                                m_weakChPigCount,m_deathChPigCount,m_mummyChPigCount,m_freakChPigCount,
                                m_liveChPigRate,m_goodChPigRate,m_fromMilkDay,m_fromMilkWeek,m_nurseDayCount,
                                m_inHouseDate,m_inHouseWeek,m_fromMilkLiveChCount,m_fromMilkLiveChRate,
                                m_inHouseDateLiveChRate,m_pigWeakHistory,m_pigWeedOutDay,m_weedOutReason,m_remark) 
                                values('" + earId + "','" + pigType + "','" + pigBirthDay + "','" + pigDayAge + "','" + parity + "','" + boarPigId + "','" + exDateChildbirth + "','" + deliveryDate + "','" + deliveryWeekEnd + "','" + deliveryHouse + "','" + deliveryPigCount + "','" + totalCount + "','" + goodPig + "','" + weakPig + "','" + deathPig + "','" + mummyPigCount + "','" + freakChPig + "','" + livePigRate + "','" + goodPigRate + "','" + fromMilkDay + "','" + fromMilkWeek + "','" + nurseDayCount + "','" + inHouseDate + "','" + inHouseWeek + "','" + fromMilkLiveChCount + "','" + fromMilkPigRate + "','" + inHousePigRate + "','" + pigWeakHistory + "','" + pigWeedOutDay + "','" + weedOutReason + "','" + remark + "')";
                SqlHelper.ExecuteSql(sqlString);
                AddLittlePigInfo();
                MessageBox.Show("添加成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序出现了不可预计的错误" + ex, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 添加仔猪信息
        /// </summary>
        private void AddLittlePigInfo()
        {
            if (childPigList.Count > 0)
            {
                var pgiInfoList = childPigList.Where(t => t.PigId.Length != 0).ToList();
                int montherPigId = Convert.ToInt32(this.txtBoxEarId.Text.Trim());
                foreach (var item in pgiInfoList)
                {
                    string sqlStr = "insert into littleChildPig(lc_motherPigId,lc_pigId,lc_IsDeath,lc_pigType) values('" + montherPigId + "','" +Convert.ToInt32(item.PigId) + "'," +Convert.ToBoolean(item.IsDeath) + ",'" + item.PigType + "')";
                    SqlHelper.ExecuteSql(sqlStr);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                AddMotherPigInfo();
            }
        }

        private bool ValidateText()
        {
            if (txtBoxEarId.Text.Length==0)
            {
                this.errorProvider1.SetError(txtBoxEarId, "输入内容不能为空");
                return false;
            }
             if (txtBoxType.Text.Length==0)
            {
                this.errorProvider1.SetError(txtBoxType, "输入内容不能为空");
                return false;
            }
             if (txtBoxDayAge.Text.Length==0)
            {
                this.errorProvider1.SetError(txtBoxDayAge, "输入内容不能为空");
                return false;
            }
             if (!ComHelp.ValidateInt(this.txtBoxEarId.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxEarId,"输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxType.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxType, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(this.txtBoxDayAge.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxDayAge, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxfetusWeek.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxfetusWeek, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxFromMilk.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxFromMilk, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxBoar.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxBoar, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtDeliverWeek.Text.Trim()))
            {
                this.errorProvider1.SetError(txtDeliverWeek, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxHouseWeek.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxHouseWeek, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxFromMilkWeek.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxFromMilkWeek, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxNurseDay.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxNurseDay, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxHouseDay.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxHouseDay, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxWeakHistory.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxWeakHistory, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxLivePig.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxLivePig, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxHousePigCount.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxHousePigCount, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxGoodPigCount.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxGoodPigCount, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxWeakPigCount.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxWeakPigCount, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxDeathPigCount.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxDeathPigCount, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxMummyCount.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxMummyCount, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxFreakCount.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxFreakCount, "输入内容必须为数字");
                return false;
            }
             if (!ComHelp.ValidateInt(txtBoxLivePigCount.Text.Trim()))
            {
                this.errorProvider1.SetError(txtBoxLivePigCount, "输入内容必须为数字");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtBoxEarId_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxType_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxDayAge_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //添加仔猪信息
            if (childForm!=null)
            {
                childForm.ShowDialog();
            }
        }

        private void txtBoxfetusWeek_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxFromMilk_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxBoar_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtDeliverWeek_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxHouse_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxHouseWeek_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxFromMilkWeek_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxNurseDay_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxHouseDay_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxWeakHistory_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxLivePig_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxHousePigCount_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxGoodPigCount_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxWeakPigCount_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxDeathPigCount_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxMummyCount_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxFreakCount_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }

        private void txtBoxLivePigCount_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }



    }
}
