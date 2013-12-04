namespace PigManagerSystem
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.PigMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SellMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.KucunMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemSetingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserNameToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.systemTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PigMenu,
            this.SellMenu,
            this.KucunMenu,
            this.MoneyMenu,
            this.MemberMenu,
            this.SystemSetingMenuItem,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(878, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // PigMenu
            // 
            this.PigMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PigMenu.Image = ((System.Drawing.Image)(resources.GetObject("PigMenu.Image")));
            this.PigMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.PigMenu.Name = "PigMenu";
            this.PigMenu.Size = new System.Drawing.Size(81, 20);
            this.PigMenu.Text = "种猪管理";
            this.PigMenu.Click += new System.EventHandler(this.PigMenu_Click);
            // 
            // SellMenu
            // 
            this.SellMenu.Image = ((System.Drawing.Image)(resources.GetObject("SellMenu.Image")));
            this.SellMenu.Name = "SellMenu";
            this.SellMenu.Size = new System.Drawing.Size(81, 20);
            this.SellMenu.Text = "销售管理";
            this.SellMenu.Click += new System.EventHandler(this.SellMenu_Click);
            // 
            // KucunMenu
            // 
            this.KucunMenu.Image = ((System.Drawing.Image)(resources.GetObject("KucunMenu.Image")));
            this.KucunMenu.Name = "KucunMenu";
            this.KucunMenu.Size = new System.Drawing.Size(81, 20);
            this.KucunMenu.Text = "库存管理";
            this.KucunMenu.Click += new System.EventHandler(this.KucunMenu_Click);
            // 
            // MoneyMenu
            // 
            this.MoneyMenu.Image = ((System.Drawing.Image)(resources.GetObject("MoneyMenu.Image")));
            this.MoneyMenu.Name = "MoneyMenu";
            this.MoneyMenu.Size = new System.Drawing.Size(81, 20);
            this.MoneyMenu.Text = "财务管理";
            this.MoneyMenu.Click += new System.EventHandler(this.MoneyMenu_Click);
            // 
            // MemberMenu
            // 
            this.MemberMenu.Image = ((System.Drawing.Image)(resources.GetObject("MemberMenu.Image")));
            this.MemberMenu.Name = "MemberMenu";
            this.MemberMenu.Size = new System.Drawing.Size(81, 20);
            this.MemberMenu.Text = "人员管理";
            this.MemberMenu.Click += new System.EventHandler(this.MemberMenu_Click);
            // 
            // SystemSetingMenuItem
            // 
            this.SystemSetingMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SystemSetingMenuItem.Image")));
            this.SystemSetingMenuItem.Name = "SystemSetingMenuItem";
            this.SystemSetingMenuItem.Size = new System.Drawing.Size(81, 20);
            this.SystemSetingMenuItem.Text = "系统管理";
            this.SystemSetingMenuItem.Click += new System.EventHandler(this.SystemSetingMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Image = ((System.Drawing.Image)(resources.GetObject("windowsMenu.Image")));
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(81, 20);
            this.windowsMenu.Text = "窗口控制";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cascadeToolStripMenuItem.Text = "层叠(&C)";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tileVerticalToolStripMenuItem.Text = "垂直平铺(&V)";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tileHorizontalToolStripMenuItem.Text = "水平平铺(&H)";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.closeAllToolStripMenuItem.Text = "全部关闭(&L)";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.Image = ((System.Drawing.Image)(resources.GetObject("helpMenu.Image")));
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(75, 20);
            this.helpMenu.Text = "帮助(&H)";
            this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUserName,
            this.UserNameToolStrip,
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.systemTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 489);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(878, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolUserName
            // 
            this.toolUserName.Name = "toolUserName";
            this.toolUserName.Size = new System.Drawing.Size(47, 17);
            this.toolUserName.Text = "用户名:";
            // 
            // UserNameToolStrip
            // 
            this.UserNameToolStrip.Name = "UserNameToolStrip";
            this.UserNameToolStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel.Text = "版本信息:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(773, 12);
            this.toolStripStatusLabel1.Text = "1.01                                                                             " +
    "                                               ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(59, 12);
            this.toolStripStatusLabel3.Text = "系统时间:";
            // 
            // systemTime
            // 
            this.systemTime.Name = "systemTime";
            this.systemTime.Size = new System.Drawing.Size(0, 0);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(878, 511);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "养猪管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PigMenu;
        private System.Windows.Forms.ToolStripMenuItem SellMenu;
        private System.Windows.Forms.ToolStripMenuItem KucunMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel systemTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem SystemSetingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemberMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolUserName;
        private System.Windows.Forms.ToolStripStatusLabel UserNameToolStrip;
        private System.Windows.Forms.ToolStripMenuItem MoneyMenu;
    }
}



