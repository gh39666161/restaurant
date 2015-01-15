using System;
using System.Collections;
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
using CSFcmData.Control.FcmLoginOut;
using CSFcmData.Control.FcmDlgRegister;
using CSFcmData.Control.FcmDlgManager;
using CSFcmData.Model.ErrorMsg;

namespace CSFcmClientView
{
    public partial class CSDlgManager : DevComponents.DotNetBar.Office2007Form
    {


        ErrorMsg result;
        bool[] isAllRight_Person;
        bool[] isAllRight_Student;
        bool[] isAllRight_Restaurant;

       

        public CSDlgManager()
        {
            InitializeComponent();
            isAllRight_Person = new bool[6];
            isAllRight_Student = new bool[4];
            isAllRight_Restaurant = new bool[4];            
        }
        //------------------------------------------左侧菜单栏隐藏和显示------------------------------------------------------//
        //当点击Tab标签的“个人信息管理”时，左侧菜单栏只显示“个人管理”的功能
        private void TcpManager_Click(object sender, EventArgs e)
        {
            //让左侧菜单栏的“个人管理”显示，“学生管理”和“餐馆管理”隐藏
            ExpManage.Visible = true;
            ExpStumanage.Visible = false;
            ExpRestmanage.Visible = false;

            //获取信息
            ArrayList result = ManagePerson.GetMessage(LoginMsg.LoginName);
            User manager = (User)result[0];

            //显示信息
            TbxId.Text = manager.ID;
            TbxPassword.Text = manager.PassWord;
            TbxName.Text = manager.Name;
            TbxIdentity.Text = manager.Role;
            TbxSex.Text = manager.Sex;
            TbxMail.Text = manager.Email;
            TbxAddress.Text = manager.Address;
            TbxTele.Text = manager.MobilePhone;
            TbxTime.Text = manager.LastLogin;
        }
        //当点击Tab标签的“学生信息管理”时，左侧菜单栏只显示“学生管理”的功能
        private void TcpStudent_Click(object sender, EventArgs e)
        {
            //让左侧菜单栏的“学生管理”显示，“个人管理”和“餐馆管理”隐藏
            ExpManage.Visible = false;
            ExpStumanage.Visible = true;
            ExpRestmanage.Visible = false;
            //显示学生查找界面，隐藏修改界面
            PnlLFstudent.Visible = true;
            PnlModifystudent.Visible = false;

            LabStulook_Click(sender, e);
        }
        //当点击Tab标签的“餐馆信息管理”时，左侧菜单栏只显示“餐馆管理”的功能
        private void TcpRestaurant_Click(object sender, EventArgs e)
        {
            //让左侧菜单栏的“餐馆管理”显示，“个人管理”和“学生管理”隐藏
            ExpManage.Visible = false;
            ExpRestmanage.Visible = true;
            ExpStumanage.Visible = false;

            LabRestlook_Click(sender, e);
        }
        //当展开“功能选择”后，根据当前的选择页，显示相应的“个人管理”或“学生管理”或“餐馆管理”
        private void ExpFunchoose_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (this.TcManager.SelectedTab == this.TcpManager)
            {
                ExpManage.Visible = true;
                ExpStumanage.Visible = false;
                ExpRestmanage.Visible = false;
            }
            else if (this.TcManager.SelectedTab == this.TcpStudent)
            {
                ExpStumanage.Visible = true;
                ExpManage.Visible = false;       
                ExpRestmanage.Visible = false;
            }
            else if (this.TcManager.SelectedTab == this.TcpRestaurant)
            {
                ExpRestmanage.Visible = true;
                ExpStumanage.Visible = false;
                ExpManage.Visible = false;      
            }

        }
        //------------------------------------------左侧菜单栏功能实现------------------------------------------------------//
       //-----------------------------个人信息--------------------------
        //左侧的“个人管理”中的“修改个人信息”
        private void LabManagermdify_Click(object sender, EventArgs e)
        {
            //将该textbox变成可写起来
            TbxPassword.ReadOnly = false;
            TbxName.ReadOnly = false;
            TbxSex.ReadOnly = false;
            TbxMail.ReadOnly = false;
            TbxAddress.ReadOnly = false;
            TbxTele.ReadOnly = false;
            TbxTime.ReadOnly = false;

            //将该显示的控件显示出来
            LabRpassword.Visible = true;
            TbxRpassword.Visible = true;
            TbxSexchoose.Visible = true;
            TbxMale.Visible = true;
            TbxFemale.Visible = true;
            BtnSaveinfor.Visible = true;
            LabIdlimit.Visible = true;
            LabIdentitylimit.Visible = true;
            //将TextBox后边的提示信息控件显示出来
            LabPasswordlimit.Visible = true;
            LabRpasswordlimit.Visible = true;
            LabNamelimit.Visible = true;
            LabMaillimit.Visible = true;
            LabAddresslimit.Visible = true;
            LabTelelimit.Visible = true;
            //把性别的信息从textbox中放到radio中
            if (TbxSex.Text == "男")
            {
                TbxMale.Checked = true;
            }
            else
            {
                TbxFemale.Checked = true;
            }
            //显示性别的组合框
            TbxSexchoose.Visible = true;
            TbxMale.Visible = true;
            TbxFemale.Visible = true;
            //隐藏性别的textbox框
           // TbxIdentity.Visible = false;
            TbxSex.Visible = false;
        }


        //修改完成后点击“保存”
        private void BtnSaveinfor_Click(object sender, EventArgs e)
        {
            //让控件编程不可写
            TbxPassword.ReadOnly = true;
            TbxName.ReadOnly = true;
            TbxSex.ReadOnly = true;
            TbxMail.ReadOnly = true;
            TbxAddress.ReadOnly = true;
            TbxTele.ReadOnly = true;
            TbxTime.ReadOnly = true;

            //让该隐藏的控件隐藏起来
            LabRpassword.Visible = false;
            TbxRpassword.Visible = false;
            LabIdlimit.Visible = false;
            LabIdentitylimit.Visible = false;

            //将TextBox后边的提示信息控件隐藏
            LabPasswordlimit.Visible = false;
            LabRpasswordlimit.Visible = false;
            LabNamelimit.Visible = false;
            LabMaillimit.Visible = false;
            LabAddresslimit.Visible = false;
            LabTelelimit.Visible = false;

            //把性别的组合框内容写入textbox中
            if (TbxMale.Checked)
            {
                TbxSex.Text = "男";
            }
            else
            {
                TbxSex.Text = "女";
            }
            //隐藏性别组合框
            TbxSexchoose.Visible = false;
            TbxMale.Visible = false;
            TbxFemale.Visible = false;
            //显示性别textbox框
            TbxSex.Visible = true;
            //隐藏保存按钮
            BtnSaveinfor.Visible = false;
            bool isExcute = ManagePerson.ChangeMessage(LoginMsg.LoginName,TbxPassword.Text,TbxIdentity.Text,TbxName.Text,TbxSex.Text,TbxMail.Text,TbxTele.Text,TbxAddress.Text);
            if (isExcute)
            {
                MessageBox.Show("修改成功!");
            }
            else
            {
                MessageBox.Show("修改失败!");
            }
       
        }





        //-----------------------------学生信息--------------------------------------------------------------------
        //左侧的“学生管理”中的“查看学生信息”
        private void LabStulook_Click(object sender, EventArgs e)
        {
            //显示查找学生信息的界面,隐藏学生详细信息的界面，
            PnlLFstudent.Visible = true;
            PnlModifystudent.Visible = false;
            //清空当前listview
            LivShowstu.Items.Clear();

            //重置焦点信息
            ManagerGlobalValues.IsStudentSelected = false;

            //获取学生信息
            ListViewItem lvi;             //创建显示的项
            int index;                    //下标索引
            User user;
            ArrayList student = ManageStudent.GetMessage();
            if (student.Count != 0)
            {
                for (index = 0; index < student.Count; index++)
                {
                    user = (User)student[index];
                    lvi = new ListViewItem();
                    lvi.Text = user.ID;
                    lvi.SubItems.Add(user.Name);
                    lvi.SubItems.Add(user.Role);
                    lvi.SubItems.Add(user.Sex);
                    lvi.SubItems.Add(user.Email);
                    lvi.SubItems.Add(user.Address);
                    lvi.SubItems.Add(user.MobilePhone);
                    lvi.SubItems.Add(user.LastLogin);

                    LivShowstu.Items.Add(lvi);
                }
            }
        }
        //按条件查询按钮
        private void RfiLFstu_Click(object sender, EventArgs e)
        {
            //清空当前listview
            LivShowstu.Items.Clear();
            //获取学生信息
            ListViewItem lvi;             //创建显示的项
            int index;                    //下标索引
            User user;
            //获取性别信息
            String sex = "";
            if(RbtLFstumale.Checked)
            {
                sex="男";
            }
            if (RbtLFstufemale.Checked)
            {
                sex="女";
            }
            ArrayList student = ManageStudent.GetMessage(TbxLFstuid.Text, TbxLFstuname.Text, sex);
            if (student.Count != 0)
            {
                for (index = 0; index < student.Count; index++)
                {
                    user = (User)student[index];
                    lvi = new ListViewItem();
                    lvi.Text = user.ID;
                    lvi.SubItems.Add(user.Name);
                    lvi.SubItems.Add(user.Role);
                    lvi.SubItems.Add(user.Sex);
                    lvi.SubItems.Add(user.Email);
                    lvi.SubItems.Add(user.Address);
                    lvi.SubItems.Add(user.MobilePhone);
                    lvi.SubItems.Add(user.LastLogin);

                    LivShowstu.Items.Add(lvi);
                }
            }
        }




        //学生信息被选中消息
        private void LivShowstu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LivShowstu.SelectedItems.Count != 1)
            {
                return;
            }
            ManagerGlobalValues.IsStudentSelected = true;
            String ID = LivShowstu.SelectedItems[0].SubItems[0].Text;
            ArrayList AL = ManageStudent.GetMessage(ID, "", "");
            User stu = (User)AL[0];
            ManagerGlobalValues.UserSelected.ID = stu.ID;
            ManagerGlobalValues.UserSelected.PassWord = stu.PassWord;
            ManagerGlobalValues.UserSelected.Name = stu.Name;
            ManagerGlobalValues.UserSelected.Role = stu.Role;
            ManagerGlobalValues.UserSelected.Sex = stu.Sex;
            ManagerGlobalValues.UserSelected.Email = stu.Email;
            ManagerGlobalValues.UserSelected.Address = stu.Address;
            ManagerGlobalValues.UserSelected.MobilePhone = stu.MobilePhone;
            ManagerGlobalValues.UserSelected.LastLogin = stu.LastLogin;
        }




        //左侧的“学生管理”中的“修改学生信息”
        private void LabStumdify_Click(object sender, EventArgs e)
        {
            //获取选中学生的信息
            if (ManagerGlobalValues.IsStudentSelected)
            {
                TbxStuid.Text = ManagerGlobalValues.UserSelected.ID;
                TbxStuname.Text = ManagerGlobalValues.UserSelected.Name;
                TbxStuidentity.Text = ManagerGlobalValues.UserSelected.Role;
                if (ManagerGlobalValues.UserSelected.Sex.Equals("男"))
                {
                    TbxStumale.Checked = true;
                }
                else
                {
                    TbxStufemale.Checked = true;
                }
                TbxStumail.Text = ManagerGlobalValues.UserSelected.Email;
                TbxStuaddress.Text = ManagerGlobalValues.UserSelected.Address;
                TbxStutele.Text = ManagerGlobalValues.UserSelected.MobilePhone;
                TbxStutime.Text = ManagerGlobalValues.UserSelected.LastLogin;
            }
            else
            {
                return;
            }

            //将学生信息后的错误信息提示控件显示出来
            LabStunamelimit.Visible = true;
            LabStumaillimit.Visible = true;
            LabStuaddresslimit.Visible = true;
            LabStutelelimit.Visible = true;

            //隐藏查找学生信息的界面,显示学生详细信息的界面，
            PnlLFstudent.Visible = false;
            PnlModifystudent.Visible = true;
           
            //显示保存按钮,隐藏删除按钮
            BtnStusaveinfor.Visible = true;
            BtnStudeleteinfor.Visible = false;
           
            //显示警告项
            LabStuidlimit.Visible = true;
            LabStuidengtifylimit.Visible = true;

            //让textbox变成可写

            TbxStuname.ReadOnly = false;
            TbxStumail.ReadOnly = false;
            TbxStuaddress.ReadOnly = false;
            TbxStutele.ReadOnly = false;
            TbxStusex.ReadOnly = false;

            //显示性别组合框
            GplStusex.Visible=true;
            TbxStumale.Visible = true;
            TbxFemale.Visible = true;
            TbxStufemale.Visible = true;

            //隐藏性别textbox的形式显示
            TbxStusex.Visible = false;
        }

        
        //管理学生信息时，点击保存时，要将控件变成不可写
        private void BtnStusaveinfor_Click(object sender, EventArgs e)
        {
            //重置选中焦点
            ManagerGlobalValues.IsStudentSelected = false;
                                    
            //将学生信息后的错误信息提示控件隐藏
            LabStunamelimit.Visible = false;
            LabStumaillimit.Visible = false;
            LabStuaddresslimit.Visible = false;
            LabStutelelimit.Visible = false;

            //让textbox变成只读
            TbxStuname.ReadOnly = true;
            TbxStumail.ReadOnly = true;
            TbxStuaddress.ReadOnly = true;
            TbxStusex.ReadOnly = true;
            TbxStutele.ReadOnly = true;

            //隐藏性别的组合框
            GplStusex.Visible = false;
            TbxStumale.Visible = false;
            TbxFemale.Visible = false;

            //隐藏性别textbox的形式显示
            TbxStusex.Visible = true;
            
            //隐藏保存按钮
            BtnStusaveinfor.Visible = false;

            String sex = "";
            if(TbxStumale.Checked)
            {
                sex="男";
            }
            else
            {
                sex="女";
            }

            bool isExcute = ManageStudent.ChangeMessage(ManagerGlobalValues.UserSelected.ID, ManagerGlobalValues.UserSelected.PassWord, TbxStuname.Text, sex , TbxStumail.Text, TbxStutele.Text, TbxStuaddress.Text);
            
            TbxStusex.Text = sex;

            if (isExcute)
            {
                MessageBox.Show("修改成功!");
            }
            else
            {
                MessageBox.Show("修改失败!");
            }
        }

        //左侧的“学生管理”中的“删除学生信息”
        private void LabStudelete_Click(object sender, EventArgs e)
        {
            //获取选中学生的信息
            if (ManagerGlobalValues.IsStudentSelected)
            {
                TbxStuid.Text = ManagerGlobalValues.UserSelected.ID;
                TbxStuname.Text = ManagerGlobalValues.UserSelected.Name;
                TbxStuidentity.Text = ManagerGlobalValues.UserSelected.Role;
                TbxStusex.Text = ManagerGlobalValues.UserSelected.Sex;
                TbxStumail.Text = ManagerGlobalValues.UserSelected.Email;
                TbxStuaddress.Text = ManagerGlobalValues.UserSelected.Address;
                TbxStutele.Text = ManagerGlobalValues.UserSelected.MobilePhone;
                TbxStutime.Text = ManagerGlobalValues.UserSelected.LastLogin;
            }
            else
            {
                return;
            }
            //隐藏查找学生信息的界面,显示学生详细信息的界面，
            PnlLFstudent.Visible = false;
            PnlModifystudent.Visible = true;

            //隐藏保存按钮,显示删除按钮
            BtnStusaveinfor.Visible = false;
            BtnStudeleteinfor.Visible = true;

            //隐藏警告项
            LabStuidlimit.Visible = false;
            LabStuidengtifylimit.Visible = false;

            //让textbox变成不可写

            TbxStuname.ReadOnly = true;
            TbxStumail.ReadOnly = true;
            TbxStuaddress.ReadOnly = true;
            TbxStutele.ReadOnly = true;
            TbxStuidentity.ReadOnly = true;
            TbxStusex.ReadOnly = true;

            //隐藏性别组合框
            GplStusex.Visible = false;
            TbxStumale.Visible = false;
            TbxFemale.Visible = false;

            //显示性别textbox的形式显示
            TbxStuidentity.Visible = true;
            TbxStusex.Visible = true;

        }
        //点击删除学生信息按钮
        private void BtnStudeleteinfor_Click(object sender, EventArgs e)
        {   
            //隐藏删除按钮
            BtnStudeleteinfor.Visible = false;
            //重置焦点
            ManagerGlobalValues.IsStudentSelected = false;

            bool isExcute = ManageStudent.DelMessage(ManagerGlobalValues.UserSelected.ID);
            if (isExcute)
            {
                MessageBox.Show("删除成功!");
            }
            else
            {
                MessageBox.Show("删除失败!");
            }

        } 



        //-----------------------------餐馆人员信息---------------------------------------------------

        //左侧的“餐馆管理”中的“查看餐馆人员信息”
        private void LabRestlook_Click(object sender, EventArgs e)
        {
             //显示查找餐馆信息的界面，隐藏餐馆人员详细信息的界面
            PnlLFrestaurant.Visible = true;
            PnlModifyrestaurant.Visible = false;

            //清空当前listview
            LivShowrest.Items.Clear();

            //重置焦点信息
            ManagerGlobalValues.IsRestaurantSelected = false;

            //获取餐馆人员信息
            ListViewItem lvi;             //创建显示的项
            int index;                    //下标索引
            User user;
            ArrayList restaurant = ManageRestaurant.GetMessage();
            if (restaurant.Count != 0)
            {
                for (index = 0; index < restaurant.Count; index++)
                {
                    user = (User)restaurant[index];
                    lvi = new ListViewItem();
                    lvi.Text = user.ID;
                    lvi.SubItems.Add(user.Name);
                    lvi.SubItems.Add(user.Role);
                    lvi.SubItems.Add(user.Sex);
                    lvi.SubItems.Add(user.Email);
                    lvi.SubItems.Add(user.Address);
                    lvi.SubItems.Add(user.MobilePhone);
                    lvi.SubItems.Add(user.LastLogin);

                    LivShowrest.Items.Add(lvi);
                }
            }

        }
        //按条件查询餐馆人员信息
        private void RfiLFrest_Click(object sender, EventArgs e)
        {
            //清空当前listview
            LivShowrest.Items.Clear();

            //获取餐馆人员信息
            ListViewItem lvi;             //创建显示的项
            int index;                    //下标索引
            User user;
            //获取餐馆人员性别信息
            String sex = "";
            if (RbtLFrestmale.Checked)
            {
                sex = "男";
            }
            if (RbtLFrestfemale.Checked)
            {
                sex = "女";
            }
            ArrayList restaurant = ManageRestaurant.GetMessage(TbxLFrestid.Text, TbxLFrestname.Text, sex);
            if (restaurant.Count != 0)
            {
                for (index = 0; index < restaurant.Count; index++)
                {
                    user = (User)restaurant[index];
                    lvi = new ListViewItem();
                    lvi.Text = user.ID;
                    lvi.SubItems.Add(user.Name);
                    lvi.SubItems.Add(user.Role);
                    lvi.SubItems.Add(user.Sex);
                    lvi.SubItems.Add(user.Email);
                    lvi.SubItems.Add(user.Address);
                    lvi.SubItems.Add(user.MobilePhone);
                    lvi.SubItems.Add(user.LastLogin);

                    LivShowrest.Items.Add(lvi);
                }
            }
        }



        //餐馆人员信息被选中
        private void LivShowrest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LivShowrest.SelectedItems.Count != 1)
            {
                return;
            }
            ManagerGlobalValues.IsRestaurantSelected = true;
            String ID = LivShowrest.SelectedItems[0].SubItems[0].Text;
            ArrayList AL = ManageRestaurant.GetMessage(ID, "", "");
            User res = (User)AL[0];
            ManagerGlobalValues.UserSelected.ID = res.ID;
            ManagerGlobalValues.UserSelected.PassWord = res.PassWord;
            ManagerGlobalValues.UserSelected.Name = res.Name;
            ManagerGlobalValues.UserSelected.Role = res.Role;
            ManagerGlobalValues.UserSelected.Sex = res.Sex;
            ManagerGlobalValues.UserSelected.Email = res.Email;
            ManagerGlobalValues.UserSelected.Address = res.Address;
            ManagerGlobalValues.UserSelected.MobilePhone = res.MobilePhone;
            ManagerGlobalValues.UserSelected.LastLogin = res.LastLogin;
        }


        //左侧的“餐馆管理”中的“修改餐馆人员信息”
        private void LabRestmdify_Click(object sender, EventArgs e)
        {
            //获取选中的餐馆人员的信息
            if (ManagerGlobalValues.IsRestaurantSelected)
            {
                TbxRestid.Text = ManagerGlobalValues.UserSelected.ID;
                TbxRestname.Text = ManagerGlobalValues.UserSelected.Name;
                TbxRestidentify.Text = ManagerGlobalValues.UserSelected.Role;
                if (ManagerGlobalValues.UserSelected.Sex.Equals("男"))
                {
                    TbxRestmale.Checked = true;
                }
                else
                {
                    TbxRestfemale.Checked = true;
                }
                TbxRestmail.Text = ManagerGlobalValues.UserSelected.Email;
                TbxRestaddress.Text = ManagerGlobalValues.UserSelected.Address;
                TbxResttele.Text = ManagerGlobalValues.UserSelected.MobilePhone;
                TbxResttime.Text = ManagerGlobalValues.UserSelected.LastLogin;
            }
            else
            {
                return;
            }
           //隐藏查找餐馆信息的界面，显示餐馆人员详细信息的界面
            PnlLFrestaurant.Visible = true;
            PnlModifyrestaurant.Visible = true;

            
            //将餐馆信息的错误信息控件显示出来          
            LabRestnamelimit.Visible = true;
            LabRestmaillimit.Visible = true;
            LabRestaddresslimit.Visible = true;
            LabResttelelimit.Visible = true;

            //将该textbox变成可写起来
            TbxRestname.ReadOnly = false;
            TbxRestmail.ReadOnly = false;
            TbxRestaddress.ReadOnly = false;
            TbxResttele.ReadOnly = false;
            //将该显示的控件显示出来
            GplRestsex.Visible = true;
            TbxRestname.Visible = true;
            TbxRestmail.Visible = true;
            TbxRestaddress.Visible = true;
            TbxResttele.Visible = true;

            //显示性别和身份的textbox
            TbxRestmale.Visible = true;
            TbxRestfemale.Visible = true;
            //隐藏性别和身份的组合框
            //TbxRestidentify.Visible = false;
            TbxRestsex.Visible = false;
            //显示保存按钮，隐藏删除按钮
            BtnRestsaveinfor.Visible = true;
            BtnRestdeleteinfor.Visible = false;

            
        }

        //管理餐馆人员时信息时，点击保存时，要将控件变成不可写
        private void BtnRestsaveinfor_Click(object sender, EventArgs e)
        {

            //将餐馆信息的错误信息控件隐藏          
            LabRestnamelimit.Visible = false;
            LabRestmaillimit.Visible = false;
            LabRestaddresslimit.Visible = false;
            LabResttelelimit.Visible = false;

            //将该textbox变成可写起来
            TbxRestname.ReadOnly = true;
            TbxRestmail.ReadOnly = true;
            TbxRestaddress.ReadOnly = true;
            TbxResttele.ReadOnly = true;
            //将该显示的控件显示出来
            GplRestsex.Visible = true;
            TbxRestname.Visible = true;
            TbxRestmail.Visible = true;
            TbxRestaddress.Visible = true;
            TbxResttele.Visible = true;

            //隐藏性别和身份的textbox
            TbxRestmale.Visible = false;
            TbxRestfemale.Visible = false;
            GplRestsex.Visible = false;
            //显示性别和身份的组合框
            TbxRestidentify.Visible = true;
            TbxRestsex.Visible = true;
           
            //隐藏保存按钮
            BtnRestsaveinfor.Visible = false;

            //重置焦点信息
            ManagerGlobalValues.IsRestaurantSelected = false;

            String sex = "";
            if (TbxRestmale.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }

            bool isExcute = ManageRestaurant.ChangeMessage(ManagerGlobalValues.UserSelected.ID, ManagerGlobalValues.UserSelected.PassWord, TbxRestname.Text, sex, TbxRestmail.Text, TbxResttele.Text, TbxRestaddress.Text);

            TbxRestsex.Text = sex;

            if (isExcute)
            {
                MessageBox.Show("修改成功!");
            }
            else
            {
                MessageBox.Show("修改失败!");
            }
        }

        //左侧的“餐馆管理”中的“删除餐馆人员信息”
        private void LabRestdelete_Click(object sender, EventArgs e)
        {
            //获取选中餐馆人员的信息
            if (ManagerGlobalValues.IsRestaurantSelected)
            {
                TbxRestid.Text = ManagerGlobalValues.UserSelected.ID;
                TbxRestname.Text = ManagerGlobalValues.UserSelected.Name;
                TbxRestidentify.Text = ManagerGlobalValues.UserSelected.Role;
                TbxRestsex.Text = ManagerGlobalValues.UserSelected.Sex;
                TbxRestmail.Text = ManagerGlobalValues.UserSelected.Email;
                TbxRestaddress.Text = ManagerGlobalValues.UserSelected.Address;
                TbxResttele.Text = ManagerGlobalValues.UserSelected.MobilePhone;
                TbxResttime.Text = ManagerGlobalValues.UserSelected.LastLogin;
            }
            else
            {
                return;
            }
            // //隐藏查找餐馆信息的界面，显示餐馆人员详细信息的界面
            PnlLFrestaurant.Visible = true;
            PnlModifyrestaurant.Visible = true;

            //将该textbox变成不可写起来
            TbxRestname.ReadOnly = true;
            TbxRestmail.ReadOnly = true;
            TbxRestaddress.ReadOnly = true;
            TbxResttele.ReadOnly = true;
            //将该显示的控件显示出来
            GplRestsex.Visible = true;
            TbxRestname.Visible = true;
            TbxRestmail.Visible = true;
            TbxRestaddress.Visible = true;
            TbxResttele.Visible = true;

            //隐藏性别和身份的textbox
            GplRestsex.Visible = false;
            TbxRestmale.Visible = false;
            TbxRestfemale.Visible = false;
            //显示性别和身份的组合框
            TbxRestidentify.Visible = true;
            TbxRestsex.Visible = true;
            //隐藏保存按钮，显示删除按钮
            BtnRestsaveinfor.Visible = false;
            BtnRestdeleteinfor.Visible = true;

        }
        //点击删除菜单信息按钮
        private void BtnRestdeleteinfor_Click(object sender, EventArgs e)
        {   
            //隐藏删除按钮
            BtnRestdeleteinfor.Visible = false;

            //重置焦点
            ManagerGlobalValues.IsRestaurantSelected = false;

            bool isExcute = ManageRestaurant.DelMessage(ManagerGlobalValues.UserSelected.ID);
            if (isExcute)
            {
                MessageBox.Show("删除成功!");
            }
            else
            {
                MessageBox.Show("删除失败!");
            }
        }

        private void ExpFunchoose_ExpandedChanged_1(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (this.TcManager.SelectedTab == this.TcpManager)
            {
                ExpManage.Visible = true;
                ExpStumanage.Visible = false;
                ExpRestmanage.Visible = false;
            }
            else if (this.TcManager.SelectedTab == this.TcpStudent)
            {
                ExpStumanage.Visible = true;
                ExpManage.Visible = false;
                ExpRestmanage.Visible = false;
            }
            else if (this.TcManager.SelectedTab == this.TcpRestaurant)
            {
                ExpRestmanage.Visible = true;
                ExpStumanage.Visible = false;
                ExpManage.Visible = false;
            }

        }

    

        #region//------------------------------------------管理员修改个人信息时的检测语句---------------------------------------------

        

        /// <summary>
        /// 判断是否应该显示保存按钮（管理员个人信息）
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
        /// 检测管理员的密码信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxPassword_TextChanged(object sender, EventArgs e)//0
        {
            result = DlgRegisterUserCheck.Check_PassWord(TbxPassword.Text);
            isAllRight_Person[0] = result.Flag;
            if (result.Flag)
            {
                LabPasswordlimit.Text = null;//提示信息
                Judge_isAllRight_Person();
            }
            else
            {
                BtnSaveinfor.Enabled = false;
                LabPasswordlimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测管理员的确认密码信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxRpassword_TextChanged(object sender, EventArgs e)//1
        {
            if (TbxRpassword.Text.Equals(TbxPassword.Text))
            {
                LabRpasswordlimit.Text = null;//提示信息
                isAllRight_Person[1] = true;
                Judge_isAllRight_Person();
            }
            else
            {
                isAllRight_Person[1] = false;
                BtnSaveinfor.Enabled = false;
                LabRpasswordlimit.Text = "两次密码不一样！";//提示信息
            }
        }

        /// <summary>
        /// 检测管理员的姓名信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxName_TextChanged(object sender, EventArgs e)//2
        {
            result = DlgRegisterUserCheck.Check_Name(TbxName.Text);
            isAllRight_Person[2] = result.Flag;
            if (result.Flag)
            {
                LabNamelimit.Text = null;//提示信息
                Judge_isAllRight_Person();
            }
            else
            {
                BtnSaveinfor.Enabled = false;
                LabNamelimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测管理员的邮箱信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxMail_TextChanged(object sender, EventArgs e)//3
        {
            result = DlgRegisterUserCheck.Check_Email(TbxMail.Text);
            isAllRight_Person[3] = result.Flag;
            if (result.Flag)
            {
                LabMaillimit.Text = null;//提示信息
                Judge_isAllRight_Person();
            }
            else
            {
                BtnSaveinfor.Enabled = false;
                LabMaillimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测管理员的地址信息是否合法
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
        /// 检测管理员的手机信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxTele_TextChanged(object sender, EventArgs e)//5
        {
            result = DlgRegisterUserCheck.Check_Phone(TbxTele.Text);
            isAllRight_Person[5] = result.Flag;
            if (result.Flag)
            {
                LabTelelimit.Text = null;//提示信息
                Judge_isAllRight_Person();
            }
            else
            {
                BtnSaveinfor.Enabled = false;
                LabTelelimit.Text = result.Msg;//提示信息
            }
        }

        #endregion



        #region//------------------------------------------管理员修改学员信息时的检测语句---------------------------------------------


        /// <summary>
        /// 判断是否应该显示保存按钮（学员信息）
        /// </summary>
        private void Judge_isAllRight_Student()
        {
            for (int i = 0; i < isAllRight_Student.Length; i++)
            {
                if (!isAllRight_Student[i])
                {
                    BtnStusaveinfor.Enabled = false;
                    return;
                }
            }
            BtnStusaveinfor.Enabled = true;
        }
        
        /// <summary>
        /// 检测学生的姓名信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxStuname_TextChanged(object sender, EventArgs e)//0
        {
            result = DlgRegisterUserCheck.Check_Name(TbxStuname.Text);
            isAllRight_Student[0] = result.Flag;
            if (result.Flag)
            {
                LabStunamelimit.Text = null;//提示信息
                Judge_isAllRight_Student();
            }
            else
            {
                BtnStusaveinfor.Enabled = false;
                LabStunamelimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测学生的邮箱信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxStumail_TextChanged(object sender, EventArgs e)//1
        {
            result = DlgRegisterUserCheck.Check_Email(TbxStumail.Text);
            isAllRight_Student[1] = result.Flag;
            if (result.Flag)
            {
                LabStumaillimit.Text = null;//提示信息
                Judge_isAllRight_Student();
            }
            else
            {
                BtnStusaveinfor.Enabled = false;
                LabStumaillimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测学生的地址信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxStuaddress_TextChanged(object sender, EventArgs e)//2
        {
            result = DlgRegisterUserCheck.Check_Address(TbxStuaddress.Text);
            isAllRight_Student[2] = result.Flag;
            if (result.Flag)
            {
                LabStuaddresslimit.Text = null;//提示信息
                Judge_isAllRight_Student();
            }
            else
            {
                BtnStusaveinfor.Enabled = false;
                LabStuaddresslimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测学生的电话信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxStutele_TextChanged(object sender, EventArgs e)//3
        {
            result = DlgRegisterUserCheck.Check_Phone(TbxStutele.Text);
            isAllRight_Student[3] = result.Flag;
            if (result.Flag)
            {
                LabStutelelimit.Text = null;//提示信息
                Judge_isAllRight_Student();
            }
            else
            {
                BtnStusaveinfor.Enabled = false;
                LabStutelelimit.Text = result.Msg;//提示信息
            }
        }


        #endregion



        #region//------------------------------------------管理员修改餐馆信息时的检测语句---------------------------------------------


        /// <summary>
        /// 判断是否应该显示保存按钮（餐馆信息）
        /// </summary>
        private void Judge_isAllRight_Restaurant()
        {
            for (int i = 0; i < isAllRight_Restaurant.Length; i++)
            {
                if (!isAllRight_Restaurant[i])
                {
                    BtnRestsaveinfor.Enabled = false;
                    return;
                }
            }
            BtnRestsaveinfor.Enabled = true;
        }

        /// <summary>
        /// 检测学生的姓名信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxRestname_TextChanged(object sender, EventArgs e)//0
        {
            result = DlgRegisterUserCheck.Check_Name(TbxRestname.Text);
            isAllRight_Restaurant[0] = result.Flag;
            if (result.Flag)
            {
                LabRestnamelimit.Text = null;//提示信息
                Judge_isAllRight_Restaurant();
            }
            else
            {
                BtnRestsaveinfor.Enabled = false;
                LabRestnamelimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测学生的邮箱信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxRestmail_TextChanged(object sender, EventArgs e)//1
        {
            result = DlgRegisterUserCheck.Check_Email(TbxRestmail.Text);
            isAllRight_Restaurant[1] = result.Flag;
            if (result.Flag)
            {
                LabRestmaillimit.Text = null;//提示信息
                Judge_isAllRight_Restaurant();
            }
            else
            {
                BtnRestsaveinfor.Enabled = false;
                LabRestmaillimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测学生的地址信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxRestaddress_TextChanged(object sender, EventArgs e)//2
        {
            result = DlgRegisterUserCheck.Check_Address(TbxRestaddress.Text);
            isAllRight_Restaurant[2] = result.Flag;
            if (result.Flag)
            {
                LabRestaddresslimit.Text = null;//提示信息
                Judge_isAllRight_Restaurant();
            }
            else
            {
                BtnRestsaveinfor.Enabled = false;
                LabRestaddresslimit.Text = result.Msg;//提示信息
            }
        }

        /// <summary>
        /// 检测学生的手机信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxResttele_TextChanged(object sender, EventArgs e)//3
        {
            result = DlgRegisterUserCheck.Check_Phone(TbxResttele.Text);
            isAllRight_Restaurant[3] = result.Flag;
            if (result.Flag)
            {
                LabResttelelimit.Text = null;//提示信息
                Judge_isAllRight_Restaurant();
            }
            else
            {
                BtnRestsaveinfor.Enabled = false;
                LabResttelelimit.Text = result.Msg;//提示信息
            }
        }


        #endregion



        private void CSDlgManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Loginout.LoginOut(LoginMsg.LoginName);
            Client.close();
            e.Cancel = true;
            this.Dispose();
            Application.Exit();
        }

        private void CSDlgManager_Load(object sender, EventArgs e)
        {
            TcpManager_Click(sender, e);
        }



    }
}
