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
    public class ManageShopCar
    {
        /// <summary>
        /// 查找购物车信息端口
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <returns>查找结果</returns>
        public static ArrayList GetMessage(String userid)
        {
            /*创建ShopCar类对象*/
            ShopCar shopcar = new ShopCar();

            /*赋值操作*/
            shopcar.ID_User = userid;

            Client.sendMessage("GetCarMessage");
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendObject(shopcar);
                SocketDbRecord sdr = (SocketDbRecord)Client.rcvObject();
                return sdr.Record;
            }
            return null;
        }

        /// <summary>
        /// 执行添加购物功能
        /// </summary>
        /// <param name="num">添加数量</param>
        /// <param name="userid">用户ID</param>
        /// <param name="menuid">菜品ID</param>
        /// <returns>添加结果</returns>
        public static bool AddMessage(String num, String userid, String menuid, String price)
        {
            /*创建ShopCar类对象*/
            ShopCar shopcar = new ShopCar();

            /*赋值*/
            shopcar.Num = num;
            shopcar.ID_User = userid;
            shopcar.ID_Menu = menuid;
            shopcar.Price = price;

            Client.sendMessage("AddCarMessage");//发送添加购物消息
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendObject(shopcar);
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
        /// 执行删除单条ShopCar功能
        /// </summary>
        /// <param name="user">用户ID</param>
        /// <param name="menu">菜单ID</param>
        /// <returns>返回结果</returns>
        public static bool DelMessage(String user, String menu)
        {
            //创建ShopCar对象
            ShopCar shopcar = new ShopCar();
            shopcar.ID_User = user;
            shopcar.ID_Menu = menu;

            //向服务器发送删除请求
            Client.sendMessage("Delshopcar");
            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendObject(shopcar);//发送shopcar信息
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
        /// 执行结算单件商品
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <param name="menuid">菜品ID</param>
        /// <returns>结算结果</returns>
        public static bool AccountOne(String userid, String menuid)
        {
            /*创建ShopCar类对象*/
            ShopCar shopcar = new ShopCar();

            /*赋值*/
            shopcar.ID_User = userid;
            shopcar.ID_Menu = menuid;

            Client.sendMessage("Account");
            String msg = Client.rcvMessage();
            if (msg.Equals("Type"))
            {
                Client.sendMessage("One");//发送结算单件物品的消息
            }
            String re = Client.rcvMessage();
            if (re.Equals("Ready"))
            {
                Client.sendObject(shopcar);
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
