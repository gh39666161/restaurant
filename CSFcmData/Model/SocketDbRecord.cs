using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSFcmData.Model.Socket
{
    [Serializable]
    public class SocketDbRecord:SocketMsg
    {
        private ArrayList record;

        public ArrayList Record
        {
            get { return record; }
            set { record = value; }
        }

        private String type;

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public SocketDbRecord()
        {
            record = new ArrayList();
        }

    }
}
