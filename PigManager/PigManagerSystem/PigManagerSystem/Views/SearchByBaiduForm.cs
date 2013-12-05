using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigManagerSystem.Views
{
    public partial class SearchByBaiduForm : Form
    {
        public SearchByBaiduForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(SearchByBaiduForm_Load);
        }

        void SearchByBaiduForm_Load(object sender, EventArgs e)
        {
            //string baiduWeb = string.Format("www.baidu.com");
        }
    }
}
