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
    public partial class UserManagerForm : Form
    {
        //private List<UserInfo> events = null;
        public UserManagerForm()
        {
            InitializeComponent();
            InitData();
            //this.cutPager1.Initialize(events.Count);
            //Refresh(1);
        }

        public void InitData()
        {
            //events = new List<UserInfo>();
            string sqlString = "select * from UserLogin";
           var reader = SqlHelper.ExcuteQueryToDataTable(sqlString);
            //int id = 0;
            //while (reader.Read())
            //{
            //    UserInfo e = new UserInfo();
            //    e.Id = ++id;
            //    e.UserName = reader["userName"].ToString();
            //    e.PassWord = reader["userPwd"].ToString();
            //    events.Add(e);
            //}
           this.dataGridView1.DataSource = reader;

        }

        //public void Refresh(int pageIndex)
        //{
        //    List<UserInfo> temp = new List<UserInfo>();
        //    int startPos = (pageIndex - 1) * this.cutPager1.PageSize;
        //    int count = this.cutPager1.PageSize;
        //    if ((pageIndex - 1) * cutPager1.PageSize + cutPager1.PageSize > events.Count)
        //    {
        //        count = events.Count - startPos;
        //    }
        //    temp = events.GetRange(startPos, count);
        //    this.dataGridView1.DataSource = temp;
        //}

        private void cutPageControl1_PageChanged(object sender, PagerArgs args)
        {
            //Refresh(args.PageIndex);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlHelper.SetToExcel(this.dataGridView1);
        }


    }
}
