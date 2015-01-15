namespace CSFcmClientView
{
    partial class CSDlgUserReg
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAccount = new DevComponents.DotNetBar.LabelX();
            this.labelID = new DevComponents.DotNetBar.LabelX();
            this.labelPassword = new DevComponents.DotNetBar.LabelX();
            this.labelRPassword = new DevComponents.DotNetBar.LabelX();
            this.SID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SRPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelUser = new DevComponents.DotNetBar.LabelX();
            this.labelSex = new DevComponents.DotNetBar.LabelX();
            this.groupStu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.LabSTele = new DevComponents.DotNetBar.LabelX();
            this.LabSAddress = new DevComponents.DotNetBar.LabelX();
            this.LabSMail = new DevComponents.DotNetBar.LabelX();
            this.LabSSex = new DevComponents.DotNetBar.LabelX();
            this.LabSIdentity = new DevComponents.DotNetBar.LabelX();
            this.LabSName = new DevComponents.DotNetBar.LabelX();
            this.LabSRPassword = new DevComponents.DotNetBar.LabelX();
            this.LabSPassword = new DevComponents.DotNetBar.LabelX();
            this.LabSID = new DevComponents.DotNetBar.LabelX();
            this.panelLink = new DevComponents.DotNetBar.PanelEx();
            this.SSex = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.SFemale = new System.Windows.Forms.RadioButton();
            this.SMale = new System.Windows.Forms.RadioButton();
            this.panelUser = new DevComponents.DotNetBar.PanelEx();
            this.SReset = new DevComponents.DotNetBar.ButtonX();
            this.SRegister = new DevComponents.DotNetBar.ButtonX();
            this.panelAccount = new DevComponents.DotNetBar.PanelEx();
            this.STele = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SMail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelAddress = new DevComponents.DotNetBar.LabelX();
            this.labelTele = new DevComponents.DotNetBar.LabelX();
            this.labelMail = new DevComponents.DotNetBar.LabelX();
            this.labelLink = new DevComponents.DotNetBar.LabelX();
            this.SIdentity = new System.Windows.Forms.ComboBox();
            this.SName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelName = new DevComponents.DotNetBar.LabelX();
            this.labelIdentity = new DevComponents.DotNetBar.LabelX();
            this.BalLimit = new DevComponents.DotNetBar.BalloonTip();
            this.groupStu.SuspendLayout();
            this.SSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAccount
            // 
            this.labelAccount.BackColor = System.Drawing.Color.Transparent;
            this.labelAccount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAccount.Location = new System.Drawing.Point(19, 18);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(64, 22);
            this.labelAccount.TabIndex = 88;
            this.labelAccount.Text = "账户信息<u></u>";
            // 
            // labelID
            // 
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelID.Location = new System.Drawing.Point(19, 56);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(40, 21);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "账户";
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPassword.Location = new System.Drawing.Point(19, 92);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(40, 21);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "密码<i></i><u></u>";
            // 
            // labelRPassword
            // 
            this.labelRPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelRPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRPassword.Location = new System.Drawing.Point(19, 125);
            this.labelRPassword.Name = "labelRPassword";
            this.labelRPassword.Size = new System.Drawing.Size(64, 21);
            this.labelRPassword.TabIndex = 4;
            this.labelRPassword.Text = "确认密码<i></i><u></u>";
            // 
            // SID
            // 
            this.BalLimit.SetBalloonCaption(this.SID, null);
            this.BalLimit.SetBalloonText(this.SID, "账户必须以字母开头，可包含数字,\"-\"或\"_\"");
            // 
            // 
            // 
            this.SID.Border.Class = "TextBoxBorder";
            this.SID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SID.Location = new System.Drawing.Point(85, 55);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(98, 21);
            this.SID.TabIndex = 1;
            this.SID.TextChanged += new System.EventHandler(this.SID_TextChanged);
            // 
            // SPassword
            // 
            this.BalLimit.SetBalloonCaption(this.SPassword, null);
            this.BalLimit.SetBalloonText(this.SPassword, "密码必须包含大小写字母和数字");
            // 
            // 
            // 
            this.SPassword.Border.Class = "TextBoxBorder";
            this.SPassword.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SPassword.Location = new System.Drawing.Point(85, 88);
            this.SPassword.Name = "SPassword";
            this.SPassword.Size = new System.Drawing.Size(98, 21);
            this.SPassword.TabIndex = 2;
            this.SPassword.TextChanged += new System.EventHandler(this.SPassword_TextChanged);
            // 
            // SRPassword
            // 
            this.BalLimit.SetBalloonCaption(this.SRPassword, null);
            this.BalLimit.SetBalloonText(this.SRPassword, "    请再次输入密码");
            // 
            // 
            // 
            this.SRPassword.Border.Class = "TextBoxBorder";
            this.SRPassword.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SRPassword.Location = new System.Drawing.Point(85, 121);
            this.SRPassword.Name = "SRPassword";
            this.SRPassword.Size = new System.Drawing.Size(98, 21);
            this.SRPassword.TabIndex = 3;
            this.SRPassword.TextChanged += new System.EventHandler(this.SRPassword_TextChanged);
            // 
            // labelUser
            // 
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUser.Location = new System.Drawing.Point(19, 151);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(64, 25);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "用户信息<i></i><u></u>";
            // 
            // labelSex
            // 
            this.labelSex.BackColor = System.Drawing.Color.Transparent;
            this.labelSex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSex.Location = new System.Drawing.Point(19, 263);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(40, 21);
            this.labelSex.TabIndex = 14;
            this.labelSex.Text = "性别";
            // 
            // groupStu
            // 
            this.groupStu.BackColor = System.Drawing.Color.Transparent;
            this.groupStu.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupStu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupStu.Controls.Add(this.LabSTele);
            this.groupStu.Controls.Add(this.LabSAddress);
            this.groupStu.Controls.Add(this.LabSMail);
            this.groupStu.Controls.Add(this.LabSSex);
            this.groupStu.Controls.Add(this.LabSIdentity);
            this.groupStu.Controls.Add(this.LabSName);
            this.groupStu.Controls.Add(this.LabSRPassword);
            this.groupStu.Controls.Add(this.LabSPassword);
            this.groupStu.Controls.Add(this.LabSID);
            this.groupStu.Controls.Add(this.panelLink);
            this.groupStu.Controls.Add(this.SSex);
            this.groupStu.Controls.Add(this.panelUser);
            this.groupStu.Controls.Add(this.SReset);
            this.groupStu.Controls.Add(this.SRegister);
            this.groupStu.Controls.Add(this.panelAccount);
            this.groupStu.Controls.Add(this.STele);
            this.groupStu.Controls.Add(this.SAddress);
            this.groupStu.Controls.Add(this.SMail);
            this.groupStu.Controls.Add(this.labelAddress);
            this.groupStu.Controls.Add(this.labelTele);
            this.groupStu.Controls.Add(this.labelMail);
            this.groupStu.Controls.Add(this.labelLink);
            this.groupStu.Controls.Add(this.SIdentity);
            this.groupStu.Controls.Add(this.SName);
            this.groupStu.Controls.Add(this.labelSex);
            this.groupStu.Controls.Add(this.labelName);
            this.groupStu.Controls.Add(this.labelIdentity);
            this.groupStu.Controls.Add(this.labelUser);
            this.groupStu.Controls.Add(this.SRPassword);
            this.groupStu.Controls.Add(this.SPassword);
            this.groupStu.Controls.Add(this.SID);
            this.groupStu.Controls.Add(this.labelRPassword);
            this.groupStu.Controls.Add(this.labelPassword);
            this.groupStu.Controls.Add(this.labelID);
            this.groupStu.Controls.Add(this.labelAccount);
            this.groupStu.Location = new System.Drawing.Point(5, 12);
            this.groupStu.Name = "groupStu";
            this.groupStu.Size = new System.Drawing.Size(393, 518);
            // 
            // 
            // 
            this.groupStu.Style.BackColor = System.Drawing.Color.Transparent;
            this.groupStu.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.groupStu.Style.BackColorGradientAngle = 90;
            this.groupStu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupStu.Style.BorderBottomWidth = 1;
            this.groupStu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupStu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupStu.Style.BorderLeftWidth = 1;
            this.groupStu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupStu.Style.BorderRightWidth = 1;
            this.groupStu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupStu.Style.BorderTopWidth = 1;
            this.groupStu.Style.CornerDiameter = 4;
            this.groupStu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupStu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupStu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupStu.TabIndex = 78;
            // 
            // LabSTele
            // 
            this.LabSTele.BackColor = System.Drawing.Color.Transparent;
            this.LabSTele.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSTele.ForeColor = System.Drawing.Color.Red;
            this.LabSTele.Location = new System.Drawing.Point(192, 403);
            this.LabSTele.Name = "LabSTele";
            this.LabSTele.Size = new System.Drawing.Size(196, 18);
            this.LabSTele.TabIndex = 97;
            // 
            // LabSAddress
            // 
            this.LabSAddress.BackColor = System.Drawing.Color.Transparent;
            this.LabSAddress.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSAddress.ForeColor = System.Drawing.Color.Red;
            this.LabSAddress.Location = new System.Drawing.Point(192, 370);
            this.LabSAddress.Name = "LabSAddress";
            this.LabSAddress.Size = new System.Drawing.Size(196, 18);
            this.LabSAddress.TabIndex = 96;
            // 
            // LabSMail
            // 
            this.LabSMail.BackColor = System.Drawing.Color.Transparent;
            this.LabSMail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSMail.ForeColor = System.Drawing.Color.Red;
            this.LabSMail.Location = new System.Drawing.Point(192, 335);
            this.LabSMail.Name = "LabSMail";
            this.LabSMail.Size = new System.Drawing.Size(196, 18);
            this.LabSMail.TabIndex = 95;
            // 
            // LabSSex
            // 
            this.LabSSex.BackColor = System.Drawing.Color.Transparent;
            this.LabSSex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSSex.ForeColor = System.Drawing.Color.Red;
            this.LabSSex.Location = new System.Drawing.Point(192, 264);
            this.LabSSex.Name = "LabSSex";
            this.LabSSex.Size = new System.Drawing.Size(196, 18);
            this.LabSSex.TabIndex = 94;
            // 
            // LabSIdentity
            // 
            this.LabSIdentity.BackColor = System.Drawing.Color.Transparent;
            this.LabSIdentity.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSIdentity.ForeColor = System.Drawing.Color.Red;
            this.LabSIdentity.Location = new System.Drawing.Point(192, 230);
            this.LabSIdentity.Name = "LabSIdentity";
            this.LabSIdentity.Size = new System.Drawing.Size(196, 18);
            this.LabSIdentity.TabIndex = 93;
            // 
            // LabSName
            // 
            this.LabSName.BackColor = System.Drawing.Color.Transparent;
            this.LabSName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSName.ForeColor = System.Drawing.Color.Red;
            this.LabSName.Location = new System.Drawing.Point(189, 193);
            this.LabSName.Name = "LabSName";
            this.LabSName.Size = new System.Drawing.Size(196, 18);
            this.LabSName.TabIndex = 92;
            // 
            // LabSRPassword
            // 
            this.LabSRPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabSRPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSRPassword.ForeColor = System.Drawing.Color.Red;
            this.LabSRPassword.Location = new System.Drawing.Point(192, 124);
            this.LabSRPassword.Name = "LabSRPassword";
            this.LabSRPassword.Size = new System.Drawing.Size(196, 18);
            this.LabSRPassword.TabIndex = 91;
            // 
            // LabSPassword
            // 
            this.LabSPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabSPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSPassword.ForeColor = System.Drawing.Color.Red;
            this.LabSPassword.Location = new System.Drawing.Point(189, 88);
            this.LabSPassword.Name = "LabSPassword";
            this.LabSPassword.Size = new System.Drawing.Size(199, 18);
            this.LabSPassword.TabIndex = 90;
            // 
            // LabSID
            // 
            this.LabSID.BackColor = System.Drawing.Color.Transparent;
            this.LabSID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSID.ForeColor = System.Drawing.Color.Red;
            this.LabSID.Location = new System.Drawing.Point(189, 57);
            this.LabSID.Name = "LabSID";
            this.LabSID.Size = new System.Drawing.Size(199, 18);
            this.LabSID.TabIndex = 89;
            // 
            // panelLink
            // 
            this.panelLink.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelLink.Location = new System.Drawing.Point(19, 316);
            this.panelLink.Name = "panelLink";
            this.panelLink.Size = new System.Drawing.Size(341, 2);
            this.panelLink.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelLink.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveCaption;
            this.panelLink.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.panelLink.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelLink.Style.BorderColor.Color = System.Drawing.SystemColors.ActiveCaption;
            this.panelLink.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelLink.Style.GradientAngle = 90;
            this.panelLink.TabIndex = 38;
            // 
            // SSex
            // 
            this.BalLimit.SetBalloonCaption(this.SSex, null);
            this.BalLimit.SetBalloonText(this.SSex, "请选择性别");
            this.SSex.CanvasColor = System.Drawing.SystemColors.Control;
            this.SSex.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.SSex.Controls.Add(this.SFemale);
            this.SSex.Controls.Add(this.SMale);
            this.SSex.Location = new System.Drawing.Point(85, 261);
            this.SSex.Name = "SSex";
            this.SSex.Size = new System.Drawing.Size(98, 21);
            // 
            // 
            // 
            this.SSex.Style.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SSex.Style.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.SSex.Style.BackColorGradientAngle = 90;
            this.SSex.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.SSex.Style.BorderBottomWidth = 1;
            this.SSex.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.SSex.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.SSex.Style.BorderLeftWidth = 1;
            this.SSex.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.SSex.Style.BorderRightWidth = 1;
            this.SSex.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.SSex.Style.BorderTopWidth = 1;
            this.SSex.Style.CornerDiameter = 4;
            this.SSex.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.SSex.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.SSex.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.SSex.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.SSex.TabIndex = 6;
            // 
            // SFemale
            // 
            this.SFemale.AutoSize = true;
            this.SFemale.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BalLimit.SetBalloonCaption(this.SFemale, null);
            this.BalLimit.SetBalloonText(this.SFemale, "    请选择性别");
            this.SFemale.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
            this.SFemale.Location = new System.Drawing.Point(54, -1);
            this.SFemale.Name = "SFemale";
            this.SFemale.Size = new System.Drawing.Size(35, 16);
            this.SFemale.TabIndex = 7;
            this.SFemale.Text = "女";
            this.SFemale.UseVisualStyleBackColor = false;
            // 
            // SMale
            // 
            this.SMale.AutoSize = true;
            this.SMale.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BalLimit.SetBalloonCaption(this.SMale, null);
            this.BalLimit.SetBalloonText(this.SMale, "    请选择性别");
            this.SMale.Checked = true;
            this.SMale.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
            this.SMale.Location = new System.Drawing.Point(6, -1);
            this.SMale.Name = "SMale";
            this.SMale.Size = new System.Drawing.Size(35, 16);
            this.SMale.TabIndex = 6;
            this.SMale.TabStop = true;
            this.SMale.Text = "男";
            this.SMale.UseVisualStyleBackColor = false;
            // 
            // panelUser
            // 
            this.panelUser.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelUser.Location = new System.Drawing.Point(19, 177);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(341, 2);
            this.panelUser.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelUser.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveCaption;
            this.panelUser.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.panelUser.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelUser.Style.BorderColor.Color = System.Drawing.SystemColors.ActiveCaption;
            this.panelUser.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelUser.Style.GradientAngle = 90;
            this.panelUser.TabIndex = 34;
            // 
            // SReset
            // 
            this.SReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SReset.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SReset.Location = new System.Drawing.Point(198, 468);
            this.SReset.Name = "SReset";
            this.SReset.Size = new System.Drawing.Size(64, 24);
            this.SReset.TabIndex = 13;
            this.SReset.Text = "重置";
            this.SReset.Click += new System.EventHandler(this.SReset_Click);
            // 
            // SRegister
            // 
            this.SRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SRegister.Enabled = false;
            this.SRegister.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SRegister.Location = new System.Drawing.Point(98, 468);
            this.SRegister.Name = "SRegister";
            this.SRegister.Size = new System.Drawing.Size(64, 24);
            this.SRegister.TabIndex = 12;
            this.SRegister.Text = "注册";
            this.SRegister.Click += new System.EventHandler(this.SRegister_Click);
            // 
            // panelAccount
            // 
            this.panelAccount.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelAccount.Location = new System.Drawing.Point(19, 40);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(341, 2);
            this.panelAccount.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelAccount.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveCaption;
            this.panelAccount.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.panelAccount.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelAccount.Style.BorderColor.Color = System.Drawing.SystemColors.ActiveCaption;
            this.panelAccount.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelAccount.Style.GradientAngle = 90;
            this.panelAccount.TabIndex = 27;
            // 
            // STele
            // 
            this.BalLimit.SetBalloonCaption(this.STele, null);
            this.BalLimit.SetBalloonText(this.STele, "手机号必须是11位数字");
            // 
            // 
            // 
            this.STele.Border.Class = "TextBoxBorder";
            this.STele.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.STele.Location = new System.Drawing.Point(85, 398);
            this.STele.Name = "STele";
            this.STele.Size = new System.Drawing.Size(98, 21);
            this.STele.TabIndex = 10;
            this.STele.TextChanged += new System.EventHandler(this.STele_TextChanged);
            // 
            // SAddress
            // 
            this.BalLimit.SetBalloonCaption(this.SAddress, null);
            this.BalLimit.SetBalloonText(this.SAddress, "    地址必须是汉字");
            // 
            // 
            // 
            this.SAddress.Border.Class = "TextBoxBorder";
            this.SAddress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SAddress.Location = new System.Drawing.Point(85, 365);
            this.SAddress.Name = "SAddress";
            this.SAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SAddress.Size = new System.Drawing.Size(98, 21);
            this.SAddress.TabIndex = 9;
            this.SAddress.TextChanged += new System.EventHandler(this.SAddress_TextChanged);
            // 
            // SMail
            // 
            this.BalLimit.SetBalloonCaption(this.SMail, null);
            this.BalLimit.SetBalloonText(this.SMail, "必须邮箱必须包含@和.，并且不为结尾");
            // 
            // 
            // 
            this.SMail.Border.Class = "TextBoxBorder";
            this.SMail.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SMail.Location = new System.Drawing.Point(85, 332);
            this.SMail.Name = "SMail";
            this.SMail.Size = new System.Drawing.Size(98, 21);
            this.SMail.TabIndex = 8;
            this.SMail.TextChanged += new System.EventHandler(this.SMail_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAddress.Location = new System.Drawing.Point(19, 368);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 19);
            this.labelAddress.TabIndex = 22;
            this.labelAddress.Text = "地址";
            // 
            // labelTele
            // 
            this.labelTele.BackColor = System.Drawing.Color.Transparent;
            this.labelTele.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTele.Location = new System.Drawing.Point(19, 400);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(64, 20);
            this.labelTele.TabIndex = 21;
            this.labelTele.Text = "手机";
            // 
            // labelMail
            // 
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMail.Location = new System.Drawing.Point(19, 333);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(60, 21);
            this.labelMail.TabIndex = 20;
            this.labelMail.Text = "邮箱";
            // 
            // labelLink
            // 
            this.labelLink.BackColor = System.Drawing.Color.Transparent;
            this.labelLink.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLink.Location = new System.Drawing.Point(19, 294);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(64, 22);
            this.labelLink.TabIndex = 19;
            this.labelLink.Text = "联系方式";
            // 
            // SIdentity
            // 
            this.BalLimit.SetBalloonCaption(this.SIdentity, null);
            this.BalLimit.SetBalloonText(this.SIdentity, "    请选择身份");
            this.SIdentity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SIdentity.FormattingEnabled = true;
            this.SIdentity.Items.AddRange(new object[] {
            "学生",
            "餐馆"});
            this.SIdentity.Location = new System.Drawing.Point(85, 226);
            this.SIdentity.Name = "SIdentity";
            this.SIdentity.Size = new System.Drawing.Size(98, 22);
            this.SIdentity.TabIndex = 5;
            // 
            // SName
            // 
            this.BalLimit.SetBalloonCaption(this.SName, null);
            this.BalLimit.SetBalloonText(this.SName, "    姓名必须是汉字");
            // 
            // 
            // 
            this.SName.Border.Class = "TextBoxBorder";
            this.SName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SName.Location = new System.Drawing.Point(85, 193);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(98, 21);
            this.SName.TabIndex = 4;
            this.SName.TextChanged += new System.EventHandler(this.SName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(19, 198);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 21);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "姓名<i></i><u></u>";
            // 
            // labelIdentity
            // 
            this.labelIdentity.BackColor = System.Drawing.Color.Transparent;
            this.labelIdentity.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIdentity.Location = new System.Drawing.Point(19, 231);
            this.labelIdentity.Name = "labelIdentity";
            this.labelIdentity.Size = new System.Drawing.Size(40, 22);
            this.labelIdentity.TabIndex = 11;
            this.labelIdentity.Text = "身份";
            // 
            // BalLimit
            // 
            this.BalLimit.DefaultBalloonWidth = 120;
            // 
            // CSDlgUserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSFcmClientView.Properties.Resources.Reg_background;
            this.ClientSize = new System.Drawing.Size(403, 542);
            this.Controls.Add(this.groupStu);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CSDlgUserReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册新成员";
            this.groupStu.ResumeLayout(false);
            this.SSex.ResumeLayout(false);
            this.SSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelAccount;
        private DevComponents.DotNetBar.LabelX labelID;
        private DevComponents.DotNetBar.LabelX labelPassword;
        private DevComponents.DotNetBar.LabelX labelRPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX SID;
        private DevComponents.DotNetBar.Controls.TextBoxX SPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX SRPassword;
        private DevComponents.DotNetBar.LabelX labelUser;
        private DevComponents.DotNetBar.LabelX labelSex;
        private DevComponents.DotNetBar.Controls.GroupPanel groupStu;
        private DevComponents.DotNetBar.Controls.TextBoxX STele;
        private DevComponents.DotNetBar.Controls.TextBoxX SAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX SMail;
        private DevComponents.DotNetBar.LabelX labelAddress;
        private DevComponents.DotNetBar.LabelX labelTele;
        private DevComponents.DotNetBar.LabelX labelMail;
        private DevComponents.DotNetBar.LabelX labelLink;
        private System.Windows.Forms.ComboBox SIdentity;
        private DevComponents.DotNetBar.Controls.TextBoxX SName;
        private DevComponents.DotNetBar.LabelX labelName;
        private DevComponents.DotNetBar.LabelX labelIdentity;
        private DevComponents.DotNetBar.PanelEx panelAccount;
        private DevComponents.DotNetBar.ButtonX SRegister;
        private DevComponents.DotNetBar.ButtonX SReset;
        private DevComponents.DotNetBar.PanelEx panelUser;
        private DevComponents.DotNetBar.Controls.GroupPanel SSex;
        private System.Windows.Forms.RadioButton SFemale;
        private System.Windows.Forms.RadioButton SMale;
        private DevComponents.DotNetBar.PanelEx panelLink;
        private DevComponents.DotNetBar.LabelX LabSID;
        private DevComponents.DotNetBar.LabelX LabSPassword;
        private DevComponents.DotNetBar.LabelX LabSRPassword;
        private DevComponents.DotNetBar.LabelX LabSName;
        private DevComponents.DotNetBar.LabelX LabSIdentity;
        private DevComponents.DotNetBar.LabelX LabSSex;
        private DevComponents.DotNetBar.LabelX LabSMail;
        private DevComponents.DotNetBar.LabelX LabSAddress;
        private DevComponents.DotNetBar.LabelX LabSTele;
        private DevComponents.DotNetBar.BalloonTip BalLimit;




    }
}

