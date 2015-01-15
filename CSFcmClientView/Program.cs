using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSFcmClientView
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CSDlgLogin Dlg = new CSDlgLogin();
            Dlg.Show();
            Application.Run();
        }
    }
}
