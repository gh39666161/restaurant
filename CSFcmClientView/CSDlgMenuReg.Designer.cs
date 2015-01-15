namespace CSFcmClientView
{
    partial class CSDlgMenuReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabId = new DevComponents.DotNetBar.LabelX();
            this.TxbId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxbName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabName = new DevComponents.DotNetBar.LabelX();
            this.LabPrice = new DevComponents.DotNetBar.LabelX();
            this.LabType = new DevComponents.DotNetBar.LabelX();
            this.GrpMenu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.LabTxbDescribe = new DevComponents.DotNetBar.LabelX();
            this.LabTxbPicture = new DevComponents.DotNetBar.LabelX();
            this.LabTxbScore = new DevComponents.DotNetBar.LabelX();
            this.LabTxbType = new DevComponents.DotNetBar.LabelX();
            this.LabTxbPrice = new DevComponents.DotNetBar.LabelX();
            this.LabTxbName = new DevComponents.DotNetBar.LabelX();
            this.LabTxbId = new DevComponents.DotNetBar.LabelX();
            this.Btnscan = new DevComponents.DotNetBar.ButtonX();
            this.TxbPicture = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabPicture = new DevComponents.DotNetBar.LabelX();
            this.BtnReset = new DevComponents.DotNetBar.ButtonX();
            this.BtnRegister = new DevComponents.DotNetBar.ButtonX();
            this.LabDetail = new DevComponents.DotNetBar.LabelX();
            this.PexDetail = new DevComponents.DotNetBar.PanelEx();
            this.GplSpe = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TbxNotspe = new System.Windows.Forms.RadioButton();
            this.TbxSpe = new System.Windows.Forms.RadioButton();
            this.GplState = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TbxCannotbuy = new System.Windows.Forms.RadioButton();
            this.TbxCanbuy = new System.Windows.Forms.RadioButton();
            this.TxbScore = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabState = new DevComponents.DotNetBar.LabelX();
            this.LabSpe = new DevComponents.DotNetBar.LabelX();
            this.LabScore = new DevComponents.DotNetBar.LabelX();
            this.TxbDescribe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxbType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxbPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PexFood = new DevComponents.DotNetBar.PanelEx();
            this.GrpPicture = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.RefImage = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.LabDescribe = new DevComponents.DotNetBar.LabelX();
            this.LabFood = new DevComponents.DotNetBar.LabelX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.GrpMenu.SuspendLayout();
            this.GplSpe.SuspendLayout();
            this.GplState.SuspendLayout();
            this.GrpPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabId
            // 
            this.LabId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabId.Location = new System.Drawing.Point(19, 58);
            this.LabId.Name = "LabId";
            this.LabId.Size = new System.Drawing.Size(60, 21);
            this.LabId.TabIndex = 0;
            this.LabId.Text = "菜单ID";
            // 
            // TxbId
            // 
            this.balloonTip1.SetBalloonCaption(this.TxbId, null);
            this.balloonTip1.SetBalloonText(this.TxbId, "ID必须是数字且为整数");
            // 
            // 
            // 
            this.TxbId.Border.Class = "TextBoxBorder";
            this.TxbId.Location = new System.Drawing.Point(85, 55);
            this.TxbId.Name = "TxbId";
            this.TxbId.Size = new System.Drawing.Size(98, 21);
            this.TxbId.TabIndex = 1;
            this.TxbId.TextChanged += new System.EventHandler(this.TxbId_TextChanged);
            // 
            // TxbName
            // 
            this.balloonTip1.SetBalloonCaption(this.TxbName, null);
            this.balloonTip1.SetBalloonText(this.TxbName, "   菜名不能为空");
            // 
            // 
            // 
            this.TxbName.Border.Class = "TextBoxBorder";
            this.TxbName.Location = new System.Drawing.Point(85, 88);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(98, 21);
            this.TxbName.TabIndex = 2;
            this.TxbName.TextChanged += new System.EventHandler(this.TxbName_TextChanged);
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabName.Location = new System.Drawing.Point(19, 91);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(60, 21);
            this.LabName.TabIndex = 99;
            this.LabName.Text = "菜名";
            // 
            // LabPrice
            // 
            this.LabPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabPrice.Location = new System.Drawing.Point(19, 125);
            this.LabPrice.Name = "LabPrice";
            this.LabPrice.Size = new System.Drawing.Size(60, 21);
            this.LabPrice.TabIndex = 99;
            this.LabPrice.Text = "菜价";
            // 
            // LabType
            // 
            this.LabType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabType.Location = new System.Drawing.Point(19, 159);
            this.LabType.Name = "LabType";
            this.LabType.Size = new System.Drawing.Size(60, 21);
            this.LabType.TabIndex = 699;
            this.LabType.Text = "类别";
            // 
            // GrpMenu
            // 
            this.GrpMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GrpMenu.CanvasColor = System.Drawing.SystemColors.Control;
            this.GrpMenu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GrpMenu.Controls.Add(this.LabTxbDescribe);
            this.GrpMenu.Controls.Add(this.LabTxbPicture);
            this.GrpMenu.Controls.Add(this.LabTxbScore);
            this.GrpMenu.Controls.Add(this.LabTxbType);
            this.GrpMenu.Controls.Add(this.LabTxbPrice);
            this.GrpMenu.Controls.Add(this.LabTxbName);
            this.GrpMenu.Controls.Add(this.LabTxbId);
            this.GrpMenu.Controls.Add(this.Btnscan);
            this.GrpMenu.Controls.Add(this.TxbPicture);
            this.GrpMenu.Controls.Add(this.LabPicture);
            this.GrpMenu.Controls.Add(this.BtnReset);
            this.GrpMenu.Controls.Add(this.BtnRegister);
            this.GrpMenu.Controls.Add(this.LabDetail);
            this.GrpMenu.Controls.Add(this.PexDetail);
            this.GrpMenu.Controls.Add(this.GplSpe);
            this.GrpMenu.Controls.Add(this.GplState);
            this.GrpMenu.Controls.Add(this.TxbScore);
            this.GrpMenu.Controls.Add(this.LabState);
            this.GrpMenu.Controls.Add(this.LabSpe);
            this.GrpMenu.Controls.Add(this.LabScore);
            this.GrpMenu.Controls.Add(this.TxbDescribe);
            this.GrpMenu.Controls.Add(this.TxbType);
            this.GrpMenu.Controls.Add(this.TxbPrice);
            this.GrpMenu.Controls.Add(this.PexFood);
            this.GrpMenu.Controls.Add(this.GrpPicture);
            this.GrpMenu.Controls.Add(this.LabDescribe);
            this.GrpMenu.Controls.Add(this.LabFood);
            this.GrpMenu.Controls.Add(this.LabPrice);
            this.GrpMenu.Controls.Add(this.LabType);
            this.GrpMenu.Controls.Add(this.LabName);
            this.GrpMenu.Controls.Add(this.LabId);
            this.GrpMenu.Controls.Add(this.TxbId);
            this.GrpMenu.Controls.Add(this.TxbName);
            this.GrpMenu.Location = new System.Drawing.Point(12, 23);
            this.GrpMenu.Name = "GrpMenu";
            this.GrpMenu.Size = new System.Drawing.Size(647, 469);
            // 
            // 
            // 
            this.GrpMenu.Style.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GrpMenu.Style.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.GrpMenu.Style.BackColorGradientAngle = 90;
            this.GrpMenu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpMenu.Style.BorderBottomWidth = 1;
            this.GrpMenu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GrpMenu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpMenu.Style.BorderLeftWidth = 1;
            this.GrpMenu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpMenu.Style.BorderRightWidth = 1;
            this.GrpMenu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpMenu.Style.BorderTopWidth = 1;
            this.GrpMenu.Style.CornerDiameter = 4;
            this.GrpMenu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GrpMenu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GrpMenu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.GrpMenu.TabIndex = 88;
            // 
            // LabTxbDescribe
            // 
            this.LabTxbDescribe.BackColor = System.Drawing.Color.Transparent;
            this.LabTxbDescribe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTxbDescribe.ForeColor = System.Drawing.Color.Red;
            this.LabTxbDescribe.Location = new System.Drawing.Point(379, 269);
            this.LabTxbDescribe.Name = "LabTxbDescribe";
            this.LabTxbDescribe.Size = new System.Drawing.Size(199, 18);
            this.LabTxbDescribe.TabIndex = 713;
            // 
            // LabTxbPicture
            // 
            this.LabTxbPicture.BackColor = System.Drawing.Color.Transparent;
            this.LabTxbPicture.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTxbPicture.ForeColor = System.Drawing.Color.Red;
            this.LabTxbPicture.Location = new System.Drawing.Point(379, 227);
            this.LabTxbPicture.Name = "LabTxbPicture";
            this.LabTxbPicture.Size = new System.Drawing.Size(199, 18);
            this.LabTxbPicture.TabIndex = 712;
            this.LabTxbPicture.Text = "请选择图片！";
            // 
            // LabTxbScore
            // 
            this.LabTxbScore.BackColor = System.Drawing.Color.Transparent;
            this.LabTxbScore.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTxbScore.ForeColor = System.Drawing.Color.Red;
            this.LabTxbScore.Location = new System.Drawing.Point(203, 195);
            this.LabTxbScore.Name = "LabTxbScore";
            this.LabTxbScore.Size = new System.Drawing.Size(199, 18);
            this.LabTxbScore.TabIndex = 711;
            // 
            // LabTxbType
            // 
            this.LabTxbType.BackColor = System.Drawing.Color.Transparent;
            this.LabTxbType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTxbType.ForeColor = System.Drawing.Color.Red;
            this.LabTxbType.Location = new System.Drawing.Point(203, 159);
            this.LabTxbType.Name = "LabTxbType";
            this.LabTxbType.Size = new System.Drawing.Size(199, 18);
            this.LabTxbType.TabIndex = 710;
            // 
            // LabTxbPrice
            // 
            this.LabTxbPrice.BackColor = System.Drawing.Color.Transparent;
            this.LabTxbPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTxbPrice.ForeColor = System.Drawing.Color.Red;
            this.LabTxbPrice.Location = new System.Drawing.Point(203, 125);
            this.LabTxbPrice.Name = "LabTxbPrice";
            this.LabTxbPrice.Size = new System.Drawing.Size(199, 18);
            this.LabTxbPrice.TabIndex = 709;
            // 
            // LabTxbName
            // 
            this.LabTxbName.BackColor = System.Drawing.Color.Transparent;
            this.LabTxbName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTxbName.ForeColor = System.Drawing.Color.Red;
            this.LabTxbName.Location = new System.Drawing.Point(203, 91);
            this.LabTxbName.Name = "LabTxbName";
            this.LabTxbName.Size = new System.Drawing.Size(199, 18);
            this.LabTxbName.TabIndex = 708;
            // 
            // LabTxbId
            // 
            this.LabTxbId.BackColor = System.Drawing.Color.Transparent;
            this.LabTxbId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTxbId.ForeColor = System.Drawing.Color.Red;
            this.LabTxbId.Location = new System.Drawing.Point(203, 58);
            this.LabTxbId.Name = "LabTxbId";
            this.LabTxbId.Size = new System.Drawing.Size(199, 18);
            this.LabTxbId.TabIndex = 707;
            // 
            // Btnscan
            // 
            this.Btnscan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btnscan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btnscan.Location = new System.Drawing.Point(241, 229);
            this.Btnscan.Name = "Btnscan";
            this.Btnscan.Size = new System.Drawing.Size(90, 20);
            this.Btnscan.TabIndex = 702;
            this.Btnscan.Text = "浏览";
            this.Btnscan.Click += new System.EventHandler(this.Btnscan_Click);
            // 
            // TxbPicture
            // 
            this.balloonTip1.SetBalloonCaption(this.TxbPicture, null);
            this.balloonTip1.SetBalloonText(this.TxbPicture, "点击“浏览”可选择图片");
            // 
            // 
            // 
            this.TxbPicture.Border.Class = "TextBoxBorder";
            this.TxbPicture.Location = new System.Drawing.Point(85, 229);
            this.TxbPicture.Name = "TxbPicture";
            this.TxbPicture.ReadOnly = true;
            this.TxbPicture.Size = new System.Drawing.Size(141, 21);
            this.TxbPicture.TabIndex = 700;
            this.TxbPicture.TextChanged += new System.EventHandler(this.TxbPicture_TextChanged);
            // 
            // LabPicture
            // 
            this.LabPicture.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabPicture.Location = new System.Drawing.Point(19, 231);
            this.LabPicture.Name = "LabPicture";
            this.LabPicture.Size = new System.Drawing.Size(60, 21);
            this.LabPicture.TabIndex = 701;
            this.LabPicture.Text = "图片路径";
            // 
            // BtnReset
            // 
            this.BtnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnReset.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnReset.Location = new System.Drawing.Point(218, 423);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(64, 24);
            this.BtnReset.TabIndex = 15;
            this.BtnReset.Text = "重置";
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnRegister.Enabled = false;
            this.BtnRegister.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRegister.Location = new System.Drawing.Point(94, 423);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(64, 24);
            this.BtnRegister.TabIndex = 14;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LabDetail
            // 
            this.LabDetail.Location = new System.Drawing.Point(19, 310);
            this.LabDetail.Name = "LabDetail";
            this.LabDetail.Size = new System.Drawing.Size(60, 23);
            this.LabDetail.TabIndex = 28;
            this.LabDetail.Text = "菜品详情";
            // 
            // PexDetail
            // 
            this.PexDetail.CanvasColor = System.Drawing.SystemColors.Control;
            this.PexDetail.Location = new System.Drawing.Point(19, 333);
            this.PexDetail.Name = "PexDetail";
            this.PexDetail.Size = new System.Drawing.Size(341, 2);
            this.PexDetail.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PexDetail.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveCaption;
            this.PexDetail.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.PexDetail.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PexDetail.Style.BorderColor.Color = System.Drawing.SystemColors.ActiveCaption;
            this.PexDetail.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PexDetail.Style.GradientAngle = 90;
            this.PexDetail.TabIndex = 42;
            this.PexDetail.Text = "panelEx2";
            // 
            // GplSpe
            // 
            this.GplSpe.CanvasColor = System.Drawing.SystemColors.Control;
            this.GplSpe.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GplSpe.Controls.Add(this.TbxNotspe);
            this.GplSpe.Controls.Add(this.TbxSpe);
            this.GplSpe.Location = new System.Drawing.Point(87, 383);
            this.GplSpe.Name = "GplSpe";
            this.GplSpe.Size = new System.Drawing.Size(152, 21);
            // 
            // 
            // 
            this.GplSpe.Style.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GplSpe.Style.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.GplSpe.Style.BackColorGradientAngle = 90;
            this.GplSpe.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GplSpe.Style.BorderBottomWidth = 1;
            this.GplSpe.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GplSpe.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GplSpe.Style.BorderLeftWidth = 1;
            this.GplSpe.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GplSpe.Style.BorderRightWidth = 1;
            this.GplSpe.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GplSpe.Style.BorderTopWidth = 1;
            this.GplSpe.Style.CornerDiameter = 4;
            this.GplSpe.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GplSpe.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GplSpe.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GplSpe.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.GplSpe.TabIndex = 11;
            // 
            // TbxNotspe
            // 
            this.TbxNotspe.AutoSize = true;
            this.TbxNotspe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.balloonTip1.SetBalloonCaption(this.TbxNotspe, null);
            this.balloonTip1.SetBalloonText(this.TbxNotspe, "请选择是否是特色菜");
            this.TbxNotspe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbxNotspe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
            this.TbxNotspe.Location = new System.Drawing.Point(76, -1);
            this.TbxNotspe.Name = "TbxNotspe";
            this.TbxNotspe.Size = new System.Drawing.Size(59, 16);
            this.TbxNotspe.TabIndex = 13;
            this.TbxNotspe.TabStop = true;
            this.TbxNotspe.Text = "不特色";
            this.TbxNotspe.UseVisualStyleBackColor = false;
            // 
            // TbxSpe
            // 
            this.TbxSpe.AutoSize = true;
            this.TbxSpe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.balloonTip1.SetBalloonCaption(this.TbxSpe, null);
            this.balloonTip1.SetBalloonText(this.TbxSpe, "请选择是否是特色菜");
            this.TbxSpe.Checked = true;
            this.TbxSpe.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbxSpe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
            this.TbxSpe.Location = new System.Drawing.Point(4, -1);
            this.TbxSpe.Name = "TbxSpe";
            this.TbxSpe.Size = new System.Drawing.Size(47, 16);
            this.TbxSpe.TabIndex = 12;
            this.TbxSpe.TabStop = true;
            this.TbxSpe.Text = "特色";
            this.TbxSpe.UseVisualStyleBackColor = false;
            // 
            // GplState
            // 
            this.GplState.CanvasColor = System.Drawing.SystemColors.Control;
            this.GplState.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GplState.Controls.Add(this.TbxCannotbuy);
            this.GplState.Controls.Add(this.TbxCanbuy);
            this.GplState.Location = new System.Drawing.Point(87, 346);
            this.GplState.Name = "GplState";
            this.GplState.Size = new System.Drawing.Size(152, 21);
            // 
            // 
            // 
            this.GplState.Style.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GplState.Style.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.GplState.Style.BackColorGradientAngle = 90;
            this.GplState.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GplState.Style.BorderBottomWidth = 1;
            this.GplState.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GplState.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GplState.Style.BorderLeftWidth = 1;
            this.GplState.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GplState.Style.BorderRightWidth = 1;
            this.GplState.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GplState.Style.BorderTopWidth = 1;
            this.GplState.Style.CornerDiameter = 4;
            this.GplState.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GplState.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GplState.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GplState.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.GplState.TabIndex = 10;
            // 
            // TbxCannotbuy
            // 
            this.TbxCannotbuy.AutoSize = true;
            this.TbxCannotbuy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.balloonTip1.SetBalloonCaption(this.TbxCannotbuy, null);
            this.balloonTip1.SetBalloonText(this.TbxCannotbuy, "请选择是否可订购");
            this.TbxCannotbuy.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbxCannotbuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
            this.TbxCannotbuy.Location = new System.Drawing.Point(76, 0);
            this.TbxCannotbuy.Name = "TbxCannotbuy";
            this.TbxCannotbuy.Size = new System.Drawing.Size(71, 16);
            this.TbxCannotbuy.TabIndex = 11;
            this.TbxCannotbuy.TabStop = true;
            this.TbxCannotbuy.Text = "不可订购";
            this.TbxCannotbuy.UseVisualStyleBackColor = false;
            // 
            // TbxCanbuy
            // 
            this.TbxCanbuy.AutoSize = true;
            this.TbxCanbuy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.balloonTip1.SetBalloonCaption(this.TbxCanbuy, null);
            this.balloonTip1.SetBalloonText(this.TbxCanbuy, "请选择是否可订购");
            this.TbxCanbuy.Checked = true;
            this.TbxCanbuy.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbxCanbuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
            this.TbxCanbuy.Location = new System.Drawing.Point(3, 0);
            this.TbxCanbuy.Name = "TbxCanbuy";
            this.TbxCanbuy.Size = new System.Drawing.Size(59, 16);
            this.TbxCanbuy.TabIndex = 10;
            this.TbxCanbuy.TabStop = true;
            this.TbxCanbuy.Text = "可订购";
            this.TbxCanbuy.UseVisualStyleBackColor = false;
            // 
            // TxbScore
            // 
            this.balloonTip1.SetBalloonCaption(this.TxbScore, null);
            this.balloonTip1.SetBalloonText(this.TxbScore, "评分必须是0~10的整数");
            // 
            // 
            // 
            this.TxbScore.Border.Class = "TextBoxBorder";
            this.TxbScore.Location = new System.Drawing.Point(85, 192);
            this.TxbScore.Name = "TxbScore";
            this.TxbScore.Size = new System.Drawing.Size(98, 21);
            this.TxbScore.TabIndex = 5;
            this.TxbScore.TextChanged += new System.EventHandler(this.TxbScore_TextChanged);
            // 
            // LabState
            // 
            this.LabState.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabState.Location = new System.Drawing.Point(19, 350);
            this.LabState.Name = "LabState";
            this.LabState.Size = new System.Drawing.Size(60, 20);
            this.LabState.TabIndex = 46;
            this.LabState.Text = "菜状态";
            // 
            // LabSpe
            // 
            this.LabSpe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabSpe.Location = new System.Drawing.Point(19, 386);
            this.LabSpe.Name = "LabSpe";
            this.LabSpe.Size = new System.Drawing.Size(75, 21);
            this.LabSpe.TabIndex = 55;
            this.LabSpe.Text = "特色菜与否";
            // 
            // LabScore
            // 
            this.LabScore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabScore.Location = new System.Drawing.Point(19, 195);
            this.LabScore.Name = "LabScore";
            this.LabScore.Size = new System.Drawing.Size(60, 21);
            this.LabScore.TabIndex = 99;
            this.LabScore.Text = "评分";
            // 
            // TxbDescribe
            // 
            this.balloonTip1.SetBalloonCaption(this.TxbDescribe, null);
            this.balloonTip1.SetBalloonText(this.TxbDescribe, "   描述不能为空");
            // 
            // 
            // 
            this.TxbDescribe.Border.Class = "TextBoxBorder";
            this.TxbDescribe.Location = new System.Drawing.Point(85, 266);
            this.TxbDescribe.Name = "TxbDescribe";
            this.TxbDescribe.Size = new System.Drawing.Size(263, 21);
            this.TxbDescribe.TabIndex = 6;
            this.TxbDescribe.TextChanged += new System.EventHandler(this.TxbDescribe_TextChanged);
            // 
            // TxbType
            // 
            this.balloonTip1.SetBalloonCaption(this.TxbType, null);
            this.balloonTip1.SetBalloonText(this.TxbType, "   类别不能为空");
            // 
            // 
            // 
            this.TxbType.Border.Class = "TextBoxBorder";
            this.TxbType.Location = new System.Drawing.Point(85, 156);
            this.TxbType.Name = "TxbType";
            this.TxbType.Size = new System.Drawing.Size(98, 21);
            this.TxbType.TabIndex = 4;
            this.TxbType.TextChanged += new System.EventHandler(this.TxbType_TextChanged);
            // 
            // TxbPrice
            // 
            this.balloonTip1.SetBalloonCaption(this.TxbPrice, null);
            this.balloonTip1.SetBalloonText(this.TxbPrice, "菜价必须是数字，不要求是整数");
            // 
            // 
            // 
            this.TxbPrice.Border.Class = "TextBoxBorder";
            this.TxbPrice.Location = new System.Drawing.Point(85, 122);
            this.TxbPrice.Name = "TxbPrice";
            this.TxbPrice.Size = new System.Drawing.Size(98, 21);
            this.TxbPrice.TabIndex = 3;
            this.TxbPrice.TextChanged += new System.EventHandler(this.TxbPrice_TextChanged);
            // 
            // PexFood
            // 
            this.PexFood.CanvasColor = System.Drawing.SystemColors.Control;
            this.PexFood.Location = new System.Drawing.Point(19, 40);
            this.PexFood.Name = "PexFood";
            this.PexFood.Size = new System.Drawing.Size(341, 2);
            this.PexFood.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PexFood.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveCaption;
            this.PexFood.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.PexFood.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PexFood.Style.BorderColor.Color = System.Drawing.SystemColors.ActiveCaption;
            this.PexFood.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PexFood.Style.GradientAngle = 90;
            this.PexFood.TabIndex = 7;
            this.PexFood.Text = "panelEx1";
            // 
            // GrpPicture
            // 
            this.GrpPicture.CanvasColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GrpPicture.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GrpPicture.Controls.Add(this.RefImage);
            this.GrpPicture.Location = new System.Drawing.Point(457, 61);
            this.GrpPicture.Name = "GrpPicture";
            this.GrpPicture.Size = new System.Drawing.Size(140, 119);
            // 
            // 
            // 
            this.GrpPicture.Style.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GrpPicture.Style.BackColorGradientAngle = 90;
            this.GrpPicture.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpPicture.Style.BorderBottomWidth = 1;
            this.GrpPicture.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GrpPicture.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpPicture.Style.BorderLeftWidth = 1;
            this.GrpPicture.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpPicture.Style.BorderRightWidth = 1;
            this.GrpPicture.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GrpPicture.Style.BorderTopWidth = 1;
            this.GrpPicture.Style.CornerDiameter = 4;
            this.GrpPicture.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GrpPicture.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.GrpPicture.Style.TextShadowColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GrpPicture.TabIndex = 99;
            this.GrpPicture.Text = "图片";
            // 
            // RefImage
            // 
            this.RefImage.Location = new System.Drawing.Point(0, -7);
            this.RefImage.Name = "RefImage";
            this.RefImage.Size = new System.Drawing.Size(140, 105);
            this.RefImage.TabIndex = 0;
            // 
            // LabDescribe
            // 
            this.LabDescribe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabDescribe.Location = new System.Drawing.Point(19, 268);
            this.LabDescribe.Name = "LabDescribe";
            this.LabDescribe.Size = new System.Drawing.Size(39, 21);
            this.LabDescribe.TabIndex = 95;
            this.LabDescribe.Text = "描述";
            // 
            // LabFood
            // 
            this.LabFood.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabFood.Location = new System.Drawing.Point(19, 18);
            this.LabFood.Name = "LabFood";
            this.LabFood.Size = new System.Drawing.Size(75, 23);
            this.LabFood.TabIndex = 47;
            this.LabFood.Text = "菜品信息";
            // 
            // balloonTip1
            // 
            this.balloonTip1.DefaultBalloonWidth = 100;
            this.balloonTip1.ShowCloseButton = false;
            // 
            // CSDlgMenuReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 506);
            this.Controls.Add(this.GrpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CSDlgMenuReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜品";
            this.GrpMenu.ResumeLayout(false);
            this.GplSpe.ResumeLayout(false);
            this.GplSpe.PerformLayout();
            this.GplState.ResumeLayout(false);
            this.GplState.PerformLayout();
            this.GrpPicture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX LabId;
        private DevComponents.DotNetBar.Controls.TextBoxX TxbId;
        private DevComponents.DotNetBar.Controls.TextBoxX TxbName;
        private DevComponents.DotNetBar.LabelX LabName;
        private DevComponents.DotNetBar.LabelX LabPrice;
        private DevComponents.DotNetBar.LabelX LabType;
        private DevComponents.DotNetBar.Controls.GroupPanel GrpMenu;
        private DevComponents.DotNetBar.PanelEx PexFood;
        private DevComponents.DotNetBar.LabelX LabFood;
        private DevComponents.DotNetBar.Controls.GroupPanel GrpPicture;
        private DevComponents.DotNetBar.LabelX LabDescribe;
        private DevComponents.DotNetBar.Controls.ReflectionImage RefImage;
        private DevComponents.DotNetBar.Controls.TextBoxX TxbPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX TxbDescribe;
        private DevComponents.DotNetBar.Controls.TextBoxX TxbType;
        private DevComponents.DotNetBar.LabelX LabState;
        private DevComponents.DotNetBar.LabelX LabSpe;
        private DevComponents.DotNetBar.LabelX LabScore;
        private DevComponents.DotNetBar.Controls.TextBoxX TxbScore;
        private DevComponents.DotNetBar.LabelX LabDetail;
        private DevComponents.DotNetBar.PanelEx PexDetail;
        private DevComponents.DotNetBar.ButtonX BtnReset;
        private DevComponents.DotNetBar.ButtonX BtnRegister;
        private DevComponents.DotNetBar.Controls.GroupPanel GplSpe;
        private System.Windows.Forms.RadioButton TbxNotspe;
        private System.Windows.Forms.RadioButton TbxSpe;
        private DevComponents.DotNetBar.Controls.GroupPanel GplState;
        private System.Windows.Forms.RadioButton TbxCannotbuy;
        private System.Windows.Forms.RadioButton TbxCanbuy;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.Controls.TextBoxX TxbPicture;
        private DevComponents.DotNetBar.LabelX LabPicture;
        private DevComponents.DotNetBar.ButtonX Btnscan;
        private DevComponents.DotNetBar.LabelX LabTxbDescribe;
        private DevComponents.DotNetBar.LabelX LabTxbScore;
        private DevComponents.DotNetBar.LabelX LabTxbType;
        private DevComponents.DotNetBar.LabelX LabTxbPrice;
        private DevComponents.DotNetBar.LabelX LabTxbName;
        private DevComponents.DotNetBar.LabelX LabTxbId;
        private DevComponents.DotNetBar.LabelX LabTxbPicture;


    }
}