using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Collections;
using CSFcmData.Model.DataBase;

namespace CSFcmData.Control.FcmDataBase
{
    public class DbConnect
    {
        /// <summary>
        /// 实现数据库信息的插入，修改，删除功能
        /// </summary>
        /// <param name="strSQL">端口所需的SQL语句</param>
        public static void Operate(String strSQL)  //strSQL是你写的SQL语句,插入,删除，修改
        {
            String Constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=shujuku.accdb;Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(Constr);//实例化数据库连接
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        /// <summary>
        /// 实现数据库查询功能的端口
        /// </summary>
        /// <param name="strSQL">端口所需的查询SQL语句</param>
        /// <returns>返回表数据模型类型的ArrayList结果集合</returns>
        public static ArrayList Query(String strSQL)//查询
        {
            ArrayList T = new ArrayList();
            String TableName = intercept(strSQL);//截取所查询的表名
            String Constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=shujuku.accdb;Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(Constr);//实例化数据库连接
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                cmd.ExecuteNonQuery();
                OleDbDataReader ord = cmd.ExecuteReader();
                T = GetArrayList(TableName,ord);
                conn.Close();
            }
            catch (Exception err)
            {
                throw err;
            }
            return T;
        }


        /// <summary>
        /// 截取SQL语句中操作的表名，只提供内部调用
        /// </summary>
        /// <param name="SQL">提供截取的SQL语句</param>
        /// <returns>返回操作表的名字</returns>
        private static String intercept(String SQL)
        {
            int a = 0;
            String str = null;
            String y = null;
            foreach (char chr in SQL)
            {
                if (a != 3)
                {
                    if (chr.Equals(' '))
                        a++;
                }
                else
                {
                    if (!chr.Equals(' '))
                        str += chr.ToString();
                    else
                        break;
                }
            }
            foreach (char x in str)
            {
                if (!x.Equals('[') && !x.Equals(']'))
                    y += x.ToString();
            }
            return y;
        }

        /// <summary>
        /// 对查询所得结果集进行赋值操作
        /// </summary>
        /// <param name="tablename">SQL语句的表名</param>
        /// <param name="ord">查询后所得结果集</param>
        /// <returns>返回各自类型查询结果</returns>
        private static ArrayList GetArrayList(String tablename,OleDbDataReader ord)
        {
            ArrayList result = new ArrayList();


            /*查询User表*/
            if (tablename.Equals("User"))
            {
                User user;
                while (ord.Read())
                {
                    user = new User();
                    user.ID = ord[0].ToString();
                    user.PassWord = ord[1].ToString();
                    user.Role = ord[2].ToString();
                    user.Name = ord[3].ToString();
                    user.Sex = ord[4].ToString();
                    user.Email = ord[5].ToString();
                    user.MobilePhone = ord[6].ToString();
                    user.Address = ord[7].ToString();
                    user.LastLogin = ord[8].ToString();
                    result.Add(user);
                }
            }


            /*查询Menu表*/
            if (tablename.Equals("Menu"))
            {
                Menu menu;
                while (ord.Read())
                {
                    menu = new Menu();
                    menu.ID = ord[0].ToString();
                    menu.Name = ord[1].ToString();
                    menu.Type = ord[2].ToString();
                    menu.Description = ord[3].ToString();
                    menu.TotleScore = ord[4].ToString();
                    menu.SoldNum = ord[5].ToString();
                    menu.Price = ord[6].ToString();
                    menu.Special = ord[7].ToString();
                    menu.Status = ord[8].ToString();
                    menu.ImagePath = ord[9].ToString();
                    menu.ID_Restaurant = ord[10].ToString();
                    result.Add(menu);
                }     
            }


            /*查询ShopCar表*/
            if (tablename.Equals("ShopCar"))
            {
                ShopCar sp;
                while (ord.Read())
                {
                    sp = new ShopCar();
                    sp.ID_User = ord[0].ToString();
                    sp.Name_User = ord[1].ToString();
                    sp.ID_Menu = ord[2].ToString();
                    sp.Name_Menu = ord[3].ToString();
                    sp.Num = ord[4].ToString();
                    sp.Price = ord[5].ToString();
                    sp.Totle = ord[6].ToString();
                    result.Add(sp);
                }
            }


            /*查询Order表*/
            if (tablename.Equals("Order"))
            {
                Order od;
                while (ord.Read())
                {
                    od = new Order();
                    od.ID = ord[0].ToString();
                    od.ID_Menu = ord[1].ToString();
                    od.Name_Menu = ord[2].ToString();
                    od.ID_User = ord[3].ToString();
                    od.Name_User = ord[4].ToString();
                    od.Time = ord[5].ToString();
                    od.Num = ord[6].ToString();
                    od.Price = ord[7].ToString();
                    od.Totle = ord[8].ToString();
                    result.Add(od);
                }
            }
            return result;
        }
    }
}
