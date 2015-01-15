using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSFcmData.Control.FcmTcpClient;
using CSFcmData.Model.Global;
using CSFcmData.Model.DataBase;
using CSFcmData.Control.FcmDlgRegister;
using CSFcmData.Model.ErrorMsg;
using CSFcmData.Control.FcmDlgStudent;
using CSFcmData.Control.FcmLoginOut;
using System.Collections;
using CSFcmData.Model.Socket;

namespace CSFcmClientView
{
    public partial class CSDlgStudent : DevComponents.DotNetBar.Office2007Form
    {

        ErrorMsg result;
        bool[] isAllRight_Person;

        public CSDlgStudent()
        {
            InitializeComponent();
            isAllRight_Person = new bool[6];
        }
        //左侧功能界面，根据页面的选择，而显示相应的功能
        private void ExpFunchoose_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (this.TcManager.SelectedTab == this.TimStu)
            {
                ExpSelfmanage.Visible = true;
                ExpFood.Visible = false;
                ExpOrder.Visible=false;
            }
            else if (this.TcManager.SelectedTab == this.TimFood)
            {
                ExpFood.Visible = true;
                ExpSelfmanage.Visible = false;
                ExpOrder.Visible=false;
            }
            else if (this.TcManager.SelectedTab == this.TimOrder)
            {
                ExpOrder.Visible = true;
                ExpSelfmanage.Visible = false;
                ExpFood.Visible = false;
 
            }
        }




        //------------------------------------------左侧菜单栏隐藏和显示------------------------------------------------------//
        //当点击Tab标签的“个人信息管理”时，左侧菜单栏只显示“个人管理”的功能
        private void TimStu_Click(object sender, EventArgs e)
        {
            ExpSelfmanage.Visible = true;
            ExpFood.Visible = false;
            ExpOrder.Visible = false;

            LabSelflook_Click(sender, e);
        }
        //当点击Tab标签的“订餐管理”时，左侧菜单栏只显示“订餐管理”的功能
        private void TimFood_Click(object sender, EventArgs e)
        {
            ExpFood.Visible = true;
            ExpSelfmanage.Visible = false;
            ExpOrder.Visible = false;
        }
        //当点击Tab标签的“订单管理”时，左侧菜单栏只显示“订单管理”的功能
        private void TimOrder_Click(object sender, EventArgs e)
        {
            ExpOrder.Visible = true;
            ExpSelfmanage.Visible = false;
            ExpFood.Visible = false;
            LabShopcar_Click(sender, e);
        }



        //  --------------------------个人信息管理--------------------------------------------
        //查看个人信息

        private void LabSelflook_Click(object sender, EventArgs e)
        {
            //将修改信息错误提示控件隐藏
            LabelPasswordlimit.Visible = false;
            LabelRPasswordlimit.Visible = false;
            LabelNamelimit.Visible = false;
            LabelMaillimit.Visible = false;
            LabAddresslimit.Visible = false;
            LabelTelelimit.Visible = false;

            //让再次输入密码隐藏
            LabelRPassword.Visible = false;
            TbxRpassword.Visible = false;
            //让textbox变成不可写
            TbxPassword.ReadOnly = true;
            TbxName.ReadOnly = true;
            TbxMail.ReadOnly = true;
            TbxAddress.ReadOnly = true;
            TbxTele.ReadOnly = true;
            //让性别选择的组合框隐藏
            GplStusex.Visible = false;
            TbxMale.Visible = false;
            TbxFemale.Visible = false;
            //让性别的textbox显示
            TbxStusex.Visible = true;
            //让保存按钮隐藏
            BtnSaveinfor.Visible = false;

            ///////////////////////////////////////////用户个人信息的获取
            ArrayList AL;
            AL = ManagePerson.GetMessage(LoginMsg.LoginName);
            User user = (User)AL[0];
            TbxId.Text = user.ID;//ID
            TbxPassword.Text = user.PassWord;//密码
            TbxRpassword.Text = user.PassWord;//再次密码
            TbxName.Text = user.Name;//姓名
            TbxIdentify.Text = user.Role;//角色
            TbxStusex.Text = user.Sex;//性别
            if(user.Sex.Equals("男"))
                TbxMale.Checked = true;
            else
                TbxFemale.Checked = true;
            TbxMail.Text = user.Email;//邮箱
            TbxAddress.Text = user.Address;//地址
            TbxTele.Text = user.MobilePhone;//电话号码
        }
        //修改个人信息
        private void LabSelfmdify_Click(object sender, EventArgs e)
        {
            //将修改信息错误提示控件显示出来
            LabelPasswordlimit.Visible = true;
            LabelRPasswordlimit.Visible = true;
            LabelNamelimit.Visible = true;
            LabelMaillimit.Visible = true;
            LabAddresslimit.Visible = true;
            LabelTelelimit.Visible = true;

            //让再次输入密码显示
            LabelRPassword.Visible = true;
            TbxRpassword.Visible = true;
            //让textbox变成可写
            TbxPassword.ReadOnly = false;
            TbxName.ReadOnly = false;
            TbxMail.ReadOnly = false;
            TbxAddress.ReadOnly = false;
            TbxTele.ReadOnly = false;
            //让性别选择的组合框显示
            GplStusex.Visible = true;
            TbxMale.Visible = true;
            TbxFemale.Visible = true;
            //让性别的textbox隐藏
            TbxStusex.Visible = false;

            //让保存按钮显示
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

            //让再次输入密码隐藏
            LabelRPassword.Visible = false;
            TbxRpassword.Visible = false;
            //让textbox变成不可写
            TbxPassword.ReadOnly = true;
            TbxName.ReadOnly = true;
            TbxMail.ReadOnly = true;
            TbxAddress.ReadOnly = true;
            TbxTele.ReadOnly = true;
            //让性别选择的组合框隐藏
            GplStusex.Visible = false;
            TbxMale.Visible = false;
            TbxFemale.Visible = false;
            //让性别的textbox显示
            TbxStusex.Visible = true;
            //让保存按钮隐藏
            BtnSaveinfor.Visible = false;
        }

        //点击左侧购物车
        private void LabShopcar_Click(object sender, EventArgs e)
        {
            LabTitleName.Text = "我的购物车";
            PexCarbott.Visible = true;
            PexCarcenter.Height = 303;
            CreateShopCar(LoginMsg.LoginName);
        }

        //点击右上角购物车
        private void LatShopcar_Click(object sender, EventArgs e)
        {
            //左侧功能隐藏个人管理和订餐管理，显示订单管理
            this.TcManager.SelectedTab = this.TimOrder;
            ExpOrder.Visible = true;
            ExpSelfmanage.Visible = false;
            ExpFood.Visible = false;

            LabShopcar_Click(sender, e);

        }
        //点击左侧我的订单
        private void LabOrder_Click(object sender, EventArgs e)
        {
            LabTitleName.Text = "我的订单";
            PexCarbott.Visible = false;
            PexCarcenter.Height = 373;
            CreateOrder(LoginMsg.LoginName);
        }
        //点击右上角我的订单
        private void LatOrder_Click(object sender, EventArgs e)
        {   
            //左侧功能隐藏个人管理和订餐管理，显示订单管理
            this.TcManager.SelectedTab = this.TimOrder;
            ExpOrder.Visible = true;
            ExpSelfmanage.Visible = false;
            ExpFood.Visible = false;

            LabOrder_Click(sender, e);
        }

        private void LatExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CSDlgStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Loginout.LoginOut(LoginMsg.LoginName);
            Client.close();
            e.Cancel = true;
            this.Dispose();
            Application.Exit();
        }
        
        private void CSDlgStudent_Load(object sender, EventArgs e)
        {
            TimStu_Click(sender, e);
        }



        //--------------------------------------------学生个人信息修改时判断信息是否正确------------------------------------

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
        /// 检测学生的密码信息是否合法
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
        /// 检测学生的确认密码信息是否合法
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
        /// 检测学生的姓名信息是否合法
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
        /// 检测学生的邮箱信息是否合法
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
        /// 检测学生的地址信息是否合法
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
        /// 检测学生的手机信息是否合法
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


        //--------------------------------------动态创建菜单函数-------------------------------------------

        private void CreateMenu(String type)
        {
            StudentMenuMessage.clear();
            this.PexPicture.Controls.Clear();
            StudentMenuMessage.Menu = ManageMenu.GetMessageByType(type);
            int count = StudentMenuMessage.Menu.Count;
            if (count == 0)
            {
                return;
            }
            DevComponents.DotNetBar.Controls.GroupPanel[] GP = new DevComponents.DotNetBar.Controls.GroupPanel[count];
            DevComponents.DotNetBar.Controls.ReflectionImage[] ReImg = new DevComponents.DotNetBar.Controls.ReflectionImage[count];
            int cols = 0;//显示的列坐标
            int rows = 0;//显示的行坐标
            for (int index = 0; index < count; index++)
            {
                //计算改菜单所在行列信息
                cols = index % 4;
                rows = index / 4;


                GP[index] = new DevComponents.DotNetBar.Controls.GroupPanel();
                ReImg[index] = new DevComponents.DotNetBar.Controls.ReflectionImage();
                
                
                //添加ReflectionImage控件布局
                ReImg[index].Location = new System.Drawing.Point(0, 0);
                ReImg[index].Name = "MenuImg" + index.ToString();
                ReImg[index].Size = new System.Drawing.Size(140, 105);
                ReImg[index].TabIndex = 0;
                ReImg[index].Image = ((SocketMenu)StudentMenuMessage.Menu[index]).Image;

                //添加GroupBox控件布局
                GP[index].CanvasColor = System.Drawing.SystemColors.GradientInactiveCaption;
                GP[index].ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
                GP[index].Controls.Add(ReImg[index]);
                GP[index].Location = new System.Drawing.Point(17 + cols * 160 , 17 + rows * 160);
                GP[index].Name = "Menu" + index.ToString();
                GP[index].Size = new System.Drawing.Size(140, 126);

                GP[index].Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                GP[index].Style.BorderBottomWidth = 1;
                GP[index].Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                GP[index].Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
                GP[index].Style.BorderLeftWidth = 1;
                GP[index].Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
                GP[index].Style.BorderRightWidth = 1;
                GP[index].Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
                GP[index].Style.BorderTopWidth = 1;
                GP[index].Style.CornerDiameter = 4;
                GP[index].Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
                GP[index].Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
                GP[index].TabIndex = 100;
                GP[index].Text = ((SocketMenu)StudentMenuMessage.Menu[index]).Menu.Name;

                this.PexPicture.Controls.Add(GP[index]);

                //添加响应函数
                ReImg[index].MouseClick += new MouseEventHandler(CSDlgStudent_MouseClick);
            }
        }

        void CSDlgStudent_MouseClick(object sender, MouseEventArgs e)
        {
            CSDlgMenudetail Dlg = new CSDlgMenudetail();
            Dlg.ShowDialog();
        }


        //----------------------------------------------查询菜单响应函数-------------------------------
        /// <summary>
        /// 查询鲁菜响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabLudish_Click(object sender, EventArgs e)
        {
            CreateMenu("鲁菜");
        }

        private void BbtLudish_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabLudish_Click(sender, e);
        }
        /// <summary>
        /// 查询川菜响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabChuandish_Click(object sender, EventArgs e)
        {
            CreateMenu("川菜");
        }

        private void BbtChuandish_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabChuandish_Click(sender, e);
        }

        /// <summary>
        /// 查询粤菜响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabYuedish_Click(object sender, EventArgs e)
        {
            CreateMenu("粤菜");
        }

        private void BbtYuedish_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabYuedish_Click(sender, e);
        }

        /// <summary>
        /// 查询苏菜响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabSudish_Click(object sender, EventArgs e)
        {
            CreateMenu("苏菜");
        }

        private void BbtSudish_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabSudish_Click(sender, e);
        }

        /// <summary>
        /// 查询闽菜响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabMindish_Click(object sender, EventArgs e)
        {
            CreateMenu("闽菜");
        }

        private void BbtMindish_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabMindish_Click(sender, e);
        }

        /// <summary>
        /// 查询浙菜响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabZhedish_Click(object sender, EventArgs e)
        {
            CreateMenu("浙菜");
        }

        private void BbtZhedish_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabZhedish_Click(sender, e);
        }

        /// <summary>
        /// 查询湘菜响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabXiangdish_Click(object sender, EventArgs e)
        {
            CreateMenu("湘菜");
        }

        private void BbtXiangdish_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabXiangdish_Click(sender,e);
        }

        /// <summary>
        /// 查询徽菜响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabHuidish_Click(object sender, EventArgs e)
        {
            CreateMenu("徽菜");
        }

        private void BbtHuidish_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabHuidish_Click(sender, e);
        }

        /// <summary>
        /// 查询主食响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabZhushi_Click(object sender, EventArgs e)
        {
            CreateMenu("主食");
        }

        private void BbtZhushi_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabZhushi_Click(sender, e);
        }
        
        /// <summary>
        /// 查询面食响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabMianshi_Click(object sender, EventArgs e)
        {
            CreateMenu("面食");
        }

        private void BbtMianshi_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabMianshi_Click(sender, e);
        }
        
        /// <summary>
        /// 查询粥品响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        private void LabZhou_Click(object sender, EventArgs e)
        {
            CreateMenu("粥品");
        }

        private void BbtZhou_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabZhou_Click(sender, e);
        }

        /// 查询汤品响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabTang_Click(object sender, EventArgs e)
        {
            CreateMenu("汤品");
        }

        private void BbtTang_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            LabTang_Click(sender, e);
        }


        //-------------------------------------动态创建购物车信息-------------------------------------
        private void CreateShopCar(String ID)
        {
            StudentShopCarMessage.ShopCar.Clear();
            StudentShopCarMessage.ShopCarSelectedIndex.Clear();
            StudentShopCarMessage.ShopCar = ManageShopCar.GetMessage(ID);
            this.PexCarcenter.Controls.Clear();
            int count = StudentShopCarMessage.ShopCar.Count;
            if (count == 0)
            {
                return;
            }
            DevComponents.DotNetBar.PanelEx ShopCarPnl;
            System.Windows.Forms.CheckBox CheckShopCar;
            DevComponents.DotNetBar.LabelX LabMenuName;
            DevComponents.DotNetBar.LabelX LabMenuPrice;
            DevComponents.DotNetBar.LabelX LabBuyNum;
            DevComponents.DotNetBar.LabelX LabBuyTotal;
            for (int index = 0; index < count; index++)
            {
                ShopCarPnl = new DevComponents.DotNetBar.PanelEx();
                ShopCarPnl.CanvasColor = System.Drawing.SystemColors.Control;
                ShopCarPnl.Location = new System.Drawing.Point(15, 9 + index * 75);
                ShopCarPnl.Size = new System.Drawing.Size(600, 60);
                ShopCarPnl.Name = "ShopCarPnl" + index.ToString();
                ShopCarPnl.Style.Alignment = System.Drawing.StringAlignment.Center;
                ShopCarPnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
                ShopCarPnl.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                ShopCarPnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                ShopCarPnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
                ShopCarPnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
                ShopCarPnl.Style.GradientAngle = 90;
                ShopCarPnl.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
                ShopCarPnl.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                ShopCarPnl.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                ShopCarPnl.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
                ShopCarPnl.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
                ShopCarPnl.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
                ShopCarPnl.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                ShopCarPnl.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
                ShopCarPnl.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
                ShopCarPnl.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
                


                //选择框
                CheckShopCar = new CheckBox();
                CheckShopCar.AutoSize = true;
                CheckShopCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
                CheckShopCar.Location = new System.Drawing.Point(11, 25);
                CheckShopCar.Name = index.ToString();
                CheckShopCar.Size = new System.Drawing.Size(20, 16);
                CheckShopCar.Text = "";
                CheckShopCar.UseVisualStyleBackColor = true;
                ShopCarPnl.Controls.Add(CheckShopCar);

                //菜名
                LabMenuName = new DevComponents.DotNetBar.LabelX();
                LabMenuName.Location = new System.Drawing.Point(135, 23);
                LabMenuName.Name = "LabMenuName"+index.ToString();
                LabMenuName.Size = new System.Drawing.Size(70, 20);
                LabMenuName.Text = ((ShopCar)StudentShopCarMessage.ShopCar[index]).Name_Menu;
                ShopCarPnl.Controls.Add(LabMenuName);

                //单价
                LabMenuPrice = new DevComponents.DotNetBar.LabelX();
                LabMenuPrice.Location = new System.Drawing.Point(285, 23);
                LabMenuPrice.Name = "LabMenuPrice" + index.ToString();
                LabMenuPrice.Size = new System.Drawing.Size(70, 20);
                LabMenuPrice.Text = ((ShopCar)StudentShopCarMessage.ShopCar[index]).Price;
                ShopCarPnl.Controls.Add(LabMenuPrice);

                //购买数量
                LabBuyNum = new DevComponents.DotNetBar.LabelX();
                LabBuyNum.Location = new System.Drawing.Point(410, 23);
                LabBuyNum.Name = "LabBuyNum" + index.ToString();
                LabBuyNum.Size = new System.Drawing.Size(70, 20);
                LabBuyNum.Text = ((ShopCar)StudentShopCarMessage.ShopCar[index]).Num;
                ShopCarPnl.Controls.Add(LabBuyNum);

                //价格总计
                LabBuyTotal = new DevComponents.DotNetBar.LabelX();
                LabBuyTotal.Location = new System.Drawing.Point(530, 23);
                LabBuyTotal.Name = "LabBuyTotal" + index.ToString();
                LabBuyTotal.Size = new System.Drawing.Size(70, 20);
                LabBuyTotal.Text = ((ShopCar)StudentShopCarMessage.ShopCar[index]).Totle;
                ShopCarPnl.Controls.Add(LabBuyTotal);

                this.PexCarcenter.Controls.Add(ShopCarPnl);

                CheckShopCar.CheckedChanged += new EventHandler(CSDlgStudentCheckShopCar_CheckedChanged);
            }
        }

        void CSDlgStudentCheckShopCar_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                StudentShopCarMessage.ShopCarSelectedIndex.Add(((CheckBox)sender).Name);
            }
            else
            {
                StudentShopCarMessage.ShopCarSelectedIndex.Remove(((CheckBox)sender).Name);
            }

            //计算总价
            int count = StudentShopCarMessage.ShopCarSelectedIndex.Count;
            int index;
            float price;
            float total = 0;
            for (int i = 0; i < count; i++)
            {
                index = int.Parse((String)StudentShopCarMessage.ShopCarSelectedIndex[i]);
                price = float.Parse(((ShopCar)StudentShopCarMessage.ShopCar[index]).Totle);
                total += price;
            }
            LabTotalPrir.Text = total.ToString();
        }

        /// <summary>
        /// 删除所选购物车信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabDeletebott_Click(object sender, EventArgs e)
        {
            int count = StudentShopCarMessage.ShopCarSelectedIndex.Count;
            if(count==0)
            {
                return;
            }
            int delindex;
            String menu;
            for (int index = 0; index < count; index++)
            {
                delindex = int.Parse((String)StudentShopCarMessage.ShopCarSelectedIndex[index]);
                menu = ((ShopCar)StudentShopCarMessage.ShopCar[delindex]).ID_Menu;
                ManageShopCar.DelMessage(LoginMsg.LoginName , menu);
            }

            LabShopcar_Click(sender, e);
        }

        /// <summary>
        /// 删除全部购物车信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabDeleteAll_Click(object sender, EventArgs e)
        {
            int count = StudentShopCarMessage.ShopCar.Count;
            if (count == 0)
            {
                return;
            }
            String menu;
            for (int index = 0; index < count; index++)
            {
                menu = ((ShopCar)StudentShopCarMessage.ShopCar[index]).ID_Menu;
                ManageShopCar.DelMessage(LoginMsg.LoginName, menu);
            }
            LabShopcar_Click(sender, e);
        }
        /// <summary>
        /// 结算购物车所选物品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAccount_Click(object sender, EventArgs e)
        {
            int count = StudentShopCarMessage.ShopCarSelectedIndex.Count;
            if (count == 0)
            {
                return;
            }
            int accindex;
            String menu;
            for (int index = 0; index < count; index++)
            {
                accindex = int.Parse((String)StudentShopCarMessage.ShopCarSelectedIndex[index]);
                menu = ((ShopCar)StudentShopCarMessage.ShopCar[accindex]).ID_Menu;
                ManageShopCar.AccountOne(LoginMsg.LoginName, menu);
            }

            LabShopcar_Click(sender, e);
        }




        //-------------------------------------动态创建订单信息-------------------------------------
        private void CreateOrder(String ID)
        {
            ArrayList order = ManageOrder.GetMessage(ID);
            this.PexCarcenter.Controls.Clear();
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
                OrderPex.Name = "OrderPex"+index.ToString();
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

                this.PexCarcenter.Controls.Add(OrderPnl);

            }
        }

    }
}
