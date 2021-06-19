
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
            this.change_password = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mycon = new System.Windows.Forms.ToolStripMenuItem();
            this.unreplied_consult = new System.Windows.Forms.ToolStripMenuItem();
            this.reserve_con = new System.Windows.Forms.ToolStripMenuItem();
            this.history_con = new System.Windows.Forms.ToolStripMenuItem();
            this.myreport = new System.Windows.Forms.ToolStripMenuItem();
            this.con_report = new System.Windows.Forms.ToolStripMenuItem();
            this.about_us = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(569, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myaccount
            // 
            this.myaccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.change_myinfo,
            this.change_password,
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
            // change_password
            // 
            this.change_password.Name = "change_password";
            this.change_password.Size = new System.Drawing.Size(182, 26);
            this.change_password.Text = "修改密码";
            this.change_password.Click += new System.EventHandler(this.change_password_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(182, 26);
            this.logout.Text = "退出登录";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // mycon
            // 
            this.mycon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unreplied_consult,
            this.reserve_con,
            this.history_con});
            this.mycon.Name = "mycon";
            this.mycon.Size = new System.Drawing.Size(83, 24);
            this.mycon.Text = "我的咨询";
            // 
            // unreplied_consult
            // 
            this.unreplied_consult.Name = "unreplied_consult";
            this.unreplied_consult.Size = new System.Drawing.Size(224, 26);
            this.unreplied_consult.Text = "待回复咨询";
            this.unreplied_consult.Click += new System.EventHandler(this.unreplied_consult_Click);
            // 
            // reserve_con
            // 
            this.reserve_con.Name = "reserve_con";
            this.reserve_con.Size = new System.Drawing.Size(224, 26);
            this.reserve_con.Text = "预约列表";
            this.reserve_con.Click += new System.EventHandler(this.reserve_con_Click);
            // 
            // history_con
            // 
            this.history_con.Name = "history_con";
            this.history_con.Size = new System.Drawing.Size(224, 26);
            this.history_con.Text = "历史咨询";
            // 
            // myreport
            // 
            this.myreport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.con_report});
            this.myreport.Name = "myreport";
            this.myreport.Size = new System.Drawing.Size(113, 24);
            this.myreport.Text = "咨询统计报告";
            // 
            // con_report
            // 
            this.con_report.Name = "con_report";
            this.con_report.Size = new System.Drawing.Size(152, 26);
            this.con_report.Text = "咨询统计";
            // 
            // about_us
            // 
            this.about_us.Name = "about_us";
            this.about_us.Size = new System.Drawing.Size(132, 24);
            this.about_us.Text = "关于BeWithHer";
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
        private System.Windows.Forms.ToolStripMenuItem unreplied_consult;
        private System.Windows.Forms.ToolStripMenuItem change_password;
    }
}