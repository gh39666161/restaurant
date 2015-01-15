using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSFcmData.Model.Socket;

namespace CSFcmData.Model.Socket
{
    [Serializable]
    public class SocketImage : SocketMsg
    {
        public SocketImage(long size)
        {
            imageByte = new Byte[size];
        }
        private Byte[] imageByte;

        public Byte[] ImageByte
        {
            get { return imageByte; }
            set { imageByte = value; }
        }
        private string imagePath;//图片路径

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        private int width;//图片宽度

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        private int height;//图片高度

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private string type;//图片类型

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
