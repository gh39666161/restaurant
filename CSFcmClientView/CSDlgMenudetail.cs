using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSFcmData.Model.Global;
using CSFcmData.Model.Socket;
using CSFcmData.Control.FcmDlgStudent;

namespace CSFcmClientView
{
    public partial class CSDlgMenudetail : DevComponents.DotNetBar.Office2007Form
    {
        public CSDlgMenudetail()
        {
            InitializeComponent();
        }

        private void CSDlgMenudetail_Load(object sender, EventArgs e)
        {
            LabMenuidr.Text = ((SocketMenu)StudentMenuMessage.Menu[StudentMenuMessage.SelectedIndex]).Menu.ID;
            LabNamer.Text = ((SocketMenu)StudentMenuMessage.Menu[StudentMenuMessage.SelectedIndex]).Menu.Name;
            LabPricer.Text = ((SocketMenu)StudentMenuMessage.Menu[StudentMenuMessage.SelectedIndex]).Menu.Price;
            LabTyper.Text = ((SocketMenu)StudentMenuMessage.Menu[StudentMenuMessage.SelectedIndex]).Menu.Type;
            LabScorer.Text = ((SocketMenu)StudentMenuMessage.Menu[StudentMenuMessage.SelectedIndex]).Menu.TotleScore;
            LabDescriber.Text = ((SocketMenu)StudentMenuMessage.Menu[StudentMenuMessage.SelectedIndex]).Menu.Description;
            LabStater.Text = ((SocketMenu)StudentMenuMessage.Menu[StudentMenuMessage.SelectedIndex]).Menu.Status;
            LabSper.Text = ((SocketMenu)StudentMenuMessage.Menu[StudentMenuMessage.SelectedIndex]).Menu.Special;
            RimFood.Image = ((SocketMenu)StudentMenuMessage.Menu[StudentMenuMessage.SelectedIndex]).Image;
        }

        private void BtnPuttocar_Click(object sender, EventArgs e)
        {
            ManageShopCar.AddMessage(InpBuynum.Text, LoginMsg.LoginName, LabMenuidr.Text, LabPricer.Text);
            MessageBox.Show("已经放入购物车!");
            this.Close();
        }
    }
}
