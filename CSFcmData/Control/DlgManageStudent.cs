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
    public class ManageStudent
    {

        /// <summary>
        /// 查询所有的学生信息
        /// </summary>
        /// <returns>学生信息</returns>
        public static ArrayList GetMessage()
        {
            User user = new User();
            user.Role = "学生";

            Client.sendMessage("GetMessage");

            String msg = Client.rcvMessage();
            if (msg.Equals("Type"))
            {
                Client.sendMessage("All");

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
        /// 查询对应的学生信息
        /// </summary>
        /// <param name="ID">账号</param>
        /// <param name="Name">姓名</param>
        /// <param name="Sex">性别</param>
        /// <returns>学生信息</returns>
        public static ArrayList GetMessage(String ID, String Name, String Sex)
        {
            User user = new User();
            user.Role = "学生";
            user.ID = ID;
            user.Name = Name;
            user.Sex = Sex;

            Client.sendMessage("GetMessage");

            String msg = Client.rcvMessage();
            if (msg.Equals("Type"))
            {
                Client.sendMessage("Conditional");

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
        /// 执行学生信息修改功能
        /// </summary>
        /// <param name="id">要被删除的学生的用户名</param>
        /// <param name="password">密码</param>
        /// <param name="role">身份</param>
        /// <param name="name">姓名</param>
        /// <param name="sex">性别</param>
        /// <param name="email">邮箱</param>
        /// <param name="mobile">电话号码</param>
        /// <param name="add">住址</param>
        /// <returns></returns>
        public static bool ChangeMessage(String id, String password, String name, String sex, String email, String mobile, String add)
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
                Client.sendObject(user);//发送学生信息
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



        /// <summary>
        /// 执行学生删除功能
        /// </summary>
        /// <param name="Id">用户ID</param>
        /// <param name="role">用户类型</param>
        /// <returns>返回结果</returns>
        public static bool DelMessage(String ID)
        {

            //创建User对象
            User user = new User();
            user.ID = ID;
            user.Role = "学生";

            //向服务器发送请求
            Client.sendMessage("Del");
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendObject(user);
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
