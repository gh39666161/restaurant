using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSFcmData.Model.DataBase;
using CSFcmData.Control.FcmTcpClient;

namespace CSFcmData.Control.FcmLoginOut
{
    public class Loginout
    {
        public static Boolean LoginOut(String id)
        {
            /*创建User对象*/
            User user = new User();

            /*赋值操作*/
            user.ID = id;

            /*向服务器发送注册请求*/
            Client.sendMessage("LoginOut");
            String msg = Client.rcvMessage();
            if(msg.Equals("Start"))
            {
                Client.sendObject(user);
            }
            String str = Client.rcvMessage();
            if (str.Equals("OK"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
