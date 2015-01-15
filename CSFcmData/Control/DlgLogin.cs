using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSFcmData.Model.DataBase;
using CSFcmData.Control.FcmTcpClient;
namespace CSFcmData.Control.FcmDlgLogin
{
    public class DlgLogin
    {
        /// <summary>
        /// 执行管理员身份登录验证
        /// </summary>
        /// <param name="id">端口所需用户名</param>
        /// <param name="pwd">端口所需密码</param>
        /// <returns>返回验证结果</returns>
        public static bool ManagerLogin(String id, String pwd)
        {
            /*创建User对象*/
            User user = new User();
            user.ID = id;
            user.PassWord = pwd;
            user.Role = "管理员";

            /*向服务器发送登录请求*/
            Client.sendMessage("Login");
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendObject(user);
            }
            String str = Client.rcvMessage();
            if (str.Equals("exist"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 学生身份登录验证
        /// </summary>
        /// <param name="id">端口所需用户名</param>
        /// <param name="pwd">端口所需密码</param>
        /// <returns>返回验证结果</returns>
        public static bool StudentLogin(String id, String pwd)
        {
            //创建User对象
            User user = new User();
            user.ID = id;
            user.PassWord = pwd;
            user.Role = "学生";

            /*向服务器发送登录请求*/
            Client.sendMessage("Login");
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendObject(user);
            }
            String str = Client.rcvMessage();
            if (str.Equals("exist"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 餐馆人员身份登录验证
        /// </summary>
        /// <param name="id">登录所需用户名</param>
        /// <param name="pwd">登录所需密码</param>
        /// <returns>返回验证结果</returns>
        public static bool RestaurantLogin(String id, String pwd)
        {
            /*创建User对象*/
            User user = new User();
            user.ID = id;
            user.PassWord = pwd;
            user.Role = "餐馆";
            /*向服务器发送登录请求*/
            Client.sendMessage("Login");
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendObject(user);
            }
            String str = Client.rcvMessage();
            if (str.Equals("exist"))
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
