
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSFcmData.Model.DataBase;
using CSFcmData.Control.FcmTcpClient;
using CSFcmData.Model.Socket;

namespace CSFcmData.Control.FcmDlgStudent
{
    public class ManageOrder
    {

        /// <summary>
        /// 执行学生查询订单端口
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <returns>查询结果</returns>
        public static ArrayList GetMessage(String userid)
        {
            /*创建Order类对象*/
            Order order = new Order();

            /*赋值操作*/
            order.ID_User = userid;

            Client.sendMessage("GetOrderMessage");
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendMessage("Student");
                msg = Client.rcvMessage();
                if(msg.Equals("Ready"))
                Client.sendObject(order);
                SocketDbRecord sdr = (SocketDbRecord)Client.rcvObject();
                return sdr.Record;
            }
            return null;
        }


        /// <summary>
        ///  执行删除单条Order功能
        /// </summary>
        /// <param name="user">用户ID</param>
        /// <param name="menu">菜单ID</param>
        /// <returns>返回结果</returns>
        public static bool DelOrder(String menu, String user)
        {
            //创建Order对象
            Order order = new Order();
            order.ID_Menu = menu;
            order.ID_User = user;

            //向服务器发送删除请求
            Client.sendMessage("DelOrd");
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendObject(order);//发送shopcar信息
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
