
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
            this.login_button.Location = new System.Drawing.Point(225, 280);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "登陆";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(442, 280);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "注册";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // uid_label
            // 
            this.uid_label.AutoSize = true;
            this.uid_label.Location = new System.Drawing.Point(225, 103);
            this.uid_label.Name = "uid_label";
            this.uid_label.Size = new System.Drawing.Size(37, 15);
            this.uid_label.TabIndex = 2;
            this.uid_label.Text = "账号";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(225, 169);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(37, 15);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "密码";
            // 
            // uid_txtbox
            // 
            this.uid_txtbox.Location = new System.Drawing.Point(417, 93);
            this.uid_txtbox.Name = "uid_txtbox";
            this.uid_txtbox.Size = new System.Drawing.Size(175, 25);
            this.uid_txtbox.TabIndex = 4;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(417, 169);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(175, 25);
            this.password_txtbox.TabIndex = 5;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.uid_txtbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.uid_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
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