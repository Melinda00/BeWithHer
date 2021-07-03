
namespace BeWithHer
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.uid_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.uid_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.login_button.Font = new System.Drawing.Font("方正清刻本悦宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_button.Location = new System.Drawing.Point(452, 319);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(77, 41);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "登录";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.register_button.Font = new System.Drawing.Font("方正清刻本悦宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.register_button.Location = new System.Drawing.Point(263, 319);
            this.register_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(84, 41);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "注册";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // uid_label
            // 
            this.uid_label.AutoSize = true;
            this.uid_label.BackColor = System.Drawing.Color.Transparent;
            this.uid_label.Font = new System.Drawing.Font("方正清刻本悦宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uid_label.Location = new System.Drawing.Point(259, 163);
            this.uid_label.Name = "uid_label";
            this.uid_label.Size = new System.Drawing.Size(50, 22);
            this.uid_label.TabIndex = 2;
            this.uid_label.Text = "账号";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("方正清刻本悦宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_label.Location = new System.Drawing.Point(259, 244);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(50, 22);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "密码";
            // 
            // uid_txtbox
            // 
            this.uid_txtbox.Location = new System.Drawing.Point(354, 164);
            this.uid_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uid_txtbox.Name = "uid_txtbox";
            this.uid_txtbox.Size = new System.Drawing.Size(175, 25);
            this.uid_txtbox.TabIndex = 4;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(354, 241);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(175, 25);
            this.password_txtbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正清刻本悦宋简体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "BeWithHer——经期咨询管理系统";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.uid_txtbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.uid_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn";
            this.Text = "准备开始记录吧";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label uid_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox uid_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Label label1;
    }
}