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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string userName = this.userNametextBox.Text.Trim();
            string pwd = this.passWordtextBox.Text.Trim();
            var dataReader=SqlHelper.UserLogin(userName, pwd);
            if (dataReader!=null)
            {
                //MainForm mainForm = new MainForm();
                //mainForm.Show();
               // this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码为空", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
