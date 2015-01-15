using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSFcmData.Model.Socket;

namespace CSFcmData.Model.DataBase
{
    [Serializable]
    public class ShopCar : SocketMsg
    {
        private String iD_User;
        public String ID_User
        {
            get { return iD_User; }
            set { iD_User = value; }
        }

        private String name_User;
        public String Name_User
        {
            get { return name_User; }
            set { name_User = value; }
        }

        private String iD_Menu;
        public String ID_Menu
        {
            get { return iD_Menu; }
            set { iD_Menu = value; }
        }

        private String name_Menu;
        public String Name_Menu
        {
            get { return name_Menu; }
            set { name_Menu = value; }
        }

        private String num;
        public String Num
        {
            get { return num; }
            set { num = value; }
        }

        private String price;
        public String Price
        {
            get { return price; }
            set { price = value; }
        }

        private String totle;
        public String Totle
        {
            get { return totle; }
            set { totle = value; }
        }
    }
}
