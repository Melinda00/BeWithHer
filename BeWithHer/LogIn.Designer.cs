
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
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.uid_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.uid_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(375, 224);
            this.login_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(58, 33);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "登录";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(171, 224);
            this.register_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(63, 33);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "注册";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // uid_label
            // 
            this.uid_label.AutoSize = true;
            this.uid_label.Location = new System.Drawing.Point(169, 82);
            this.uid_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uid_label.Name = "uid_label";
            this.uid_label.Size = new System.Drawing.Size(29, 12);
            this.uid_label.TabIndex = 2;
            this.uid_label.Text = "账号";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(169, 135);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(29, 12);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "密码";
            // 
            // uid_txtbox
            // 
            this.uid_txtbox.Location = new System.Drawing.Point(313, 74);
            this.uid_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uid_txtbox.Name = "uid_txtbox";
            this.uid_txtbox.Size = new System.Drawing.Size(132, 21);
            this.uid_txtbox.TabIndex = 4;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(313, 135);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(132, 21);
            this.password_txtbox.TabIndex = 5;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.uid_txtbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.uid_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogIn";
            this.Text = "LogIn";
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
    }
}