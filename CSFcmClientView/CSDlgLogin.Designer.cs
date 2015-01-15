namespace CSFcmClientView
{
    partial class CSDlgLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSDlgLogin));
            this.Account = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Login = new DevComponents.DotNetBar.ButtonX();
            this.Role_Image = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.FindPassword = new DevComponents.DotNetBar.LabelX();
            this.RegisterAccount = new DevComponents.DotNetBar.LabelX();
            this.Login_group = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Restaurant = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Manager = new System.Windows.Forms.RadioButton();
            this.Reset = new DevComponents.DotNetBar.ButtonX();
            this.Login_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Account
            // 
            this.Account.DisplayMember = "Text";
            this.Account.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Account.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Account.FormattingEnabled = true;
            this.Account.ItemHeight = 14;
            this.Account.Location = new System.Drawing.Point(110, 112);
            this.Account.MaxLength = 18;
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(163, 20);
            this.Account.TabIndex = 1;
            // 
            // Password
            // 
            // 
            // 
            // 
            this.Password.Border.Class = "TextBoxBorder";
            this.Password.Location = new System.Drawing.Point(110, 145);
            this.Password.MaxLength = 18;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(163, 21);
            this.Password.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Login.Location = new System.Drawing.Point(91, 218);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(78, 23);
            this.Login.TabIndex = 7;
            this.Login.Text = "登 录";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Role_Image
            // 
            this.Role_Image.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Role_Image.Image = global::CSFcmClientView.Properties.Resources.lg_admin;
            this.Role_Image.Location = new System.Drawing.Point(13, 13);
            this.Role_Image.Name = "Role_Image";
            this.Role_Image.Size = new System.Drawing.Size(82, 82);
            this.Role_Image.TabIndex = 2;
            // 
            // FindPassword
            // 
            this.FindPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FindPassword.Location = new System.Drawing.Point(272, 49);
            this.FindPassword.Name = "FindPassword";
            this.FindPassword.Size = new System.Drawing.Size(57, 21);
            this.FindPassword.TabIndex = 8;
            this.FindPassword.Text = "找回密码";
            // 
            // RegisterAccount
            // 
            this.RegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RegisterAccount.Location = new System.Drawing.Point(272, 15);
            this.RegisterAccount.Name = "RegisterAccount";
            this.RegisterAccount.Size = new System.Drawing.Size(57, 20);
            this.RegisterAccount.TabIndex = 7;
            this.RegisterAccount.Text = "注册帐号";
            this.RegisterAccount.MouseLeave += new System.EventHandler(this.RegisterAccount_MouseLeave);
            this.RegisterAccount.Click += new System.EventHandler(this.RegisterAccount_Click);
            this.RegisterAccount.MouseHover += new System.EventHandler(this.RegisterAccount_MouseHover);
            // 
            // Login_group
            // 
            this.Login_group.BackColor = System.Drawing.Color.Transparent;
            this.Login_group.CanvasColor = System.Drawing.SystemColors.Control;
            this.Login_group.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Login_group.Controls.Add(this.Restaurant);
            this.Login_group.Controls.Add(this.Role_Image);
            this.Login_group.Controls.Add(this.FindPassword);
            this.Login_group.Controls.Add(this.Student);
            this.Login_group.Controls.Add(this.RegisterAccount);
            this.Login_group.Controls.Add(this.Manager);
            this.Login_group.Location = new System.Drawing.Point(6, 98);
            this.Login_group.Name = "Login_group";
            this.Login_group.Size = new System.Drawing.Size(343, 107);
            // 
            // 
            // 
            this.Login_group.Style.BackColor = System.Drawing.Color.Transparent;
            this.Login_group.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.Login_group.Style.BackColorGradientAngle = 90;
            this.Login_group.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Login_group.Style.BorderBottomWidth = 1;
            this.Login_group.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Login_group.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Login_group.Style.BorderLeftWidth = 1;
            this.Login_group.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Login_group.Style.BorderRightWidth = 1;
            this.Login_group.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Login_group.Style.BorderTopWidth = 1;
            this.Login_group.Style.CornerDiameter = 4;
            this.Login_group.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Login_group.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Login_group.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.Login_group.TabIndex = 6;
            // 
            // Restaurant
            // 
            this.Restaurant.AutoSize = true;
            this.Restaurant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
            this.Restaurant.Location = new System.Drawing.Point(220, 78);
            this.Restaurant.Name = "Restaurant";
            this.Restaurant.Size = new System.Drawing.Size(47, 16);
            this.Restaurant.TabIndex = 5;
            this.Restaurant.Text = "餐馆";
            this.Restaurant.UseVisualStyleBackColor = true;
            this.Restaurant.CheckedChanged += new System.EventHandler(this.Restaurant_CheckedChanged);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
            this.Student.Location = new System.Drawing.Point(167, 78);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(47, 16);
            this.Student.TabIndex = 4;
            this.Student.Text = "学生";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.CheckedChanged += new System.EventHandler(this.Student_CheckedChanged);
            // 
            // Manager
            // 
            this.Manager.AutoSize = true;
            this.Manager.Checked = true;
            this.Manager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(67)))), ((int)(((byte)(144)))));
            this.Manager.Location = new System.Drawing.Point(103, 78);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(59, 16);
            this.Manager.TabIndex = 3;
            this.Manager.TabStop = true;
            this.Manager.Text = "管理员";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.CheckedChanged += new System.EventHandler(this.Manager_CheckedChanged);
            // 
            // Reset
            // 
            this.Reset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Reset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Reset.Location = new System.Drawing.Point(196, 218);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(78, 23);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "重置";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // CSDlgLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSFcmClientView.Properties.Resources.lg_background;
            this.ClientSize = new System.Drawing.Size(354, 253);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Login_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CSDlgLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐馆系统登录";
            this.Load += new System.EventHandler(this.CSDlgLogin_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CSDlgLogin_FormClosing);
            this.Login_group.ResumeLayout(false);
            this.Login_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx Account;
        private DevComponents.DotNetBar.Controls.TextBoxX Password;
        private DevComponents.DotNetBar.ButtonX Login;
        private DevComponents.DotNetBar.Controls.ReflectionImage Role_Image;
        private DevComponents.DotNetBar.LabelX FindPassword;
        private DevComponents.DotNetBar.LabelX RegisterAccount;
        private DevComponents.DotNetBar.Controls.GroupPanel Login_group;
        private System.Windows.Forms.RadioButton Restaurant;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.RadioButton Manager;
        private DevComponents.DotNetBar.ButtonX Reset;




    }
}

