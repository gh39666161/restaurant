using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using CSFcmData.Model.Socket;
using CSFcmData.Model.DataBase;
using CSFcmData.Control.FcmTcpClient;

namespace CSFcmData.Control.FcmDlgStudent
{
    public class ManageMenu
    {

        /// <summary>
        ///执行根据菜ID查找 
        /// </summary>
        /// <param name="id">菜ID</param>
        /// <returns>查询结果</returns>
        public static ArrayList GetMessageByType(String type)
        {
            /*创建Menu类信息*/
            Menu menu = new Menu();

            /*赋值操作*/
            menu.Type = type;

            Client.sendMessage("GetMenuMessage");

            String msg = Client.rcvMessage();
            if (msg.Equals("Ready"))
            {
                //按类型查看菜单信息
                Client.sendMessage("Type");
                msg = Client.rcvMessage();
                if (msg.Equals("Start"))
                {
                    Client.sendObject(menu);
                    SocketDbRecord sdr = (SocketDbRecord)Client.rcvObject();
                    return sdr.Record;
                }
            }
            return null;
        }
        public static SocketMenu GetMessageByID(String id)
        {
            /*创建Menu类信息*/
            Menu menu = new Menu();

            /*赋值操作*/
            menu.ID = id;

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
    }
}
