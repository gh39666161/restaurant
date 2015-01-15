using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using CSFcmData.Model.DataBase;
using CSFcmData.Control.FcmTcpClient;
using CSFcmData.Model.Socket;

namespace CSFcmData.Control.FcmDlgRestaurant
{
    public class ManageMenu
    {

        /// <summary>
        /// 查询所有菜单信息（无图片）
        /// </summary>
        /// <returns>查询结果</returns>
        public static ArrayList GetMessageList(String id, String name)
        {
            Client.sendMessage("GetMenuMessage");

            String msg = Client.rcvMessage();
            if (msg.Equals("Ready"))
            {
                Client.sendMessage("All");
                msg = Client.rcvMessage();
                if (msg.Equals("ReqireContidion"))
                {
                    Menu mu = new Menu();
                    mu.ID = id;
                    mu.Name = name;
                    Client.sendObject(mu);
                    SocketDbRecord sdr = (SocketDbRecord)Client.rcvObject();
                    return sdr.Record;
                }
            }
            return null;
        }

        /// <summary>
        /// 查询单间菜品（包括图片）
        /// </summary>
        /// <param name="menuid">菜品ID</param>
        /// <returns>查询信息</returns>
        public static SocketMenu GetMessageOne(String menuid)
        {
            /*创建Menu类信息*/
            Menu menu = new Menu();

            /*赋值操作*/
            menu.ID = menuid;

            Client.sendMessage("GetMenuMessage");

            String msg = Client.rcvMessage();
            if (msg.Equals("Ready"))
            {
                //按ID菜单信息
                Client.sendMessage("ID");
                msg = Client.rcvMessage();
                if (msg.Equals("Start"))
                {
                    Client.sendObject(menu);
                    SocketMenu skm = (SocketMenu)Client.rcvObject();
                    return skm;
                }
            }
            return null;
        }

        /// <summary>
        /// 执行删除菜单信息
        /// </summary>
        /// <param name="menuid">菜品ID</param>
        /// <returns>删除结果</returns>
        public static bool DelMessage(String menuid)
        {
            /*创建Menu类对象*/
            Menu menu = new Menu();

            /*赋值操作*/
            menu.ID = menuid;

            /*向服务器发送删除菜单请求*/
            Client.sendMessage("DelMenu");
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendObject(menu);//发送menu信息
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
