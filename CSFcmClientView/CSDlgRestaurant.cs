using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

using CSFcmData.Model.Global;
using CSFcmData.Model.DataBase;
using CSFcmData.Model.ErrorMsg;
using CSFcmData.Control.FcmTcpClient;
using CSFcmData.Control.FcmDlgRegister;
using CSFcmData.Control.FcmDlgRestaurant;
using CSFcmData.Model.Socket;
using CSFcmData.Control.FcmLoginOut;

namespace CSFcmClientView
{
    public partial class CSDlgRestaurant : DevComponents.DotNetBar.Office2007Form
    {
        ErrorMsg result;
        bool[] isAllRight_Person;

        public CSDlgRestaurant()
        {
            InitializeComponent();
            isAllRight_Person = new bool[6];
        }


        
        //左侧的功能栏，根据当前选择的页而显示相应的功能
        private void ExpFunchoose_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (this.TcManager.SelectedTab == this.TatSelfmanager)
            {
                ExpSelfmanage.Visible = true;
                ExpMenumanage.Visible = false;
                ExpOrdermanage.Visible = false;
            }
            else if (this.TcManager.SelectedTab == this.TatMenumanager)
            {
                ExpSelfmanage.Visible = false;
                ExpMenumanage.Visible = true;
                ExpOrdermanage.Visible = false;
            }
            else if (this.TcManager.SelectedTab == this.TatOrdermanager)
            {
                ExpOrdermanage.Visible = true;
                ExpSelfmanage.Visible = false;
                ExpMenumanage.Visible = false;

            }

        }

        private void TatSelfmanager_Click(object sender, EventArgs e)
        {
            //右侧显示“个人管理”，隐藏其他功能
            ExpSelfmanage.Visible = true;
            ExpMenumanage.Visible = false;
            ExpOrdermanage.Visible = false;

            LabSelflook_Click(sender,e);
        }



        private void TatMenumanager_Click(object sender, EventArgs e)
        {
            //右侧显示“菜单管理”，隐藏其他功能
            ExpMenumanage.Visible = true;
            ExpSelfmanage.Visible = false;
            ExpOrdermanage.Visible = false;

            LabMenulook_Click(sender, e);
        }
        //右侧功能选择“订单管理”
        private void TatOrdermanager_Click(object sender, EventArgs e)
        {
            ExpOrdermanage.Visible = true;
            ExpSelfmanage.Visible = false;
            ExpMenumanage.Visible = false;

            LabOrderLook_Click(sender, e);

        }


        //左侧点击“查看个人信息”
        private void LabSelflook_Click(object sender, EventArgs e)
        {
            //将修改信息错误提示控件隐藏
            LabelPasswordlimit.Visible = false;
            LabelRPasswordlimit.Visible = false;
            LabelNamelimit.Visible = false;
            LabelMaillimit.Visible = false;
            LabAddresslimit.Visible = false;
            LabelTelelimit.Visible = false;

            //让再次输入密码的响应控件隐藏
            LabelRPassword.Visible = false;
            TbxRpassword.Visible = false;
            //让textbox变成不可写
            TbxPassword.ReadOnly = true;
            TbxName.ReadOnly = true;
            TbxMail.ReadOnly = true;
            TbxAddress.ReadOnly = true;
            TbxTele.ReadOnly = true;
            //让性别的组合框，隐藏
            GplStusex.Visible = false;
            TbxMale.Visible = false;
            TbxFemale.Visible = false;
            //让性别的textbox显示
            TbxSex.Visible = true;
            //隐藏保存按钮
            BtnSaveinfor.Visible = false;

            ////////////////////////////////////////////////////////参观人员获取个人信息
            ArrayList AL;
            AL = ManagePerson.GetMessage(LoginMsg.LoginName);
            User user = (User)AL[0];
            TbxId.Text = user.ID;//ID
            TbxPassword.Text = user.PassWord;//密码
            TbxRpassword.Text = user.PassWord;//再次密码
            TbxName.Text = user.Name;//姓名
            TbxIdentify.Text = user.Role;//角色
            TbxSex.Text = user.Sex;//性别
            if (user.Sex.Equals("男"))
                TbxMale.Checked = true;
            else
                TbxFemale.Checked = true;
            TbxMail.Text = user.Email;//邮箱
            TbxAddress.Text = user.Address;//地址
            TbxTele.Text = user.MobilePhone;//电话号码

        }
        //点击修改个人信息
        private void LabSelfmdify_Click(object sender, EventArgs e)
        {

            //将修改信息错误提示控件显示出来
            LabelPasswordlimit.Visible = true;
            LabelRPasswordlimit.Visible = true;
            LabelNamelimit.Visible = true;
            LabelMaillimit.Visible = true;
            LabAddresslimit.Visible = true;
            LabelTelelimit.Visible = true;

            //让再次输入密码的响应控件显示
            LabelRPassword.Visible = true;
            TbxRpassword.Visible = true;
            //让textbox变成可写
            TbxPassword.ReadOnly = false;
            TbxName.ReadOnly = false;
            TbxMail.ReadOnly = false;
            TbxAddress.ReadOnly = false;
            TbxTele.ReadOnly = false;
            //让性别的组合框显示
            GplStusex.Visible = true;
            TbxMale.Visible = true;
            TbxFemale.Visible = true;
            //让性别的textbox隐藏
            TbxSex.Visible = false;
            //隐藏保存按钮
            BtnSaveinfor.Visible = true;
        }
        //点击保存按钮
        private void BtnSaveinfor_Click(object sender, EventArgs e)
        {
            //将修改信息错误提示控件隐藏
            LabelPasswordlimit.Visible = false;
            LabelRPasswordlimit.Visible = false;
            LabelNamelimit.Visible = false;
            LabelMaillimit.Visible = false;
            LabAddresslimit.Visible = false;
            LabelTelelimit.Visible = false;

            //让再次输入密码的响应控件隐藏
            LabelRPassword.Visible = false;
            TbxRpassword.Visible = false;
            //让textbox变成不可写
            TbxPassword.ReadOnly = true;
            TbxName.ReadOnly = true;
            TbxMail.ReadOnly = true;
            TbxAddress.ReadOnly = true;
            TbxTele.ReadOnly = true;
            //让性别的组合框，隐藏
            GplStusex.Visible = false;
            TbxMale.Visible = false;
            TbxFemale.Visible = false;
            //让性别的textbox显示
            TbxSex.Visible = true;
            //隐藏保存按钮
            BtnSaveinfor.Visible = false;
        }


        private void labelX6_Click(object sender, EventArgs e)
        {

        }
        //左侧选择删除菜品
        private void LabMenudelete_Click(object sender, EventArgs e)
        {
            //让右侧菜单id的输入框，删除按钮显示
            LabMenuid.Visible = true;
            TxbMenuid.Visible = true;
            BtnDelete.Visible = true;

        }
        //点击右侧删除按钮
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //让右侧菜单id的输入框，删除按钮隐藏
           //LabMenuid.Visible = false;
           // TxbMenuid.Visible = false;
           // BtnDelete.Visible = false;

            if (ManageMenu.DelMessage(TxbMenuid.Text))
            {
                MessageBox.Show("删除成功！");
                LabMenulook_Click(sender, e);
            }
            else
            {
                MessageBox.Show("删除失败！");
            }

        }
        //点击左侧查看菜单
        private void LabMenulook_Click(object sender, EventArgs e)
        {
            //让右侧菜单id的输入框，删除按钮隐藏
            LabMenuid.Visible = false;
            TxbMenuid.Visible = false;
            BtnDelete.Visible = false;

            //清空当前listview
            LvwMenuinfor.Items.Clear();
            //获取菜单信息
            ListViewItem lvi;             //创建显示的项
            int index;                    //下标索引
            CSFcmData.Model.DataBase.Menu menu;
            ArrayList result = ManageMenu.GetMessageList("", "");
            if (result.Count != 0)
            {
                for (index = 0; index < result.Count; index++)
                {
                    menu = (CSFcmData.Model.DataBase.Menu)result[index];
                    lvi = new ListViewItem();
                    lvi.Text = menu.ID;
                    lvi.SubItems.Add(menu.Name);
                    lvi.SubItems.Add(menu.Price);
                    lvi.SubItems.Add(menu.Type);
                    lvi.SubItems.Add(menu.TotleScore);
                    lvi.SubItems.Add(menu.Status);
                    lvi.SubItems.Add(menu.Special);
                    lvi.SubItems.Add(menu.Description);

                    LvwMenuinfor.Items.Add(lvi);
                }
            }

        }
        //左侧点击“增加菜单”
        private void LabMenuadd_Click(object sender, EventArgs e)
        {
            //让右侧菜单id的输入框，删除按钮隐藏
            LabMenuid.Visible = false;
            TxbMenuid.Visible = false;
            BtnDelete.Visible = false;

            CSDlgMenuReg MenuReg = new CSDlgMenuReg();
            MenuReg.ShowDialog();
            LabMenulook_Click(sender, e);
        }

        private void CSDlgRestaurant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Loginout.LoginOut(LoginMsg.LoginName);
            Client.close();
            e.Cancel = true;
            this.Dispose();
            Application.Exit();
        }

        //--------------------------------------------餐馆个人信息修改时判断信息是否正确------------------------------------

        /// <summary>
        /// 判断是否应该显示保存按钮（学生个人信息）
        /// </summary>
        private void Judge_isAllRight_Person()
        {
            for (int i = 0; i < isAllRight_Person.Length; i++)
            {
                if (!isAllRight_Person[i])
                {
                    BtnSaveinfor.Enabled = false;
                    return;
                }
            }
            BtnSaveinfor.Enabled = true;
        }

        /// <summary>
        /// 检测餐馆的密码信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxPassword_TextChanged(object sender, EventArgs e)//0
        {
            result = DlgRegisterUserCheck.Check_PassWord(TbxPassword.Text);
            isAllRight_Person[0] = result.Flag;
            if (result.Flag)
            {
                LabelPasswordlimit.Text = null;//提示信息
                Judge_isAllRight_Person();
            }
            else
            {
                BtnSaveinfor.Enabled = false;
                LabelPasswordlimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测餐馆的确认密码信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxRpassword_TextChanged(object sender, EventArgs e)//1
        {
            if (TbxRpassword.Text.Equals(TbxPassword.Text))
            {
                LabelRPasswordlimit.Text = null;//提示信息
                isAllRight_Person[1] = true;
                Judge_isAllRight_Person();
            }
            else
            {
                isAllRight_Person[1] = false;
                BtnSaveinfor.Enabled = false;
                LabelRPasswordlimit.Text = "两次密码不一样！";//提示信息
            }
        }

        /// <summary>
        /// 检测餐馆的姓名信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxName_TextChanged(object sender, EventArgs e)//2
        {
            result = DlgRegisterUserCheck.Check_Name(TbxName.Text);
            isAllRight_Person[2] = result.Flag;
            if (result.Flag)
            {
                LabelNamelimit.Text = null;//提示信息
                Judge_isAllRight_Person();
            }
            else
            {
                BtnSaveinfor.Enabled = false;
                LabelNamelimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测餐馆的邮箱信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxMail_TextChanged(object sender, EventArgs e)//3
        {
            result = DlgRegisterUserCheck.Check_Email(TbxMail.Text);
            isAllRight_Person[3] = result.Flag;
            if (result.Flag)
            {
                LabelMaillimit.Text = null;//提示信息
                Judge_isAllRight_Person();
            }
            else
            {
                BtnSaveinfor.Enabled = false;
                LabelMaillimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测餐馆的地址信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxAddress_TextChanged(object sender, EventArgs e)//4
        {
            result = DlgRegisterUserCheck.Check_Address(TbxAddress.Text);
            isAllRight_Person[4] = result.Flag;
            if (result.Flag)
            {
                LabAddresslimit.Text = null;//提示信息
                Judge_isAllRight_Person();
            }
            else
            {
                BtnSaveinfor.Enabled = false;
                LabAddresslimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测餐馆的手机信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxTele_TextChanged(object sender, EventArgs e)//5
        {
            result = DlgRegisterUserCheck.Check_Phone(TbxTele.Text);
            isAllRight_Person[5] = result.Flag;
            if (result.Flag)
            {
                LabelTelelimit.Text = null;//提示信息
                Judge_isAllRight_Person();
            }
            else
            {
                BtnSaveinfor.Enabled = false;
                LabelTelelimit.Text = result.Msg;//提示信息
            }
        }

        

        private void CSDlgRestaurant_Load(object sender, EventArgs e)
        {
            TatSelfmanager_Click(sender,e);
        }

        private void LabOrderLook_Click(object sender, EventArgs e)
        {
            CreateOrder();
        }


        //-------------------------------------动态创建订单信息-------------------------------------
        private void CreateOrder()
        {
            ArrayList order = ManageOrder.GetMessage();
            this.PnlCenter.Controls.Clear();
            int count = order.Count;
            if (count == 0)
            {
                return;
            }
            DevComponents.DotNetBar.PanelEx OrderPnl;
            DevComponents.DotNetBar.PanelEx OrderPex;
            DevComponents.DotNetBar.LabelX LabOrderNum;
            DevComponents.DotNetBar.LabelX LabOrderTime;
            DevComponents.DotNetBar.LabelX LabMenuName;
            DevComponents.DotNetBar.LabelX LabMenuPrice;
            DevComponents.DotNetBar.LabelX LabBuyNum;
            DevComponents.DotNetBar.LabelX LabBuyTotal;
            for (int index = 0; index < count; index++)
            {
                OrderPnl = new DevComponents.DotNetBar.PanelEx();
                OrderPnl.CanvasColor = System.Drawing.SystemColors.Control;
                OrderPnl.Location = new System.Drawing.Point(15, 9 + index * 105);
                OrderPnl.Size = new System.Drawing.Size(600, 90);
                OrderPnl.Name = "OrderPnl" + index.ToString();
                OrderPnl.Style.Alignment = System.Drawing.StringAlignment.Center;
                OrderPnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
                OrderPnl.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                OrderPnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                OrderPnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
                OrderPnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
                OrderPnl.Style.GradientAngle = 90;
                OrderPnl.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
                OrderPnl.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                OrderPnl.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                OrderPnl.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
                OrderPnl.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
                OrderPnl.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
                OrderPnl.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                OrderPnl.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                OrderPnl.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
                OrderPnl.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;

                OrderPex = new DevComponents.DotNetBar.PanelEx();
                OrderPex.CanvasColor = System.Drawing.SystemColors.Control;
                OrderPex.Location = new System.Drawing.Point(0, 25);
                OrderPex.Name = "OrderPex" + index.ToString();
                OrderPex.Size = new System.Drawing.Size(600, 1);
                OrderPex.Style.Alignment = System.Drawing.StringAlignment.Center;
                OrderPex.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveCaption;
                OrderPex.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
                OrderPex.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                OrderPex.Style.BorderColor.Color = System.Drawing.SystemColors.ActiveCaption;
                OrderPex.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
                OrderPex.Style.GradientAngle = 90;
                OrderPnl.Controls.Add(OrderPex);

                //订单编号
                LabOrderNum = new DevComponents.DotNetBar.LabelX();
                LabOrderNum.Location = new System.Drawing.Point(2, 2);
                LabOrderNum.Name = "LabOrderNum" + index.ToString();
                LabOrderNum.Size = new System.Drawing.Size(200, 20);
                LabOrderNum.Text = "订单编号:" + ((Order)order[index]).ID;
                OrderPnl.Controls.Add(LabOrderNum);

                //订单时间
                LabOrderTime = new DevComponents.DotNetBar.LabelX();
                LabOrderTime.Location = new System.Drawing.Point(230, 2);
                LabOrderTime.Name = "LabOrderTime" + index.ToString();
                LabOrderTime.Size = new System.Drawing.Size(200, 20);
                LabOrderTime.Text = "订单时间:" + ((Order)order[index]).Time;
                OrderPnl.Controls.Add(LabOrderTime);

                //菜名
                LabMenuName = new DevComponents.DotNetBar.LabelX();
                LabMenuName.Location = new System.Drawing.Point(135, 53);
                LabMenuName.Name = "LabMenuName" + index.ToString();
                LabMenuName.Size = new System.Drawing.Size(70, 20);
                LabMenuName.Text = ((Order)order[index]).Name_Menu;
                OrderPnl.Controls.Add(LabMenuName);

                //单价
                LabMenuPrice = new DevComponents.DotNetBar.LabelX();
                LabMenuPrice.Location = new System.Drawing.Point(285, 53);
                LabMenuPrice.Name = "LabMenuPrice" + index.ToString();
                LabMenuPrice.Size = new System.Drawing.Size(70, 20);
                LabMenuPrice.Text = ((Order)order[index]).Price;
                OrderPnl.Controls.Add(LabMenuPrice);

                //购买数量
                LabBuyNum = new DevComponents.DotNetBar.LabelX();
                LabBuyNum.Location = new System.Drawing.Point(410, 53);
                LabBuyNum.Name = "LabBuyNum" + index.ToString();
                LabBuyNum.Size = new System.Drawing.Size(70, 20);
                LabBuyNum.Text = ((Order)order[index]).Num;
                OrderPnl.Controls.Add(LabBuyNum);

                //价格总计
                LabBuyTotal = new DevComponents.DotNetBar.LabelX();
                LabBuyTotal.Location = new System.Drawing.Point(530, 53);
                LabBuyTotal.Name = "LabBuyTotal" + index.ToString();
                LabBuyTotal.Size = new System.Drawing.Size(70, 20);
                LabBuyTotal.Text = ((Order)order[index]).Totle;
                OrderPnl.Controls.Add(LabBuyTotal);

                this.PnlCenter.Controls.Add(OrderPnl);

            }
        }

        private void RefSearch_Click(object sender, EventArgs e)
        {
            //清空当前listview
            LvwMenuinfor.Items.Clear();
            //获取菜单信息
            ListViewItem lvi;             //创建显示的项
            int index;                    //下标索引
            CSFcmData.Model.DataBase.Menu menu;
            ArrayList result = ManageMenu.GetMessageList(TbxMenuaccount.Text, TbxMenuname.Text);
            if (result.Count != 0)
            {
                for (index = 0; index < result.Count; index++)
                {
                    menu = (CSFcmData.Model.DataBase.Menu)result[index];
                    lvi = new ListViewItem();
                    lvi.Text = menu.ID;
                    lvi.SubItems.Add(menu.Name);
                    lvi.SubItems.Add(menu.Price);
                    lvi.SubItems.Add(menu.Type);
                    lvi.SubItems.Add(menu.TotleScore);
                    lvi.SubItems.Add(menu.Status);
                    lvi.SubItems.Add(menu.Special);
                    lvi.SubItems.Add(menu.Description);

                    LvwMenuinfor.Items.Add(lvi);
                }
            }

        }

        private void LvwMenuinfor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sid = LvwMenuinfor.SelectedItems.Count;
            if (sid == 0)
            {
                return; 
            }
            String id = LvwMenuinfor.SelectedItems[0].SubItems[0].Text;
            SocketMenu skm = ManageMenu.GetMessageOne(id);
            RefImage.Image = skm.Image;
        }
      

    }
}
