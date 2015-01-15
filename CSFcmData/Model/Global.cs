using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using CSFcmData.Model.DataBase;

namespace CSFcmData.Model.Global
{
    //程序登录信息
    public class LoginMsg
    {
        /// <summary>
        /// 判断登录状态
        /// </summary>
        private static bool isLogin;

        public static bool IsLogin
        {
            get { return LoginMsg.isLogin; }
            set { LoginMsg.isLogin = value; }
        }

        /// <summary>
        /// 存储登录身份
        /// </summary>
        private static String identify;

        public static String Identify
        {
            get { return LoginMsg.identify; }
            set { LoginMsg.identify = value; }
        }

        /// <summary>
        /// 存储登录用户名
        /// </summary>
        private static String loginName;

        public static String LoginName
        {
            get { return LoginMsg.loginName; }
            set { LoginMsg.loginName = value; }
        }
    }
    //程序网络连接状态
    public class SocketConnectState
    {
        /// <summary>
        /// 判断是否网络处于连接状态
        /// </summary>
        private static bool state;

        public static bool State
        {
            get { return state; }
            set { state = value; }
        }
    }


    //程序子窗体状态
    public class LoginWindowState
    {
        private static bool isPop = false;

        public static bool IsPop
        {
            get { return LoginWindowState.isPop; }
            set { LoginWindowState.isPop = value; }
        }
    }


    //程序管理员全局记录信息
    public class ManagerGlobalValues
    {
        private static bool isStudentSelected = false;

        public static bool IsStudentSelected
        {
            get { return ManagerGlobalValues.isStudentSelected; }
            set { ManagerGlobalValues.isStudentSelected = value; }
        }
        private static bool isRestaurantSelected = false;

        public static bool IsRestaurantSelected
        {
            get { return ManagerGlobalValues.isRestaurantSelected; }
            set { ManagerGlobalValues.isRestaurantSelected = value; }
        }
        private static User userSelected = new User();

        public static User UserSelected
        {
            get { return ManagerGlobalValues.userSelected; }
            set { ManagerGlobalValues.userSelected = value; }
        }

    }

    //学生窗体中菜单项显示
    public class StudentMenuMessage
    {
        private static ArrayList menu=new ArrayList();

        public static ArrayList Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        private static int selectedIndex;

        public static int SelectedIndex
        {
            get { return StudentMenuMessage.selectedIndex; }
            set { StudentMenuMessage.selectedIndex = value; }
        }

        public static void clear()
        {
            menu.Clear();
        }
    }

    //学生窗体购物车显示控制
    public class StudentShopCarMessage
    {
        private static ArrayList shopCar = new ArrayList();

        public static ArrayList ShopCar
        {
            get { return StudentShopCarMessage.shopCar; }
            set { StudentShopCarMessage.shopCar = value; }
        }

        private static ArrayList shopCarSelectedIndex = new ArrayList();

        public static ArrayList ShopCarSelectedIndex
        {
            get { return StudentShopCarMessage.shopCarSelectedIndex; }
            set { StudentShopCarMessage.shopCarSelectedIndex = value; }
        }
    }
}
