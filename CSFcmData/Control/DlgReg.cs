using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CSFcmData.Model.DataBase;
using CSFcmData.Control.FcmTcpClient;
using CSFcmData.Control.FcmIBSwitch;
using CSFcmData.Model.Socket;

namespace CSFcmData.Control.FcmDlgRegister
{
    public class DlgRegisterDo
    {


        /// <summary>
        /// 注册菜单端口
        /// </summary>
        /// <param name="id">菜品ID</param>
        /// <param name="name">菜名</param>
        /// <param name="type">菜品类型</param>
        /// <param name="des">菜品描述</param>
        /// <param name="ts">菜品总价</param>
        /// <param name="snum">售出数量</param>
        /// <param name="price">价格</param>
        /// <param name="special">是否是特色菜</param>
        /// <param name="status">是否可售出</param>
        /// <param name="impath">图片路径</param>
        /// <param name="id_res">餐馆ID</param>
        /// <returns>返回注册结果</returns>
        public static bool MenuReg(String id, String name, String type, String des, String ts, String snum, String price, String special, String status, String impath, String id_res)
        {

            /*创建SocketImage对象，并转化成网络图片类型*/
            SocketImage simg = IBSwitch.ImgToSocketImg(Image.FromFile(impath));
           
            /*创建Menu对象*/
            Menu menu = new Menu();

            /*进行赋值操作*/
            menu.ID = id;
            menu.Name = name;
            menu.Type = type;
            menu.Description = des;
            menu.TotleScore = ts;
            menu.SoldNum = snum;
            menu.Price = price;
            menu.Special = special;
            menu.Status = status;
            menu.ImagePath = impath;
            menu.ID_Restaurant = id_res;

            /*向服务器发送注册请求*/
            Client.sendMessage("Reg");
            String msg = Client.rcvMessage();
            if (msg.Equals("Ready"))
            {
                Client.sendMessage("Menu");//向服务器发送Menu类注册请求
            }
            String re = Client.rcvMessage();
            if(re.Equals("Start"))
            {
                Client.sendObject(simg);//发送图片（网络图片类型）
                String s = Client.rcvMessage();
                if (s.Equals("YES"))
                {
                    Client.sendObject(menu);//发送菜单注册信息
                }
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


        /// <summary>
        /// 用户注册端口
        /// </summary>
        /// <param name="sid">用户名</param>
        /// <param name="spwd">密码</param>
        /// <param name="srole">用户类型</param>
        /// <param name="sname">姓名</param>
        /// <param name="sex">性别</param>
        /// <param name="smail">邮箱</param>
        /// <param name="smobile">电话号码</param>
        /// <param name="sadd">住址</param>
        /// <returns>返回注册结果</returns>
        public static bool UserReg(String sid, String spwd, String srole, String sname, String sex, String smail, String smobile, String sadd)
        {
            /*创建User对象*/
            User user = new User();
            user.ID = sid;
            user.PassWord = spwd;
            user.Role = srole;
            user.Name = sname;
            user.Sex = sex;
            user.Email = smail;
            user.MobilePhone = smobile;
            user.Address = sadd;


            /*向服务器发送注册请求*/
            Client.sendMessage("Reg");
            String msg = Client.rcvMessage();
            if (msg.Equals("Ready"))
            {
                Client.sendMessage("User");//向服务器发送User类注册请求
            }
            String re = Client.rcvMessage();
            if (re.Equals("Start"))
            {
                Client.sendObject(user);//发送用户注册信息
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

        /// <summary>
        /// 执行用户注册时的ID存在性检验
        /// </summary>
        /// <param name="sid">注册时的用户ID</param>
        /// <returns>返回查找结果</returns>
        public static Boolean CheckUserID(String sid)
        {
            /*创建User类对象*/
            User user = new User();


            /*赋值,传入用户ID*/
            user.ID = sid;

            /*向服务器发送用户ID检验请求*/
            Client.sendMessage("Check");
            String msg = Client.rcvMessage();
            if(msg.Equals("Ready"))
            {
                Client.sendMessage("User");
            }
            String re = Client.rcvMessage();
            if(re.Equals("Start"))
            {
                Client.sendObject(user);//发送Id
            }
            String str = Client.rcvMessage();
            if (str.Equals("notfound"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// 检查菜单ID是否重复
        /// </summary>
        /// <param name="mid">菜单ID</param>
        /// <returns>查询结果</returns>
        public static Boolean CheckMenuID(String mid)
        {
            /*创建Menu类对象*/
            Menu menu = new Menu();


            /*赋值,传入菜单ID*/
            menu.ID = mid;

            /*向服务器发送用户ID检验请求*/
            Client.sendMessage("Check");
            String msg = Client.rcvMessage();
            if(msg.Equals("Ready"))
            {
                Client.sendMessage("Menu");
            }
            String re = Client.rcvMessage();
            if(re.Equals("Start"))
            {
                Client.sendObject(menu);//发送Id
            }
            String str = Client.rcvMessage();
            if (str.Equals("notfound"))
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
