
namespace BeWithHer
{
    partial class DoctorMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myaccount = new System.Windows.Forms.ToolStripMenuItem();
            this.change_myinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mycon = new System.Windows.Forms.ToolStripMenuItem();
            this.history_con = new System.Windows.Forms.ToolStripMenuItem();
            this.reserve_con = new System.Windows.Forms.ToolStripMenuItem();
            this.myreport = new System.Windows.Forms.ToolStripMenuItem();
            this.con_report = new System.Windows.Forms.ToolStripMenuItem();
            this.about_us = new System.Windows.Forms.ToolStripMenuItem();
            this.待回复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myaccount,
            this.mycon,
            this.myreport,
            this.about_us});
            this.menuStrip1.Location = new System.Drawing.Point(1, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myaccount
            // 
            this.myaccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.change_myinfo,
            this.修改密码ToolStripMenuItem,
            this.logout});
            this.myaccount.Name = "myaccount";
            this.myaccount.Size = new System.Drawing.Size(83, 24);
            this.myaccount.Text = "我的账号";
            // 
            // change_myinfo
            // 
            this.change_myinfo.Name = "change_myinfo";
            this.change_myinfo.Size = new System.Drawing.Size(182, 26);
            this.change_myinfo.Text = "修改个人信息";
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(182, 26);
            this.logout.Text = "退出登录";
            // 
            // mycon
            // 
            this.mycon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.待回复ToolStripMenuItem,
            this.reserve_con,
            this.history_con});
            this.mycon.Name = "mycon";
            this.mycon.Size = new System.Drawing.Size(83, 24);
            this.mycon.Text = "我的咨询";
            // 
            // history_con
            // 
            this.history_con.Name = "history_con";
            this.history_con.Size = new System.Drawing.Size(152, 26);
            this.history_con.Text = "历史咨询";
            // 
            // reserve_con
            // 
            this.reserve_con.Name = "reserve_con";
            this.reserve_con.Size = new System.Drawing.Size(224, 26);
            this.reserve_con.Text = "预约列表";
            // 
            // myreport
            // 
            this.myreport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.con_report});
            this.myreport.Name = "myreport";
            this.myreport.Size = new System.Drawing.Size(113, 26);
            this.myreport.Text = "咨询统计报告";
            // 
            // con_report
            // 
            this.con_report.Name = "con_report";
            this.con_report.Size = new System.Drawing.Size(182, 26);
            this.con_report.Text = "咨询统计";
            // 
            // about_us
            // 
            this.about_us.Name = "about_us";
            this.about_us.Size = new System.Drawing.Size(132, 24);
            this.about_us.Text = "关于BeWithHer";
            // 
            // 待回复ToolStripMenuItem
            // 
            this.待回复ToolStripMenuItem.Name = "待回复ToolStripMenuItem";
            this.待回复ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.待回复ToolStripMenuItem.Text = "待回复咨询";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // DoctorMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DoctorMainMenu";
            this.Text = "DoctorMainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myaccount;
        private System.Windows.Forms.ToolStripMenuItem change_myinfo;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem mycon;
        private System.Windows.Forms.ToolStripMenuItem history_con;
        private System.Windows.Forms.ToolStripMenuItem reserve_con;
        private System.Windows.Forms.ToolStripMenuItem myreport;
        private System.Windows.Forms.ToolStripMenuItem con_report;
        private System.Windows.Forms.ToolStripMenuItem about_us;
        private System.Windows.Forms.ToolStripMenuItem 待回复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
    }
}