using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSFcmData.Model.Global;
using CSFcmData.Control.FcmDlgLogin;
using CSFcmData.Control.FcmTcpClient;

namespace CSFcmClientView
{
    public partial class CSDlgLogin : DevComponents.DotNetBar.Office2007Form
    {
        public CSDlgLogin()
        {
            InitializeComponent();
            Client.init();
            SocketConnectState.State = true;
        }

        private void Manager_CheckedChanged(object sender, EventArgs e)
        {
            Role_Image.Image = (Image)Properties.Resources.ResourceManager.GetObject("lg_admin");
            LoginMsg.Identify = "Manager";
        }

        private void Student_CheckedChanged(object sender, EventArgs e)
        {
            Role_Image.Image = (Image)Properties.Resources.ResourceManager.GetObject("lg_student");
            LoginMsg.Identify = "Student";
        }

        private void Restaurant_CheckedChanged(object sender, EventArgs e)
        {

            Role_Image.Image = (Image)Properties.Resources.ResourceManager.GetObject("lg_restaurant");
            LoginMsg.Identify = "Restaurant";
        }

        private void RegisterAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CSDlgUserReg Dlg = new CSDlgUserReg();
            Dlg.ShowDialog();
            this.Show();
        }

        private void RegisterAccount_MouseHover(object sender, EventArgs e)
        {
            RegisterAccount.ForeColor = Color.YellowGreen;
        }

        private void RegisterAccount_MouseLeave(object sender, EventArgs e)
        {
            RegisterAccount.ForeColor = Color.Blue;
        }

        private void CSDlgLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoginWindowState.IsPop == false)
            {
                if (SocketConnectState.State == true)
                {
                    Client.close();
                    SocketConnectState.State = false;
                }
                Application.Exit();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Account.Text = "";
            Password.Text = "";
            Account.Focus();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginMsg.LoginName = Account.Text;

            if (LoginMsg.Identify.Equals("Manager"))
            {
                LoginMsg.IsLogin = DlgLogin.ManagerLogin(Account.Text, Password.Text);
            }
            if (LoginMsg.Identify.Equals("Student"))
            {
                LoginMsg.IsLogin = DlgLogin.StudentLogin(Account.Text, Password.Text);
            }
            if (LoginMsg.Identify.Equals("Restaurant"))
            {
                LoginMsg.IsLogin = DlgLogin.RestaurantLogin(Account.Text, Password.Text);
            }


            //判断是否登录成功
            if (LoginMsg.IsLogin)
            {
                if (LoginMsg.Identify.Equals("Manager"))
                {
                    CSDlgManager DlgMag = new CSDlgManager();
                    DlgMag.Show();
                    LoginWindowState.IsPop = true;
                    this.Close();
                }
                if (LoginMsg.Identify.Equals("Student"))
                {
                    CSDlgStudent DlgStu = new CSDlgStudent();
                    DlgStu.Show();
                    LoginWindowState.IsPop = true;
                    this.Close();
                }
                if (LoginMsg.Identify.Equals("Restaurant"))
                {
                    CSDlgRestaurant DlgRes = new CSDlgRestaurant();
                    DlgRes.Show();
                    LoginWindowState.IsPop = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void CSDlgLogin_Load(object sender, EventArgs e)
        {
            LoginMsg.Identify = "Manager";
        }


    }
}
