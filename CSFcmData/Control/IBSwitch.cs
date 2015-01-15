using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using CSFcmData.Model.Socket;

namespace CSFcmData.Control.FcmIBSwitch
{
    /// <summary>
    /// 实现网络图片和本地图片类型互相转化
    /// </summary>
    public class IBSwitch
    {


        /// <summary>
        /// 从本地图片类型转换到网络图片类型
        /// </summary>
        /// <param name="imageIn">本地图片数据</param>
        /// <returns>网络图片类型的数据</returns>
        public static SocketImage ImgToSocketImg(System.Drawing.Image imageIn)
        {
            if (imageIn == null)
            {
                return null;
            }
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            SocketImage simg = new SocketImage(ms.Length);
            simg.ImageByte = ms.ToArray();
            simg.Height = imageIn.Size.Height;
            simg.Width = imageIn.Size.Width;
            simg.Type = "jpeg";
            simg.ImagePath=".//Image//";
            return simg;
        }

        /// <summary>
        /// 从网络图片类型转换到本地图片类型
        /// </summary>
        /// <param name="simg">网络图片类型</param>
        /// <returns>本地图片类型</returns>
        public static Image SocketImgToImg(SocketImage simg)
        {
            if (simg.ImageByte == null)
            {
                return null;  
            }
            MemoryStream ms = new MemoryStream(simg.ImageByte);  
            Image img = Image.FromStream(ms); 
            return img;
        }
        /// <summary>
        /// 将图片存到指定的文件中
        /// </summary>
        /// <param name="img">要存储的图片</param>
        /// <param name="path">存储路径</param>
        public static void SaveImgFromImage(Image img, String path,String filename)
        {
            Bitmap bmp = new Bitmap(img);
            bmp.Save(path+filename,ImageFormat.Jpeg);
            
        }
    }
}
