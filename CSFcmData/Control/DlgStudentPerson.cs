using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using CSFcmData.Model.DataBase;
using CSFcmData.Model.Socket;
using CSFcmData.Control.FcmTcpClient;

namespace CSFcmData.Control.FcmDlgStudent
{
    public class ManagePerson
    {
        /// <summary>
        /// 获取个人信息
        /// </summary>
        /// <param name="id">所查信息id</param>
        /// <returns>查询信息</returns>
        public static ArrayList GetMessage(String id)
        {
            /*创建User类对象*/
            User user = new User();

            /*选定学生身份*/
            user.ID = id;
            user.Role = "学生";

            Client.sendMessage("GetMessage");//发送查询信息消息

            String msg = Client.rcvMessage();
            if(msg.Equals("Type"))
            {
                Client.sendMessage("Person");

                msg = Client.rcvMessage();
                if (msg.Equals("Ready"))
                {
                    Client.sendObject(user);
                    SocketDbRecord sdr = (SocketDbRecord)Client.rcvObject();
                    return sdr.Record;
                }
            }
            return null;
        }

        public static bool ChangeMessage(String id,String password,String role,String name,String sex,String email,String mobile,String add)
        {
            /*创建User类对象*/
            User user = new User();

            /*赋值*/
            user.ID = id;
            user.PassWord = password;
            user.Role = "学生";
            user.Name = name;
            user.Sex = sex;
            user.Email = email;
            user.MobilePhone = mobile;
            user.Address = add;


            Client.sendMessage("Change");
            string msg = Client.rcvMessage();
            if (msg.Equals("Ready"))
            {
                Client.sendObject(user);//发送User类对象
            }
            string str = Client.rcvMessage();
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
