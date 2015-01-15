using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSFcmData.Control.FcmDlgRegister;
using CSFcmData.Model.ErrorMsg;

namespace CSFcmClientView
{
    public partial class CSDlgUserReg : DevComponents.DotNetBar.Office2007Form
    {
        
        public CSDlgUserReg()
        {
            InitializeComponent();
            isAllRight = new bool[7];
            SIdentity.SelectedIndex = 0;
        }
        
        ErrorMsg result;
        bool[] isAllRight;


        /// <summary>
        /// 判断是否应该显示注册按钮
        /// </summary>
        private void Judge_isAllRight()
        {
            for (int i = 0; i < isAllRight.Length; i++)
            {
                if (!isAllRight[i])
                {
                    SRegister.Enabled = false;
                    return;
                }
            }
            SRegister.Enabled = true;
        }

        /// <summary>
        /// 检测用户输入的ID信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SID_TextChanged(object sender, EventArgs e)//0
        {
            if (SID.Text != "")
            {
                result = DlgRegisterUserCheck.Check_ID(SID.Text);
                isAllRight[0] = result.Flag;
                if (result.Flag)
                {
                    LabSID.Text = null;
                    Judge_isAllRight();
                }
                else
                {
                    SRegister.Enabled = false;
                    LabSID.Text = result.Msg;
                }
            }
            else
            {
                LabSID.Text = null;
            }
        }

        /// <summary>
        /// 检测用户输入的密码信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SPassword_TextChanged(object sender, EventArgs e)//1
        {
            if (SPassword.Text != "")
            {
                SRPassword.Text = null;
                result = DlgRegisterUserCheck.Check_PassWord(SPassword.Text);
                isAllRight[1] = result.Flag;
                if (result.Flag)
                {
                    LabSPassword.Text = null;
                    Judge_isAllRight();
                }
                else
                {
                    SRegister.Enabled = false;
                    LabSPassword.Text = result.Msg;
                }
            }
            else
            {
                LabSPassword.Text = null;
            }
        }

        /// <summary>
        /// 检测用户输入的第二次密码信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SRPassword_TextChanged(object sender, EventArgs e)//2
        {
            if (SRPassword.Text != "")
            {
                if (SRPassword.Text.Equals(SPassword.Text))
                {
                    LabSRPassword.Text = null;
                    isAllRight[2] = true;
                    Judge_isAllRight();
                }
                else
                {
                    isAllRight[2] = false;
                    SRegister.Enabled = false;
                    LabSRPassword.Text = "两次密码不一样！";
                }
            }
            else
            {
                LabSRPassword.Text = null;
            }
        }

        /// <summary>
        /// 检测用户输入的姓名信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SName_TextChanged(object sender, EventArgs e)//3
        {
            if (SName.Text != "")
            {
                result = DlgRegisterUserCheck.Check_Name(SName.Text);
                isAllRight[3] = result.Flag;
                if (result.Flag)
                {
                    LabSName.Text = null;
                    Judge_isAllRight();
                }
                else
                {
                    SRegister.Enabled = false;
                    LabSName.Text = result.Msg;
                }
            }
            else
            {
                LabSName.Text = null;
            }
        }

        /// <summary>
        /// 检测用户输入的邮箱信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SMail_TextChanged(object sender, EventArgs e)//4
        {
            if (SMail.Text != "")
            {
                result = DlgRegisterUserCheck.Check_Email(SMail.Text);
                isAllRight[4] = result.Flag;
                if (result.Flag)
                {
                    LabSMail.Text = null;
                    Judge_isAllRight();
                }
                else
                {
                    SRegister.Enabled = false;
                    LabSMail.Text = result.Msg;
                }
            }
            else
            {
                LabSMail.Text = null;
            }
        }

        /// <summary>
        /// 检测用户输入的地址信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SAddress_TextChanged(object sender, EventArgs e)//5
        {
            if (SAddress.Text != "")
            {
                result = DlgRegisterUserCheck.Check_Address(SAddress.Text);
                isAllRight[5] = result.Flag;
                if (result.Flag)
                {
                    LabSAddress.Text = null;
                    Judge_isAllRight();
                }
                else
                {
                    SRegister.Enabled = false;
                    LabSAddress.Text = result.Msg;
                }
            }
            else
            {
                LabSAddress.Text = null;
            }
        }

        /// <summary>
        /// 检测用户输入的电话号码信息是否合法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void STele_TextChanged(object sender, EventArgs e)//6
        {
            if (STele.Text != "")
            {
                result = DlgRegisterUserCheck.Check_Phone(STele.Text);
                isAllRight[6] = result.Flag;
                if (result.Flag)
                {
                    LabSTele.Text = null;
                    Judge_isAllRight();
                }
                else
                {
                    SRegister.Enabled = false;
                    LabSTele.Text = result.Msg;
                }
            }
            else
            {
                LabSTele.Text = null;
            }
        }

        /// <summary>
        /// 注册按钮的相应操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SRegister_Click(object sender, EventArgs e)
        {
            String Sex="女";
            if (SMale.Checked)
            {
                Sex = "男";
            }
            if (DlgRegisterDo.UserReg(SID.Text, SPassword.Text, SIdentity.Text, SName.Text, Sex, SMail.Text, STele.Text, SAddress.Text))
            {
                MessageBox.Show("注册成功!");
                SRegister.Enabled = false;
            }
            else
            {
                MessageBox.Show("注册失败!");
                SRegister.Enabled = false;
            }
        }

        /// <summary>
        /// 重置按钮的相应操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SReset_Click(object sender, EventArgs e)
        {
            SID.Text = "";
            SPassword.Text = "";
            SRPassword.Text = "";
            SName.Text = "";
            SIdentity.SelectedIndex = 0;
            SMale.Checked = true;
            SMail.Text = "";
            SAddress.Text = "";
            STele.Text = "";
            SRegister.Enabled = false;
        }

    }
}
