using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using CSFcmData.Model.Socket;
using CSFcmData.Control.FcmTcpServer;
using CSFcmData.Model.DataBase;
using CSFcmData.Control.FcmDataBase;
using CSFcmData.Control.FcmIBSwitch;


namespace CSFcmData.Control.FcmServerDowork
{
    public class SocketDoWork
    {
        public static void SocketMsgDispatcher(TcpClient client,NetworkStream ns)
        {
            String Msg;
            while (true)
            {
                Msg = Server.rcvMessage(client, ns);

                if (Msg.Equals("Closed"))
                {
                    Close(client ,ns );
                    break;
                }
                if (Msg.Equals("Login"))
                {
                    DoLogin(client, ns);
                }
                if (Msg.Equals("Reg"))
                {
                    DoReg(client, ns);
                }
                if (Msg.Equals("Check"))
                {
                    DoCheck(client,ns);
                }
                if (Msg.Equals("AddCarMessage"))
                {
                    DoAddCarMessage(client, ns);
                }
                if (Msg.Equals("GetCarMessage"))
                {
                    DoGetMessageCar(client, ns);
                }
                if (Msg.Equals("GetOrderMessage"))
                {
                    DoGetMessageOrder(client,ns);
                }
                if (Msg.Equals("Account"))
                {
                    DoAccount(client, ns);
                }
                if (Msg.Equals("GetMessage"))
                {
                    DoGetMessageUser(client,ns);
                }
                if (Msg.Equals("GetMenuMessage"))
                {
                    DoGetMessageMenu(client,ns);
                }
                if (Msg.Equals("Change"))
                {
                    DoChangeUser(client,ns);
                }
                if (Msg.Equals("Del"))
                {
                    DoDelUser(client, ns);
                }
                if (Msg.Equals("DelMenu"))
                {
                    DoDelMenu(client,ns);
                }
                if (Msg.Equals("Delshopcar"))
                {
                    DoDelMessage(client, ns);
                }
                if (Msg.Equals("DelOrd"))
                {
                    DoDelOrder(client, ns);
                }
                if (Msg.Equals("LoginOut"))
                {
                    DoLoginOut(client,ns);
                }
            }
        }

        private static void Close(TcpClient client ,NetworkStream ns)
        { 
            ns.Close();
            client.Close();
        }

        /// <summary>
        /// 执行登陆操作
        /// </summary>
        /// <param name="client">客户端引用</param>
        /// <param name="ns">客户端IO流引用</param>
        private static void DoLogin(TcpClient client,NetworkStream ns)
        {
            Server.sendMessage(ns,"Start");
            User user = (User)Server.rcvObject(client,ns);
            String SQL = "select * from [User] where ID = '" + user.ID + "'and [PassWord] = '" + user.PassWord + "'and Role = '" + user.Role +"'";
            ArrayList T = DbConnect.Query(SQL);
            if (T.Count == 0)
            {
                Server.sendMessage(ns,"notfound");
            }
            else
            {
                Server.sendMessage(ns,"exist");
            }

        }


        /// <summary>
        /// 执行注册界面
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoReg(TcpClient client, NetworkStream ns)
        {
            Server.sendMessage(ns,"Ready");
            String msg = Server.rcvMessage(client,ns);
            if (msg.Equals("User"))//学生，餐馆类人员注册
            {
                Server.sendMessage(ns,"Start");
                User user = (User)Server.rcvObject(client,ns);
                String SQL = "insert into [User] (ID,[PassWord],Role,Name,Sex,Email,MobilePhone,Address) values ('"
                    + user.ID + "','" + user.PassWord + "','" + user.Role + "','" + user.Name + "','" + user.Sex 
                    + "','" + user.Email + "','" + user.MobilePhone + "','" + user.Address + "')";
                DbConnect.Operate(SQL);
                Server.sendMessage(ns, "OK");
            }
            else//菜单注册
            {
                Server.sendMessage(ns, "Start");
                SocketImage simg = (SocketImage)Server.rcvObject(client, ns);
                Image img = IBSwitch.SocketImgToImg(simg);
                String path = ".\\Image\\";
                String filename = GetTimeStamp(DateTime.Now) + ".jpg";
                IBSwitch.SaveImgFromImage(img, path, filename);
                Server.sendMessage(ns, "YES");
                Menu menu = (Menu)Server.rcvObject(client, ns);
                menu.ImagePath = path + filename;
                
                String SQL = "insert into Menu (ID,Name,Type,Description,TotleScore,SoldNum,Price,Special,Status,ImagePath,[ID_Restaurant]) values ('" + menu.ID + "','" + menu.Name + "','" + menu.Type + "','" + menu.Description + "','" + menu.TotleScore + "','" + menu.SoldNum + "','" + menu.Price + "','" + menu.Special + "','" + menu.Status + "','" + menu.ImagePath + "','" + menu.ID_Restaurant + "')";
                DbConnect.Operate(SQL);
                Server.sendMessage(ns, "OK");
            }
        }

        /// <summary>
        /// 执行用户，菜单注册时的ID检验功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoCheck(TcpClient client, NetworkStream ns)
        {
            //ArrayList T = new ArrayList();
            Server.sendMessage(ns,"Ready");
            String msg = Server.rcvMessage(client, ns);
            if (msg.Equals("User"))//用户ID检验
            {
                Server.sendMessage(ns, "Start");
                User user = (User)Server.rcvObject(client, ns);
                String SQL = "select * from [User] where ID='" + user.ID + "'";
                
                ArrayList T = DbConnect.Query(SQL);
                if (T.Count == 0)
                {
                    Server.sendMessage(ns, "notfound");
                }
                else 
                {
                    Server.sendMessage(ns, "exist");
                }
            }
            else//菜单ID检验
            {
                Server.sendMessage(ns, "Start");
                Menu menu = (Menu)Server.rcvObject(client, ns);
                String SQL = "select * from Menu where ID='" + menu.ID + "'";
                ArrayList T = DbConnect.Query(SQL);
                if (T.Count == 0)
                {
                    Server.sendMessage(ns, "notfound");
                }
                else
                {
                    Server.sendMessage(ns,"exist");
                }
            }
        }


        /// <summary>
        /// 执行查询菜单功能
        /// </summary>
        /// <param name="client">客户端的应用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoGetMessageMenu(TcpClient client,NetworkStream ns)
        {
            Server.sendMessage(ns, "Ready");
            String msg = Server.rcvMessage(client,ns);
            
            //根据菜类型查找
            if (msg.Equals("Type"))
            {
                Server.sendMessage(ns, "Start");
                Menu menu = (Menu)Server.rcvObject(client,ns);


                String SQL = "select * from Menu where Type='" + menu.Type + "'";
                ArrayList result = DbConnect.Query(SQL);

                SocketDbRecord sdr = new SocketDbRecord();
                if (result.Count != 0)
                {
                    SocketMenu skm;
                    for (int index = 0; index < result.Count; index++)
                    {
                        skm = new SocketMenu();
                        skm.Menu = (Menu)result[index];
                        skm.Image = Image.FromFile(((Menu)result[index]).ImagePath);
                        sdr.Record.Add(skm);
                        sdr.Type = "SocketMenu";
                    }
                }
                Server.sendObject(client, ns, sdr);
            }

            //根据ID查找菜单的详情
            if (msg.Equals("ID"))
            {
                Server.sendMessage(ns, "Start");
                Menu menu = (Menu)Server.rcvObject(client, ns);


                String SQL = "select * from Menu where ID='" + menu.ID + "'";
                ArrayList result = DbConnect.Query(SQL);
                
                SocketMenu skm=new SocketMenu();
                if (result.Count != 0)
                {
                    skm.Menu = (Menu)result[0];
                    skm.Image = Image.FromFile(((Menu)result[0]).ImagePath);
                }
                Server.sendObject(client, ns, skm);
            }

            //查询所有菜品
            if (msg.Equals("All"))
            {
                SocketDbRecord sdr = new SocketDbRecord();
                Server.sendMessage(ns, "ReqireContidion");
                Menu mu = (Menu)Server.rcvObject(client, ns);
                String Sql = null;
                if (mu.ID.Equals("") && mu.Name.Equals(""))
                {
                    Sql = "select * from Menu ";
                }
                if (mu.ID != "" && mu.Name.Equals(""))
                {
                    Sql = "select * from Menu where ID='" + mu.ID + "'";
                }
                if (mu.Name != "" && mu.ID.Equals(""))
                {
                    Sql = "select * from Menu where Name='" + mu.Name + "'";
                }
                if (mu.ID != "" && mu.Name != "")
                {
                    Sql = "select * from Menu where ID='" + mu.ID + "' and Name='" + mu.Name + "'";
                }

                sdr.Record = DbConnect.Query(Sql);
                Server.sendObject(client, ns, sdr);
            }
        }


        /// <summary>
        /// 执行查询用户信息功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端的IO流的引用</param>
        private static void DoGetMessageUser(TcpClient client, NetworkStream ns)
        {
            SocketDbRecord sdr = new SocketDbRecord();
            sdr.Type = "User";
            
            String Sql = null;

            Server.sendMessage(ns, "Type");
            String msg=Server.rcvMessage(client, ns);

            if(msg.Equals("Person"))//某类人查询个人信息
            {
                Server.sendMessage(ns,"Ready");
                User user = (User)Server.rcvObject(client,ns);

                Sql = "select * from [User] where ID='" + user.ID + "'and Role = '"+user.Role+"'";

                sdr.Record = DbConnect.Query(Sql);
                Server.sendObject(client,ns,sdr);

            }

            if (msg.Equals("All"))//管理员查询某类人员的所有人信息
            {
                Server.sendMessage(ns, "Ready");
                User user = (User)Server.rcvObject(client, ns);


                Sql = "select * from [User] where Role='" + user.Role + "'";


                sdr.Record=DbConnect.Query(Sql);
                Server.sendObject(client, ns, sdr);
            }
            if (msg.Equals("Conditional"))//管理员按条件查询某类人员中符合条件的人员信息
            {
                Server.sendMessage(ns, "Ready");
                User user = (User)Server.rcvObject(client, ns);

                /*所有条件全空*/
                if (user.ID.Equals("") && user.Name.Equals("") && user.Sex.Equals(""))
                {
                    Sql = "select * from [User] where Role='" + user.Role + "'";
                }

                /*有一个条件的情况*/
                if (!user.ID.Equals("") && user.Name.Equals("") && user.Sex.Equals(""))
                {
                    Sql = "select * from [User] where Role='" + user.Role + "' and ID='" +user.ID+ "'";
                }
                if (user.ID.Equals("") && !user.Name.Equals("") && user.Sex.Equals(""))
                {
                    Sql = "select * from [User] where Role='" + user.Role + "' and Name='" + user.Name + "'";
                }
                if (user.ID.Equals("") && user.Name.Equals("") && !user.Sex.Equals(""))
                {
                    Sql = "select * from [User] where Role='" + user.Role + "' and Sex='" + user.Sex + "'";
                }

                /*有两个条件的情况*/
                if (!user.ID.Equals("") && !user.Name.Equals("") && user.Sex.Equals(""))
                {
                    Sql = "select * from [User] where Role='" + user.Role + "' and ID='" + user.ID + "' and Name='"+user.Name+"'";
                }
                if (!user.ID.Equals("") && user.Name.Equals("") && !user.Sex.Equals(""))
                {
                    Sql = "select * from [User] where Role='" + user.Role + "' and ID='" + user.ID + "' and Sex='" + user.Sex + "'";
                }
                if (user.ID.Equals("") && !user.Name.Equals("") && !user.Sex.Equals(""))
                {
                    Sql = "select * from [User] where Role='" + user.Role + "' and Name='" + user.Name + "' and Sex='" + user.Sex + "'";
                }

                /*有三个条件的情况*/
                if (!user.ID.Equals("") && !user.Name.Equals("") && !user.Sex.Equals(""))
                {
                    Sql = "select * from [User] where Role='" + user.Role + "' and ID='" + user.ID + "' and Name='" + user.Name + "' and Sex='"+user.Sex+"'";
                }


                sdr.Record = DbConnect.Query(Sql);
                Server.sendObject(client, ns, sdr);
            }
        }


        /// <summary>
        /// 执行修改用户信息功能
        /// </summary>
        /// <param name="client">客户端引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoChangeUser(TcpClient client,NetworkStream ns)
        {
            Server.sendMessage(ns,"Ready");
            User user = (User)Server.rcvObject(client,ns);
            String SQL = "update [User] set [PassWord] = '" + user.PassWord + "',Name = '" + user.Name + "',Sex = '" + user.Sex + "',Email = '"
                + user.Email + "',MobilePhone = '" + user.MobilePhone + "',Address = '"
                + user.Address + "' where ID = '" + user.ID + "'and Role = '"+user.Role+"'";
            DbConnect.Operate(SQL);
            Server.sendMessage(ns,"OK");
        }


        /// <summary>
        /// 执行删除用户功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoDelUser(TcpClient client, NetworkStream ns)
        {
            Server.sendMessage(ns, "Start");
            User user = (User)Server.rcvObject(client, ns);
            String SQL = "delete from [User] where ID='" + user.ID + "'and Role='" + user.Role + "'";
            DbConnect.Operate(SQL);
            Server.sendMessage(ns, "OK");
        }

        /// <summary>
        /// 执行删除菜单功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoDelMenu(TcpClient client, NetworkStream ns)
        {
            Server.sendMessage(ns, "Start");
            Menu menu = (Menu)Server.rcvObject(client,ns);
            String SQL = "select * from Menu where ID='" + menu.ID + "'";
            ArrayList al = DbConnect.Query(SQL);
            if (al.Count == 0)
            {
                Server.sendMessage(ns, "NO");
            }
            else 
            {
                //判断文件是否被其他线程使用
                bool isInUse = true;
                String msg;
                while (isInUse)
                {
                    try
                    {
                        File.Delete(((Menu)al[0]).ImagePath);
                        isInUse = false;
                    }
                    catch (IOException e)
                    {
                        msg = e.ToString();
                        isInUse = true;
                    }
                }

            }
            SQL = "delete from Menu where ID='" + menu.ID + "'";
            DbConnect.Operate(SQL);
            Server.sendMessage(ns, "OK");
        }


        /// <summary>
        /// 执行查询购物车信息功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoGetMessageCar(TcpClient client, NetworkStream ns)
        {
            Server.sendMessage(ns, "Start");
            SocketDbRecord sdr = new SocketDbRecord();
            ShopCar shopcar = (ShopCar)Server.rcvObject(client, ns);

            String SQL = "select * from ShopCar where ID_User='" + shopcar.ID_User + "'";

            sdr.Record = DbConnect.Query(SQL);
            Server.sendObject(client, ns, sdr);
        }



        /// <summary>
        /// 执行添加购物功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoAddCarMessage(TcpClient client, NetworkStream ns)
        {
            Server.sendMessage(ns, "Start");
            ShopCar shopcar = (ShopCar)Server.rcvObject(client, ns);
            String SQL = "select * from ShopCar where ID_User='" + shopcar.ID_User + "'and ID_Menu = '" + shopcar.ID_Menu + "'";
            SocketDbRecord sdr = new SocketDbRecord();
            sdr.Record = DbConnect.Query(SQL);
            if (sdr.Record.Count != 0)
            {
                String num = (int.Parse(((ShopCar)sdr.Record[0]).Num) + int.Parse(shopcar.Num)).ToString();
                String totalvalue = ((int.Parse(((ShopCar)sdr.Record[0]).Num) + int.Parse(shopcar.Num)) * float.Parse(shopcar.Price)).ToString();
                SQL = "update ShopCar set Num='" + num + "',Totle='" + totalvalue + "' where [ID_User]='" + shopcar.ID_User + "' and [ID_Menu]='" + shopcar.ID_Menu + "'";
            }
            else
            {
                SQL = "select * from Menu where ID='" + shopcar.ID_Menu + "'";

                ArrayList list = DbConnect.Query(SQL);
                shopcar.Name_Menu = ((Menu)list[0]).Name;

                SQL = "select * from [User] where ID='" + shopcar.ID_User + "'";
                list.Clear();
                list = DbConnect.Query(SQL);
                shopcar.Name_User = ((User)list[0]).Name;

                shopcar.Totle = (float.Parse(shopcar.Price) * int.Parse(shopcar.Num)).ToString();
                SQL = "insert into ShopCar ([ID_User],[Name_User],[ID_Menu],[Name_Menu],Num,Price,Totle) values ('" + shopcar.ID_User + "','" + shopcar.Name_User + "','" + shopcar.ID_Menu + "','" + shopcar.Name_Menu + "','" + shopcar.Num + "','" + shopcar.Price + "','" + shopcar.Totle + "')";
            }
            DbConnect.Operate(SQL);
            Server.sendMessage(ns, "OK");
        }

        /// <summary>
        /// 执行删除购物车功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoDelMessage(TcpClient client, NetworkStream ns)
        {
            Server.sendMessage(ns, "Start");
            ShopCar shopcar = (ShopCar)Server.rcvObject(client, ns);
            String SQL = "delete from [ShopCar] where ID_User='" + shopcar.ID_User + "'and ID_Menu='" + shopcar.ID_Menu + "'";
            DbConnect.Operate(SQL);
            Server.sendMessage(ns, "OK");
        }

        /// <summary>
        /// 执行结算功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoAccount(TcpClient client, NetworkStream ns)
        {
            SocketDbRecord sdr = new SocketDbRecord();
            String SQL = null;
            Server.sendMessage(ns, "Type");
            String msg = Server.rcvMessage(client, ns);
            if (msg.Equals("One"))//执行单件商品结算
            {
                Server.sendMessage(ns, "Ready");
                ShopCar shopcar = (ShopCar)Server.rcvObject(client, ns);
                SQL = "select * from ShopCar where ID_User='" + shopcar.ID_User + "'and ID_Menu = '" + shopcar.ID_Menu + "'";
                sdr.Record = DbConnect.Query(SQL);

                /*创建Order类对象*/
                Order order = new Order();

                /*赋值*/
                order.ID_User = ((ShopCar)sdr.Record[0]).ID_User;
                order.Name_User = ((ShopCar)sdr.Record[0]).Name_User;
                order.ID_Menu = ((ShopCar)sdr.Record[0]).ID_Menu;
                order.Name_Menu = ((ShopCar)sdr.Record[0]).Name_Menu;
                order.Num = ((ShopCar)sdr.Record[0]).Num;
                order.Price = ((ShopCar)sdr.Record[0]).Price;
                order.Totle = ((ShopCar)sdr.Record[0]).Totle;
                order.ID = "DB" + GetTimeStamp(DateTime.Now).ToString();

                /*删除购物车信息*/
                SQL = "delete from ShopCar where ID_User='" + shopcar.ID_User + "'and ID_Menu='" + shopcar.ID_Menu + "'";
                DbConnect.Operate(SQL);

                /*插入订单信息*/
                OleDbParameter data = new OleDbParameter();//获取当前系统时间
                data.OleDbType = OleDbType.DBDate;
                data.Value = DateTime.Now.ToString("yyyy/MM/dd");
                SQL = "insert into [Order] (ID,[ID_Menu],[Name_Menu],[ID_User],[Name_User],[Time],Num,Price,Totle) values ('" + order.ID + "','" + order.ID_Menu + "','"+order.Name_Menu+"','" + order.ID_User + "','"+order.Name_User+"','" + data.Value + "','" + order.Num + "','" + order.Price + "','" + order.Totle + "')";
                DbConnect.Operate(SQL);
                Server.sendMessage(ns, "OK");
            }
        }

        /// <summary>
        /// 获取时间戳信息
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private static String GetTimeStamp(DateTime time)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan ts = time.Subtract(startTime);
            String timeStamp = ts.Ticks.ToString();
            timeStamp = timeStamp.Substring(0, timeStamp.Length - 7);
            return timeStamp;

        }
        /// <summary>
        /// 执行查询订单功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoGetMessageOrder(TcpClient client, NetworkStream ns)
        {
            Server.sendMessage(ns, "Start");
            String msg = Server.rcvMessage(client, ns);
            SocketDbRecord sdr = new SocketDbRecord();
            if (msg.Equals("Student"))//学生查询个人订单信息
            {
                Server.sendMessage(ns,"Ready");
                Order order = (Order)Server.rcvObject(client, ns);

                String SQL = "select * from [Order] where [ID_User]='" + order.ID_User + "'";

                sdr.Record = DbConnect.Query(SQL);
            }
            if (msg.Equals("Restaurant"))//餐馆人员查询所有订单信息
            {

                String Sql = "select * from [Order] ";


                sdr.Record = DbConnect.Query(Sql);
            }
            Server.sendObject(client, ns, sdr);
        }


        /// <summary>
        /// 执行删除订单功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoDelOrder(TcpClient client, NetworkStream ns)
        {
            Server.sendMessage(ns, "Start");
            Order order = (Order)Server.rcvObject(client, ns);
            String SQL = "delete from [Order] where [ID_Menu]='" + order.ID_Menu + "'and [ID_User]='" + order.ID_User + "'";
            DbConnect.Operate(SQL);
            Server.sendMessage(ns, "OK");
        }


        /// <summary>
        /// 执行退出登录功能
        /// </summary>
        /// <param name="client">客户端的引用</param>
        /// <param name="ns">客户端IO流的引用</param>
        private static void DoLoginOut(TcpClient client,NetworkStream ns)
        {
            Server.sendMessage(ns,"Start");
            User user = (User)Server.rcvObject(client,ns);
            OleDbParameter data = new OleDbParameter();
            data.OleDbType = OleDbType.DBDate;
            data.Value = DateTime.Now.ToString("yyyy/MM/dd");
            String SQL = "update [User] set LastLogin = '" + data.Value + "' where ID = '" + user.ID + "'";
            DbConnect.Operate(SQL);
            Server.sendMessage(ns,"OK");
        }
    }
}
