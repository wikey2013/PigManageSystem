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
    public partial class MDIParent1 : Form
    {
        private PigInfoForm pigInfoForm = null;
        private SellPigForm sellPigForm = null;
        private KuCunForm kuCunForm = null;
        private MoneyForm moneyForm = null;
        private MemberForm memberForm = null;
        private SystemSetingForm sysForm = null;
        private AboutSystem aboutSsytemForm = null;

        public MDIParent1()
        {
            InitializeComponent();
            this.Load += new EventHandler(MDIParent1_Load);
        }

       private void MDIParent1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.systemTime.Text = "dddddddddddddddd";
            this.UserNameToolStrip.Text = "Admin";
        }

        /// <summary>
        /// 种猪管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PigMenu_Click(object sender, EventArgs e)
        {
            if (pigInfoForm==null)
            {
                pigInfoForm = new PigInfoForm();
            }
            else
            {
                return;
            }
            pigInfoForm.MdiParent = this;
            pigInfoForm.Show();
        }

        /// <summary>
        /// 销售管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellMenu_Click(object sender, EventArgs e)
        {
            if (sellPigForm==null)
            {
                sellPigForm = new SellPigForm();
            }
            else
            {
                return;
            }
            sellPigForm.MdiParent = this;
            sellPigForm.Show();
        }

        /// <summary>
        /// 库存管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KucunMenu_Click(object sender, EventArgs e)
        {
            if (kuCunForm==null)
            {
                kuCunForm = new KuCunForm();
            }
            else
            {
                return;
            }
            kuCunForm.MdiParent = this;
            kuCunForm.Show();
        }

        /// <summary>
        /// 财务管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoneyMenu_Click(object sender, EventArgs e)
        {
            if (moneyForm==null)
            {
                moneyForm = new MoneyForm();
            }
            else
            {
                return;
            }
            moneyForm.MdiParent = this;
            moneyForm.Show();
        }

        /// <summary>
        /// 人员管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberMenu_Click(object sender, EventArgs e)
        {
            if (memberForm==null)
            {
                memberForm = new MemberForm();
            }
            else
            {
                return;
            }
            memberForm.MdiParent = this;
            memberForm.Show();
        }

        /// <summary>
        /// 系统管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemSetingMenuItem_Click(object sender, EventArgs e)
        {
            if (sysForm==null)
            {
                sysForm = new SystemSetingForm();
            }
            else
            {
                return;
            }
            sysForm.MdiParent = this;
            sysForm.Show();
        }

        /// <summary>
        /// 帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpMenu_Click(object sender, EventArgs e)
        {
            if (aboutSsytemForm==null)
            {
                aboutSsytemForm = new AboutSystem();
            }
            else
            {
                return;
            }
            aboutSsytemForm.MdiParent = this;
            aboutSsytemForm.Show();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        
    }
}
