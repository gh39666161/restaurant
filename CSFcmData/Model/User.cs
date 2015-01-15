using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSFcmData.Model.Socket;

namespace CSFcmData.Model.DataBase
{
    [Serializable]
    public class User : SocketMsg
    {
        private string iD;
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string mobilePhone;

        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string lastLogin;

        public string LastLogin
        {
            get { return lastLogin; }
            set { lastLogin = value; }
        }
    }
}
