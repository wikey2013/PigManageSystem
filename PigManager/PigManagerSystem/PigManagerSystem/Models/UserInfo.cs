using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigManagerSystem
{
    public class UserInfo
    {
        public UserInfo()
        {
        }
        public UserInfo(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
       
    }
}
