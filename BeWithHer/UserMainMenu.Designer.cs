
namespace BeWithHer
{
    partial class UserMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.menu_label = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myaccount = new System.Windows.Forms.ToolStripMenuItem();
            this.change_myinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mycon = new System.Windows.Forms.ToolStripMenuItem();
            this.new_consult = new System.Windows.Forms.ToolStripMenuItem();
            this.history_con = new System.Windows.Forms.ToolStripMenuItem();
            this.reserve_con = new System.Windows.Forms.ToolStripMenuItem();
            this.mydoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.reserve_doctor = new System.Windows.Forms.ToolStripMenuItem();
            this.contact_doctor = new System.Windows.Forms.ToolStripMenuItem();
            this.myreport = new System.Windows.Forms.ToolStripMenuItem();
            this.con_report = new System.Windows.Forms.ToolStripMenuItem();
            this.info_report = new System.Windows.Forms.ToolStripMenuItem();
            this.about_us = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Location = new System.Drawing.Point(331, 118);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(82, 15);
            this.menu_label.TabIndex = 0;
            this.menu_label.Text = "用户主界面";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(801, 160);
            this.toolStripContainer1.Location = new System.Drawing.Point(1, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(801, 188);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myaccount,
            this.mycon,
            this.mydoctor,
            this.myreport,
            this.about_us});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myaccount
            // 
            this.myaccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.change_myinfo,
            this.logout});
            this.myaccount.Name = "myaccount";
            this.myaccount.Size = new System.Drawing.Size(83, 24);
            this.myaccount.Text = "我的账号";
            // 
            // change_myinfo
            // 
            this.change_myinfo.Name = "change_myinfo";
            this.change_myinfo.Size = new System.Drawing.Size(224, 26);
            this.change_myinfo.Text = "修改个人信息";
            this.change_myinfo.Click += new System.EventHandler(this.change_myinfo_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(224, 26);
            this.logout.Text = "退出登录";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // mycon
            // 
            this.mycon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_consult,
            this.history_con,
            this.reserve_con});
            this.mycon.Name = "mycon";
            this.mycon.Size = new System.Drawing.Size(83, 24);
            this.mycon.Text = "我的咨询";
            // 
            // new_consult
            // 
            this.new_consult.Name = "new_consult";
            this.new_consult.Size = new System.Drawing.Size(152, 26);
            this.new_consult.Text = "新建咨询";
            this.new_consult.Click += new System.EventHandler(this.new_consult_Click);
            // 
            // history_con
            // 
            this.history_con.Name = "history_con";
            this.history_con.Size = new System.Drawing.Size(224, 26);
            this.history_con.Text = "历史咨询";
            this.history_con.Click += new System.EventHandler(this.history_con_Click);
            // 
            // reserve_con
            // 
            this.reserve_con.Name = "reserve_con";
            this.reserve_con.Size = new System.Drawing.Size(224, 26);
            this.reserve_con.Text = "预约咨询";
            this.reserve_con.Click += new System.EventHandler(this.reserve_con_Click);
            // 
            // mydoctor
            // 
            this.mydoctor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserve_doctor,
            this.contact_doctor});
            this.mydoctor.Name = "mydoctor";
            this.mydoctor.Size = new System.Drawing.Size(83, 24);
            this.mydoctor.Text = "我的医生";
            // 
            // reserve_doctor
            // 
            this.reserve_doctor.Name = "reserve_doctor";
            this.reserve_doctor.Size = new System.Drawing.Size(182, 26);
            this.reserve_doctor.Text = "预约医生";
            // 
            // contact_doctor
            // 
            this.contact_doctor.Name = "contact_doctor";
            this.contact_doctor.Size = new System.Drawing.Size(182, 26);
            this.contact_doctor.Text = "联系我的医生";
            // 
            // myreport
            // 
            this.myreport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.con_report,
            this.info_report});
            this.myreport.Name = "myreport";
            this.myreport.Size = new System.Drawing.Size(113, 24);
            this.myreport.Text = "我的统计报告";
            // 
            // con_report
            // 
            this.con_report.Name = "con_report";
            this.con_report.Size = new System.Drawing.Size(182, 26);
            this.con_report.Text = "咨询统计";
            // 
            // info_report
            // 
            this.info_report.Name = "info_report";
            this.info_report.Size = new System.Drawing.Size(182, 26);
            this.info_report.Text = "经期信息统计";
            // 
            // about_us
            // 
            this.about_us.Name = "about_us";
            this.about_us.Size = new System.Drawing.Size(132, 24);
            this.about_us.Text = "关于BeWithHer";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menu_label);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserMainMenu";
            this.Text = "UserMainMenu";
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myaccount;
        private System.Windows.Forms.ToolStripMenuItem change_myinfo;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem mycon;
        private System.Windows.Forms.ToolStripMenuItem new_consult;
        private System.Windows.Forms.ToolStripMenuItem history_con;
        private System.Windows.Forms.ToolStripMenuItem reserve_con;
        private System.Windows.Forms.ToolStripMenuItem mydoctor;
        private System.Windows.Forms.ToolStripMenuItem reserve_doctor;
        private System.Windows.Forms.ToolStripMenuItem contact_doctor;
        private System.Windows.Forms.ToolStripMenuItem myreport;
        private System.Windows.Forms.ToolStripMenuItem about_us;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem con_report;
        private System.Windows.Forms.ToolStripMenuItem info_report;
    }
}