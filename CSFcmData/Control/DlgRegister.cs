using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSFcmData.Model.ErrorMsg;
using CSFcmData.Control.FcmDlgRegister;

namespace CSFcmData.Control.FcmDlgRegister
{



    public class DlgRegisterUserCheck
    {
        static ErrorMsg error_msg = new ErrorMsg();


        /// <summary>
        /// 重置error_msg
        /// </summary>
        private static void Reset_True()
        {
            error_msg.Flag=true;
        }


        /// <summary>
        /// 检测用户ID信息是否有误
        /// </summary>
        /// <param name="ID">用户账号信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_ID(String ID)//ID
        {
            Reset_True();
            if (String.IsNullOrEmpty(ID))
            {
                error_msg.Flag = false;
                error_msg.Msg = "用户ID不可以为空!";
                return error_msg;
            }
            if (!Char.IsLetter(ID[0]))
            {
                error_msg.Flag = false;
                error_msg.Msg = "用户ID必须以字母开始!";
                return error_msg;
            }
            for (int i = 0; i < ID.Length; i++)
            {
                if (!(Char.IsNumber(ID[i]) || Char.IsLetter(ID[i]) || ID[i].Equals('_') || ID[i].Equals('-')))
                {
                    error_msg.Flag = false;
                    error_msg.Msg = "用户ID含有非法字符!";
                    return error_msg;
                }
            }
            if (error_msg.Flag)
            {
                error_msg.Flag = DlgRegisterDo.CheckUserID(ID);
                error_msg.Msg = "用户ID已存在！";
            }
            return error_msg;
        }


        /// <summary>
        /// 检测用户密码信息是否有误
        /// </summary>
        /// <param name="PW">用户密码信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_PassWord(String PW)//PassWord
        {
            Reset_True();
            bool IsExistUpper = false;
            bool IsExistLower = false;
            bool IsExistNumber = false;
            if (String.IsNullOrEmpty(PW))
            {
                error_msg.Flag = false;
                error_msg.Msg = "密码不能为空!";
                return error_msg;
            }
            for (int i = 0; i < PW.Length; i++)
            {
                if (Char.IsUpper(PW[i]))
                {
                    IsExistUpper = true;
                }
                if (Char.IsLower(PW[i]))
                {
                    IsExistLower = true;
                }
                if (Char.IsNumber(PW[i]))
                {
                    IsExistNumber = true;
                }
            }
            if (!(IsExistUpper && IsExistLower && IsExistNumber))
            {
                error_msg.Flag = false;
                error_msg.Msg = "密码必须含有大小写字母和数字!";
                return error_msg;
            }
            return error_msg;
        }


        /// <summary>
        /// 检测用户姓名信息是否有误
        /// </summary>
        /// <param name="Name">用户姓名信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_Name(String Name)//Name
        {
            Reset_True();
            if (String.IsNullOrEmpty(Name))
            {
                error_msg.Flag = false;
                error_msg.Msg = "姓名不能为空!";
                return error_msg;
            }
            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] <= 127) 
                {
                    error_msg.Flag = false;
                    error_msg.Msg = "姓名必须是汉字!";
                    return error_msg;
                }
            }
            return error_msg;
        }


        /// <summary>
        /// 检测用户邮箱信息是否有误
        /// </summary>
        /// <param name="Email">用户邮箱信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_Email(String Email)//Email
        {
            Reset_True();
            int index_AT = 0, index_PT = 0;
            bool IsExist_AT = false, IsExist_PT = false;

            if (String.IsNullOrEmpty(Email))
            {
                error_msg.Flag = false;
                error_msg.Msg = "邮箱地址不能为空!";
                return error_msg;
            }

            for (int i = 0; i < Email.Length; i++)
            {
                if (Email[i].Equals('@'))
                {
                    index_AT = i;
                    IsExist_AT = true;
                }
                if (Email[i].Equals('.'))
                {
                    index_PT = i;
                    IsExist_PT = true;
                }
            }
            if (!(IsExist_AT && IsExist_PT))
            {
                error_msg.Flag = false;
                error_msg.Msg = "邮箱地址格式不正确!";
                return error_msg;
            }
            if (index_AT == 0 || index_AT + 1 >= index_PT || index_PT == Email.Length - 1)
            {
                error_msg.Flag = false;
                error_msg.Msg = "邮箱地址格式不正确!";
                return error_msg;
            }
            return error_msg;
        }


        /// <summary>
        /// 检测用户电话号码信息是否有误
        /// </summary>
        /// <param name="MP">用户电话号码信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_Phone(String MP)//MobilePhone
        {
            Reset_True();
            if (String.IsNullOrEmpty(MP))
            {
                error_msg.Flag = false;
                error_msg.Msg = "电话不能为空!";
                return error_msg;
            }
            for (int i = 0; i < MP.Length; i++)
            {
                if (!Char.IsNumber(MP[i]))
                {
                    error_msg.Flag = false;
                    error_msg.Msg = "电话号码只能填写数字!";
                    return error_msg;
                }
            }
            if (MP.Length != 11)
            {
                error_msg.Flag = false;
                error_msg.Msg = "电话号码只能是11位数字!";
                return error_msg;
            }
            return error_msg;
        }


        /// <summary>
        /// 检测用户地址信息是否有误
        /// </summary>
        /// <param name="Addr">用户地址信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_Address(String Addr)//Address
        {
            Reset_True();
            if (String.IsNullOrEmpty(Addr))
            {
                error_msg.Flag = false;
                error_msg.Msg = "地址不能为空!";
                return error_msg;
            }
            for (int i = 0; i < Addr.Length; i++)
            {
                if (Addr[i] <= 127)
                {
                    error_msg.Flag = false;
                    error_msg.Msg = "地址必须是汉字!";
                    return error_msg;
                }
            }
            return error_msg;
        }
    }




    public class DlgRegisterMenuCheck
    {
        static ErrorMsg error_msg = new ErrorMsg();


        /// <summary>
        /// 重置error_msg
        /// </summary>
        private static void Reset_True()
        {
            error_msg.Flag = true;
        }


        /// <summary>
        /// 检测菜单ID信息是否有误
        /// </summary>
        /// <param name="ID">菜单ID信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_ID(String ID)//ID
        {
            Reset_True();
            if (ID.Length < 1)
            {
                error_msg.Flag = false;
                error_msg.Msg = "Id不能为空！";
                return error_msg;
            }
            if (ID.Length > 16)
            {
                error_msg.Flag = false;
                error_msg.Msg = "ID过长！";
                return error_msg;
            }
            foreach (char chr in ID)
            {
                if (!char.IsDigit(chr))
                {
                    error_msg.Flag = false;
                    error_msg.Msg = "ID只能含有数字！";
                    return error_msg;
                }
            }
            return error_msg;
        }


        /// <summary>
        /// 检测菜单名称信息是否有误
        /// </summary>
        /// <param name="Name">菜单名称信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_Name(String Name)//Name
        {
            Reset_True();
            if (Name.Length < 1)
            {
                error_msg.Flag = false;
                error_msg.Msg = "菜名不能为空！";
                return error_msg;
            }
            return error_msg;
        }


        /// <summary>
        /// 检测菜单价格信息是否有误
        /// </summary>
        /// <param name="Name">菜单价格信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_Price(String Price)//Price
        {
            Reset_True();
            if (Price.Length < 1)
            {
                error_msg.Flag = false;
                error_msg.Msg = "菜价不能为空！";
                return error_msg;
            }
            int point = 0;
            foreach (char chr in Price)
            {
                if (char.IsDigit(chr))
                    continue;
                else if (chr == '.' && point == 0)
                    point++;
                else
                {
                    error_msg.Flag = false;
                    error_msg.Msg = "菜价不合法！";
                    return error_msg;
                }
            }
            return error_msg;
        }


        /// <summary>
        /// 检测菜单类别信息是否有误
        /// </summary>
        /// <param name="Name">菜单类别信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_Type(String Type)//Type
        {
            Reset_True();
            if (Type.Length < 1)
            {
                error_msg.Flag = false;
                error_msg.Msg = "类别不能为空！";
                return error_msg;
            }
            return error_msg;
        }


        /// <summary>
        /// 检测菜单评分信息是否有误
        /// </summary>
        /// <param name="Name">菜单评分信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_TotalScore(String TotalScore)//TotalScore
        {
            Reset_True();
            if (TotalScore.Length < 1 || !TotalScore.Equals("0"))
            {
                error_msg.Flag = false;
                error_msg.Msg = "初始评分必须为零！";
                return error_msg;
            }
            return error_msg;
        }


        /// <summary>
        /// 检测菜单描述信息是否有误
        /// </summary>
        /// <param name="Name">菜单描述信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_Description(String Description)//Description
        {
            Reset_True();
            if (Description.Length < 1)
            {
                error_msg.Flag = false;
                error_msg.Msg = "描述不能为空！";
                return error_msg;
            }
            return error_msg;
        }


        /// <summary>
        /// 检测菜单描述信息是否有误
        /// </summary>
        /// <param name="Name">菜单描述信息</param>
        /// <returns>错误信息</returns>
        public static ErrorMsg Check_SoldNum(String SoldNum)//SoldNum
        {
            Reset_True();
            if (SoldNum.Length < 1 || !SoldNum.Equals("0"))
            {
                error_msg.Flag = false;
                error_msg.Msg = "售出餐数必须为零！";
                return error_msg;
            }
            return error_msg;
        }
    }



}
