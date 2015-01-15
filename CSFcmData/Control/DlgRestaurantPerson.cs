using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using CSFcmData.Control.FcmTcpClient;
using CSFcmData.Model.DataBase;
using CSFcmData.Model.Socket;

namespace CSFcmData.Control.FcmDlgRestaurant
{
    public class ManagePerson
    {

        /// <summary>
        /// 执行餐馆人员个人信息查询
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <returns>查询结果</returns>
        public static ArrayList GetMessage(String userid)
        {
            /*创建User类对象*/
            User user = new User();

            /*选定学生身份*/
            user.ID = userid;
            user.Role = "餐馆";

            Client.sendMessage("GetMessage");//发送查询信息消息

            String msg = Client.rcvMessage();
            if (msg.Equals("Type"))
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

        /// <summary>
        /// 执行修改个人信息功能
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <returns>修改结果</returns>
        public static bool ChangeMessage(String id, String password, String role, String name, String sex, String email, String mobile, String add)
        {
            /*创建User类对象*/
            User user = new User();

            /*赋值*/
            user.ID = id;
            user.PassWord = password;
            user.Role = "餐馆";
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
