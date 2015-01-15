using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSFcmData.Model.ErrorMsg
{
    public class ErrorMsg
    {
        private bool flag;
        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        private String msg;
        public String Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        public ErrorMsg()
        {
            flag = true;
            Msg = "";
        }
    }
}
