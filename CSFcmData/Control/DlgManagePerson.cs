using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSFcmData.Model.DataBase;
using CSFcmData.Control.FcmTcpClient;
using CSFcmData.Model.Socket;

namespace CSFcmData.Control.FcmDlgManager
{
    public class ManagePerson
    {

        /// <summary>
        /// 查询管理员个人信息
        /// </summary>
        /// <returns>管理员个人信息</returns>
        public static ArrayList GetMessage(String ID)
        {
            User user = new User();
            user.Role = "管理员";
            user.ID = ID;

            Client.sendMessage("GetMessage");

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
        /// 执行管理员信息修改功能
        /// </summary>
        /// <param name="id">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="role">角色</param>
        /// <param name="name">姓名</param>
        /// <param name="sex">性别</param>
        /// <param name="email">邮箱</param>
        /// <param name="mobile">电话号码</param>
        /// <param name="add">住址</param>
        /// <returns></returns>
        public static bool ChangeMessage(string id,string password,string role,string name,string sex,string email,string mobile,string add)
        {
            /*创建User类对象*/
            User user = new User();


            /*赋值*/
            user.ID = id;
            user.PassWord = password;
            user.Role = role;
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
