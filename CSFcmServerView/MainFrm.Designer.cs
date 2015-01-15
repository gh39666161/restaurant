namespace CSFcmServerView
{
    partial class MainFrm
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
            this.BtnServerStartup = new DevComponents.DotNetBar.ButtonX();
            this.BtnServerShutdown = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // BtnServerStartup
            // 
            this.BtnServerStartup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnServerStartup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnServerStartup.Location = new System.Drawing.Point(234, 33);
            this.BtnServerStartup.Name = "BtnServerStartup";
            this.BtnServerStartup.Size = new System.Drawing.Size(75, 23);
            this.BtnServerStartup.TabIndex = 0;
            this.BtnServerStartup.Text = "开启服务器";
            this.BtnServerStartup.Click += new System.EventHandler(this.BtnServerStartup_Click);
            // 
            // BtnServerShutdown
            // 
            this.BtnServerShutdown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnServerShutdown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnServerShutdown.Location = new System.Drawing.Point(234, 75);
            this.BtnServerShutdown.Name = "BtnServerShutdown";
            this.BtnServerShutdown.Size = new System.Drawing.Size(75, 23);
            this.BtnServerShutdown.TabIndex = 1;
            this.BtnServerShutdown.Text = "退出服务器";
            this.BtnServerShutdown.Click += new System.EventHandler(this.BtnServerShutdown_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 130);
            this.Controls.Add(this.BtnServerShutdown);
            this.Controls.Add(this.BtnServerStartup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BtnServerStartup;
        private DevComponents.DotNetBar.ButtonX BtnServerShutdown;
    }
}

