using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSFcmData.Model.Socket;

namespace CSFcmData.Model.DataBase
{
    [Serializable]
    public class Menu : SocketMsg
    {
        private string iD;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string totleScore;

        public string TotleScore
        {
            get { return totleScore; }
            set { totleScore = value; }
        }
        private string soldNum;

        public string SoldNum
        {
            get { return soldNum; }
            set { soldNum = value; }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string special;

        public string Special
        {
            get { return special; }
            set { special = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        private string iD_Restaurant;

        public string ID_Restaurant
        {
            get { return iD_Restaurant; }
            set { iD_Restaurant = value; }
        }
    }
}
