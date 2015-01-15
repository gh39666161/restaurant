using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using CSFcmData.Model.DataBase;

namespace CSFcmData.Model.Socket
{
    /// <summary>
    /// 网络菜单信息。包括图片和详细信息
    /// </summary>
    [Serializable]
    public class SocketMenu:SocketMsg
    {
        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        private Menu menu;

        public Menu Menu
        {
            get { return menu; }
            set { menu = value; }
        }
    }
}
