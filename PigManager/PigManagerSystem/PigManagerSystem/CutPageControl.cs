using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigManagerSystem
{
    public delegate void PageChangedEventHandler(object sender, PagerArgs args);
    public partial class CutPageControl : UserControl
    {
        public event PageChangedEventHandler PageChanged;
        public CutPageControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当前所在的页面
        /// </summary>
        private int pageIndex = 1;

        public int PageIndex
        {
            get { return pageIndex; }
            set
            {
                pageIndex = value;
                this.lblPageIndex.Text = string.Format("第{0}页", pageIndex);
            }
        }
        /// <summary>
        /// 每页面显示记录的个数
        /// </summary>
        private int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set
            {
                pageSize = value;
                if (0 == value)
                    pageSize = 1;
            }
        }
        /// <summary>
        /// 页面的总数
        /// </summary>
        private int pageCount;

        public int PageCount
        {
            get { return pageCount; }
        }
        /// <summary>
        /// 数据记录的总数
        /// </summary>
        private int recordCount;

        public int RecordCount
        {
            get { return recordCount; }
            set { recordCount = value; }
        }
        private void OnPageChanged(PagerArgs args)
        {
            if (PageChanged != null)
                PageChanged(this, args);
        }
        public void Initialize(int recordCount)
        {
            this.recordCount = recordCount;
            this.pageCount = (this.recordCount % this.pageSize == 0) ? (this.recordCount / this.pageSize) : (this.recordCount / this.pageSize + 1);
            this.lblPageIndex.Text = string.Format("第{0}页", this.pageIndex);
            this.lblPageCount.Text = string.Format("共{0}页", this.pageCount);
        }
        private void RefreshPage(int index)
        {
            this.pageIndex = index;
            this.lblPageIndex.Text = string.Format("第{0}页", this.pageIndex);
            this.lblPageCount.Text = string.Format("共{0}页", this.pageCount);
            OnPageChanged(new PagerArgs(index));
        }

        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            RefreshPage(1);
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            if (this.pageIndex > 1)
                RefreshPage(this.pageIndex - 1);
            else
                RefreshPage(1);
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (this.pageIndex < this.pageCount)
                RefreshPage(this.pageIndex + 1);
            else
                RefreshPage(this.pageCount);
        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            RefreshPage(this.pageCount);
        }

        private void btnGo_Click_1(object sender, EventArgs e)
        {
            int gotoIndex;
            if (!int.TryParse(this.txtGoIndex.Text, out gotoIndex))
                gotoIndex = 1;
            if (gotoIndex < 1)
                gotoIndex = 1;
            if (gotoIndex > this.pageCount)
                gotoIndex = this.pageCount;
            RefreshPage(gotoIndex);
        }
    }

    public class PagerArgs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageIndex">当前页面的index</param>
        public PagerArgs(int pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        private int pageIndex = 1;

        public int PageIndex
        {
            get { return pageIndex; }
            set { pageIndex = value; }
        }
    }
}
