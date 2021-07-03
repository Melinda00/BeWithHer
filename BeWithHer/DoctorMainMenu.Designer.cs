
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myaccount = new System.Windows.Forms.ToolStripMenuItem();
            this.change_password = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mycon = new System.Windows.Forms.ToolStripMenuItem();
            this.unreplied_consult = new System.Windows.Forms.ToolStripMenuItem();
            this.history_con = new System.Windows.Forms.ToolStripMenuItem();
            this.myreport = new System.Windows.Forms.ToolStripMenuItem();
            this.con_report = new System.Windows.Forms.ToolStripMenuItem();
            this.dept_mgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.about_us = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dept_mgmt,
            this.about_us,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, -2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myaccount
            // 
            this.myaccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.change_password,
            this.logout});
            this.myaccount.Name = "myaccount";
            this.myaccount.Size = new System.Drawing.Size(83, 26);
            this.myaccount.Text = "我的账号";
            // 
            // change_password
            // 
            this.change_password.Name = "change_password";
            this.change_password.Size = new System.Drawing.Size(152, 26);
            this.change_password.Text = "修改密码";
            this.change_password.Click += new System.EventHandler(this.change_password_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(152, 26);
            this.logout.Text = "退出登录";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // mycon
            // 
            this.mycon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unreplied_consult,
            this.history_con});
            this.mycon.Name = "mycon";
            this.mycon.Size = new System.Drawing.Size(83, 26);
            this.mycon.Text = "我的咨询";
            // 
            // unreplied_consult
            // 
            this.unreplied_consult.Name = "unreplied_consult";
            this.unreplied_consult.Size = new System.Drawing.Size(167, 26);
            this.unreplied_consult.Text = "待回复咨询";
            this.unreplied_consult.Click += new System.EventHandler(this.unreplied_consult_Click);
            // 
            // history_con
            // 
            this.history_con.Name = "history_con";
            this.history_con.Size = new System.Drawing.Size(167, 26);
            this.history_con.Text = "历史咨询";
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
            this.con_report.Size = new System.Drawing.Size(152, 26);
            this.con_report.Text = "咨询统计";
            // 
            // dept_mgmt
            // 
            this.dept_mgmt.Name = "dept_mgmt";
            this.dept_mgmt.Size = new System.Drawing.Size(83, 26);
            this.dept_mgmt.Text = "科室管理";
            this.dept_mgmt.Click += new System.EventHandler(this.dept_mgmt_Click);
            // 
            // about_us
            // 
            this.about_us.Name = "about_us";
            this.about_us.Size = new System.Drawing.Size(132, 26);
            this.about_us.Text = "关于BeWithHer";
            this.about_us.Click += new System.EventHandler(this.about_us_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正清刻本悦宋简体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-2, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "予她同行——BeWithHer经期咨询信息管理系统 医生主界面";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.toolStripMenuItem1.Text = "                                                ";
            // 
            // DoctorMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(648, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DoctorMainMenu";
            this.Text = "医生主界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myaccount;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem mycon;
        private System.Windows.Forms.ToolStripMenuItem history_con;
        private System.Windows.Forms.ToolStripMenuItem myreport;
        private System.Windows.Forms.ToolStripMenuItem con_report;
        private System.Windows.Forms.ToolStripMenuItem about_us;
        private System.Windows.Forms.ToolStripMenuItem unreplied_consult;
        private System.Windows.Forms.ToolStripMenuItem change_password;
        private System.Windows.Forms.ToolStripMenuItem dept_mgmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}