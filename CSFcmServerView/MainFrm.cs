using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSFcmData.Control.FcmTcpServer;

namespace CSFcmServerView
{
    public partial class MainFrm : DevComponents.DotNetBar.Office2007Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void BtnServerStartup_Click(object sender, EventArgs e)
        {
            Server.run();
        }

        private void BtnServerShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Server.close();
        }
    }
}
