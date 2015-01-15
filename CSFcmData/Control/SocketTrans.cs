using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using CSFcmData.Model.Socket;
using CSFcmData.Control.FcmServerDowork;


////////////////////////////////////////////服务端操作///////////////////////////////////////////////////
namespace CSFcmData.Control.FcmTcpServer
{
    public class Server
    {
        private static TcpClient m_Client;
        private static Thread m_ClientThread;
        private static Thread m_SeverThread;
        private static TcpListener m_Listener;
        private static bool m_isStartup=false;


        /// <summary>
        /// 开启主监听线程
        /// </summary>
        public static void run()
        {
            m_SeverThread= new Thread(new ThreadStart(Server.start));
            m_SeverThread.Start();
        }



        /// <summary>
        /// 开启主监听线程的方法
        /// </summary>
        private static void start()
        {
            //获取本地的监听地址
            IPEndPoint host = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);

            //开启Socket监听
            m_Listener = new TcpListener(host);
            m_Listener.Start();
            m_isStartup = true;

            //处理到来的连接请求
            while (true)
            {
                m_Client = m_Listener.AcceptTcpClient();
                m_ClientThread = new Thread(new ThreadStart(Server.dowork));
                m_ClientThread.Start();
            }
        }



        /// <summary>
        ///为每个客户端服务的线程调用函数 
        /// </summary>
        private static void dowork()
        {
            //获取当前连接的客户端
            TcpClient Client = m_Client;

            //获取IO流
            NetworkStream ns = Client.GetStream();

            //获取客户端地址信息
            IPEndPoint ClientAddr =(IPEndPoint) Client.Client.RemoteEndPoint;
            String Address = ClientAddr.Address.ToString();

            //向客户端回应成功连接信息
            sendMessage(ns, "Connected");

            //开始接收数据
            SocketDoWork.SocketMsgDispatcher(Client, ns);
        }

        /// <summary>
        /// 向客户端发送信息的端口
        /// </summary>
        /// <param name="ns">客户端IO流的引用</param>
        /// <param name="Msg">发送信息的内容</param>
        public static void sendMessage(NetworkStream ns, String Msg)
        {
            Byte[] outBuffer = Encoding.ASCII.GetBytes(Msg);

            ns.Write(outBuffer, 0, outBuffer.Length);
        }

        /// <summary>
        /// 从客户端接收信息的端口
        /// </summary>
        /// <param name="Client">所接收的客户机的引用</param>
        /// <param name="ns">所接收的客户机对应的IO流</param>
        /// <returns>返回接收到的信息</returns>
        public static String rcvMessage(TcpClient Client,NetworkStream ns)
        {
            String Msg;
            Byte[] inbuffer = new Byte[1024];
            int readCount = 0;

            int Available = Client.Available;
            while (Client.Available == 0)
            {
                Available = Client.Available;
            }

            readCount = ns.Read(inbuffer, 0, inbuffer.Length);

            Msg = Encoding.ASCII.GetString(inbuffer, 0, readCount);
            return Msg;
        }


        /// <summary>
        /// 发送对象类型消息
        /// </summary>
        /// <param name="ns">网络IO流的引用</param>
        /// <param name="Msg">发送消息的基类对象</param>
        public static void sendObject(TcpClient client,NetworkStream ns ,SocketMsg Msg)
        {
            MemoryStream mStream = new MemoryStream();
            BinaryFormatter bformatter = new BinaryFormatter();  //二进制序列化类
            bformatter.Serialize(mStream, Msg); //将消息类转换为内存流
            mStream.Flush();

            long datalength = mStream.Length;
            sendMessage(ns, datalength.ToString());
            while (true)
            {
                if (rcvMessage(client, ns).Equals("start"))
                {
                    break;
                }
            }

            Byte[] buffer = new Byte[1024];
            mStream.Position = 0;  //将流的当前位置重新归0，否则Read方法将读取不到任何数据

            int readCount;

            while ((readCount = mStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                ns.Write(buffer, 0, readCount); //从内存中读取二进制流，并发送
            }
        }

        /// <summary>
        /// 接收对象类型的数据
        /// </summary>
        /// <returns>返回接收到的对象，如果为空则返回null</returns>
        public static SocketMsg rcvObject(TcpClient client,NetworkStream ns)
        {
            //定义接收字节缓存区
            byte[] buffer = new byte[1024];

            //定义内存流对象
            MemoryStream mStream = new MemoryStream();
            mStream.Position = 0;

            int datalength = int.Parse(rcvMessage(client,ns));
            sendMessage(ns, "start");

            //定义存储接收字节数量的变量
            int PerReceiveCount = 0;//定义每次接收的数据量
            int TolReceiveCount = 0;//定义总共接收的数据量
            //开始读取字节数据
            int Available = client.Available;
            while (client.Available == 0)
            {
                Available = client.Available;
            }

            while (true)
            {
                if (Available == 0 && TolReceiveCount == datalength)
                {
                    break;
                }


                PerReceiveCount = ns.Read(buffer, 0, buffer.Length);
                TolReceiveCount += PerReceiveCount;
                mStream.Write(buffer, 0, PerReceiveCount); //将接收到的数据写入内存流


                Available = client.Available;
            }

            mStream.Flush();
            mStream.Position = 0;

            //读取字节数据完毕，定义二进制序列化类准备反序列化
            BinaryFormatter bFormatter = new BinaryFormatter();


            if (mStream.Capacity > 0)
            {
                SocketMsg Msg = (SocketMsg)bFormatter.Deserialize(mStream);//将接收到的内存流反序列化为对象
                return Msg;
            }
            else
            {
                return null;
            }
        }

        public static void close()
        {
            if (m_isStartup)
            {
                m_Listener.Stop();
                m_SeverThread.Abort();
            }
        }
    }
}

///////////////////////////////////////////////////////客户端操作//////////////////////////////////////////

namespace CSFcmData.Control.FcmTcpClient
{
    public class Client
    {

        private static TcpClient client;
        private static String hostAddr;
        private static NetworkStream ns;
        public static bool isConnected;


        /// <summary>
        /// 连接主机的端口
        /// </summary>
        /// <returns>连接成功返回true，否则返回false</returns>
        public static bool init()
        {
            //绑定目标主机IP
            hostAddr = "127.0.0.1";
            IPEndPoint DestinationAddr = new IPEndPoint(IPAddress.Parse(hostAddr), 4000);

            //创建客户端连接
            client = new TcpClient();
            try
            {
                client.Connect(DestinationAddr);
                ns = client.GetStream();
            }catch(SocketException se)
            {
                isConnected = false;
                throw se;
            }

            isConnected = true;

            //接收服务器返回信息
            String Msg;
            Msg = rcvMessage();

            if (Msg.Equals("Connected"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 向服务器发送信息的端口
        /// </summary>
        /// <param name="Msg">发送信息的内容</param>
        public static void sendMessage(String Msg)
        {
            Byte[] outBuffer = Encoding.ASCII.GetBytes(Msg);

            ns.Write(outBuffer, 0, outBuffer.Length);
        }


        /// <summary>
        /// 从服务器接收信息的端口
        /// </summary>
        /// <returns>返回所接收到的信息</returns>
        public static String rcvMessage()
        {
            String Msg;
            Byte[] inbuffer = new Byte[1024];
            int readCount = 0;

            int Available = client.Available;
            while (client.Available == 0)
            {
                Available = client.Available;
            }

            readCount = ns.Read(inbuffer, 0, inbuffer.Length);

            Msg = Encoding.ASCII.GetString(inbuffer, 0, readCount);
            return Msg;
        }

        /// <summary>
        /// 发送对象类型消息
        /// </summary>
        /// <param name="Msg">发送消息的基类对象</param>
        public static void sendObject(SocketMsg Msg)
        {
            MemoryStream mStream = new MemoryStream();
            BinaryFormatter bformatter = new BinaryFormatter();  //二进制序列化类
            bformatter.Serialize(mStream, Msg); //将消息类转换为内存流
            mStream.Flush();

            long datalength = mStream.Length;
            sendMessage(datalength.ToString());
            while (true)
            {
                if (rcvMessage().Equals("start"))
                {
                    break;
                }
            }

            Byte[] buffer = new Byte[1024];
            mStream.Position = 0;  //将流的当前位置重新归0，否则Read方法将读取不到任何数据

            int readCount;

            while ((readCount = mStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                ns.Write(buffer, 0, readCount); //从内存中读取二进制流，并发送
            }
        }

        /// <summary>
        /// 接收对象类型的数据
        /// </summary>
        /// <returns>返回接收到的对象，如果为空则返回null</returns>
        public static SocketMsg rcvObject()
        {
            //定义接收字节缓存区
            byte[] buffer = new byte[1024];

            //定义内存流对象
            MemoryStream mStream = new MemoryStream();
            mStream.Position = 0;

            int datalength = int.Parse(rcvMessage());
            sendMessage("start");

            //定义存储接收字节数量的变量
            int PerReceiveCount = 0;//定义每次接收的数据量
            int TolReceiveCount = 0;//定义总共接收的数据量
            //开始读取字节数据
            int Available = client.Available;
            while (client.Available == 0)
            {
                Available = client.Available;
            }

            while (true)
            {
                if (Available == 0 && TolReceiveCount == datalength)
                {
                    break;
                }


                PerReceiveCount = ns.Read(buffer, 0, buffer.Length);
                TolReceiveCount += PerReceiveCount;
                mStream.Write(buffer, 0, PerReceiveCount); //将接收到的数据写入内存流


                Available = client.Available;
            }

            mStream.Flush();
            mStream.Position = 0;

            //读取字节数据完毕，定义二进制序列化类准备反序列化
            BinaryFormatter bFormatter = new BinaryFormatter();


            if (mStream.Capacity > 0)
            {
                SocketMsg Msg = (SocketMsg)bFormatter.Deserialize(mStream);//将接收到的内存流反序列化为对象
                return Msg;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 关闭连接，释放资源
        /// </summary>
        public static void close()
        {
            if (isConnected)
            {
                sendMessage("Closed");
                isConnected = false;
            }
        }
    }
}