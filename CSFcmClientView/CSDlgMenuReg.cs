using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CSFcmData.Control.FcmDlgRegister;
using CSFcmData.Model.ErrorMsg;
using CSFcmData.Model.Global;

namespace CSFcmClientView
{
    public partial class CSDlgMenuReg : DevComponents.DotNetBar.Office2007Form
    {
        ErrorMsg result;//接收检测的错误信息
        bool[] isAllRight;//记录信息的错误与正确

        public CSDlgMenuReg()
        {
            InitializeComponent();
            isAllRight = new bool[7];
        }
        //点击“浏览”按钮时，弹出对话框，供用户选择图片文件
        private void Btnscan_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            String filename = ofd.FileName;
            string fileContentType = Path.GetExtension(ofd.FileName);
            if (fileContentType == ".bmp" || fileContentType == ".gif" || fileContentType == ".jpg")
            {

                Image tempimage = System.Drawing.Image.FromFile(ofd.FileName);
                TxbPicture.Text = ofd.FileName;
                if (File.Exists(TxbPicture.Text))//如果文件存在，再判断大小是否合适
                {
                    int wid = tempimage.Width;
                    int hei = tempimage.Height;
                    if (wid != 140 || hei != 105)
                    {
                        MessageBox.Show(this, "图片文件大小应为140*105!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxbPicture.Text = "";
                    }
                    else
                    {
                        TxbPicture.Text = ofd.FileName;
                        RefImage.Image = System.Drawing.Image.FromFile(TxbPicture.Text);
                    }
                }

            }
            else
            {
                MessageBox.Show(this, "请选择图片文件!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbPicture.Text = "";
            }

        }
        
        /// <summary>
        /// 注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            String status="不可订购",special="不特色";
            if(TbxCanbuy.Checked==true)
                status="可订购";
            if(TbxSpe.Checked==true)
                special="特色";
            if (DlgRegisterDo.MenuReg(TxbId.Text, TxbName.Text, TxbType.Text, TxbDescribe.Text, TxbScore.Text, "0", TxbPrice.Text, special, status, TxbPicture.Text, LoginMsg.LoginName))
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }

        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            //TextBox控件清空
            TxbId.Text = null;
            TxbName.Text = null;
            TxbPrice.Text = null;
            TxbType.Text = null;
            TxbScore.Text = null;
            TxbDescribe.Text = null;
            TbxCanbuy.Checked = true;
            TbxSpe.Checked = true;

            //Lable控件清空
            LabTxbId.Text = null;
            LabTxbName.Text = null;
            LabTxbPrice.Text = null;
            LabTxbType.Text = null;
            LabTxbScore.Text = null;
            LabTxbPicture.Text="请选择图片！";
            LabTxbDescribe.Text = null;
        }

        /////////////////////////////////////////////////////////////////////////////检测注册的菜单信息是否正确

        /// <summary>
        /// 判断是否应该显示注册按钮
        /// </summary>
        private void Judge_isAllRight()
        {
            for (int i = 0; i < isAllRight.Length; i++)
            {
                if (!isAllRight[i])
                {
                    BtnRegister.Enabled = false;
                    return;
                }
            }
            BtnRegister.Enabled = true;
        }

        /// <summary>
        /// 检测餐馆输入的菜单ID信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbId_TextChanged(object sender, EventArgs e)
        {
            result = DlgRegisterMenuCheck.Check_ID(TxbId.Text);
            isAllRight[0] = result.Flag;
            if (result.Flag)
            {
                LabTxbId.Text = null;
                Judge_isAllRight();
            }
            else
            {
                BtnRegister.Enabled = false;
                LabTxbId.Text = result.Msg;
            }
        }

        /// <summary>
        /// 检测餐馆输入的密码信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbName_TextChanged(object sender, EventArgs e)//1
        {
            result = DlgRegisterMenuCheck.Check_Name(TxbName.Text);
            isAllRight[1] = result.Flag;
            if (result.Flag)
            {
                LabTxbName.Text = null;
                Judge_isAllRight();
            }
            else
            {
                BtnRegister.Enabled = false;
                LabTxbName.Text = result.Msg;
            }
        }

        /// <summary>
        /// 检测餐馆输入的菜价信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbPrice_TextChanged(object sender, EventArgs e)//2
        {
            result = DlgRegisterMenuCheck.Check_Price(TxbPrice.Text);
            isAllRight[2] = result.Flag;
            if (result.Flag)
            {
                LabTxbPrice.Text = null;
                Judge_isAllRight();
            }
            else
            {
                BtnRegister.Enabled = false;
                LabTxbPrice.Text = result.Msg;
            }
        }

        /// <summary>
        /// 检测餐馆输入的类别信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbType_TextChanged(object sender, EventArgs e)//3
        {
            result = DlgRegisterMenuCheck.Check_Type(TxbType.Text);
            isAllRight[3] = result.Flag;
            if (result.Flag)
            {
                LabTxbType.Text = null;
                Judge_isAllRight();
            }
            else
            {
                BtnRegister.Enabled = false;
                LabTxbType.Text = result.Msg;
            }
        }

        /// <summary>
        /// 检测餐馆输入的评分信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbScore_TextChanged(object sender, EventArgs e)//4
        {
            result = DlgRegisterMenuCheck.Check_TotalScore(TxbScore.Text);
            isAllRight[4] = result.Flag;
            if (result.Flag)
            {
                LabTxbScore.Text = null;
                Judge_isAllRight();
            }
            else
            {
                BtnRegister.Enabled = false;
                LabTxbScore.Text = result.Msg;
            }
        }

        /// <summary>
        /// 检测餐馆输入的图片信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbPicture_TextChanged(object sender, EventArgs e)//5
        {
            if (TxbPicture.Text != "")
            {
                isAllRight[5] = true;
                LabTxbPicture.Text = null;
                Judge_isAllRight();
            }
            else
            {
                isAllRight[5] = false;
                LabTxbPicture.Text = "请选择图片！";
            }
        }

        /// <summary>
        /// 检测餐馆输入的描述信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbDescribe_TextChanged(object sender, EventArgs e)//6
        {
            result = DlgRegisterMenuCheck.Check_Description(TxbDescribe.Text);
            isAllRight[6] = result.Flag;
            if (result.Flag)
            {
                LabTxbDescribe.Text = null;
                Judge_isAllRight();
            }
            else
            {
                BtnRegister.Enabled = false;
                LabTxbDescribe.Text = result.Msg;
            }
        }


    }
}
