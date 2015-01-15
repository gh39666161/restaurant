using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using CSFcmData.Model.DataBase;
using CSFcmData.Model.Socket;
using CSFcmData.Control.FcmTcpClient;

namespace CSFcmData.Control.FcmDlgRestaurant
{
    public class ManageOrder
    {

        /// <summary>
        /// 执行餐馆人员查询所有订单信息功能
        /// </summary>
        /// <returns>订单信息</returns>
        public static ArrayList GetMessage()
        {
            Client.sendMessage("GetOrderMessage");

            String msg = Client.rcvMessage();
            if (msg.Equals("Start"))
            {
                Client.sendMessage("Restaurant");
                SocketDbRecord sdr = (SocketDbRecord)Client.rcvObject();
                return sdr.Record;
            }
            return null;
        }
    }
}
