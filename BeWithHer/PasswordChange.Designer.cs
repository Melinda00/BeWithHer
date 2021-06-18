
namespace BeWithHer
{
    partial class PasswordChange
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
            this.new_password_lable = new System.Windows.Forms.Label();
            this.new_password_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_password_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.old_password_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.change_password = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_password_lable
            // 
            this.new_password_lable.AutoSize = true;
            this.new_password_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.new_password_lable.Location = new System.Drawing.Point(46, 71);
            this.new_password_lable.Name = "new_password_lable";
            this.new_password_lable.Size = new System.Drawing.Size(72, 25);
            this.new_password_lable.TabIndex = 1;
            this.new_password_lable.Text = "新密码";
            // 
            // new_password_txtbox
            // 
            this.new_password_txtbox.Location = new System.Drawing.Point(138, 68);
            this.new_password_txtbox.Name = "new_password_txtbox";
            this.new_password_txtbox.Size = new System.Drawing.Size(171, 25);
            this.new_password_txtbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "确认新密码";
            // 
            // confirm_password_txtbox
            // 
            this.confirm_password_txtbox.Location = new System.Drawing.Point(138, 120);
            this.confirm_password_txtbox.Name = "confirm_password_txtbox";
            this.confirm_password_txtbox.Size = new System.Drawing.Size(171, 25);
            this.confirm_password_txtbox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirm_password_txtbox);
            this.groupBox1.Controls.Add(this.new_password_lable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.new_password_txtbox);
            this.groupBox1.Location = new System.Drawing.Point(353, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 191);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "更新信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.account);
            this.groupBox2.Controls.Add(this.old_password_txtbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 191);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "账号信息";
            // 
            // old_password_txtbox
            // 
            this.old_password_txtbox.Location = new System.Drawing.Point(87, 120);
            this.old_password_txtbox.Name = "old_password_txtbox";
            this.old_password_txtbox.Size = new System.Drawing.Size(171, 25);
            this.old_password_txtbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "原密码";
            // 
            // change_password
            // 
            this.change_password.Location = new System.Drawing.Point(762, 110);
            this.change_password.Name = "change_password";
            this.change_password.Size = new System.Drawing.Size(130, 33);
            this.change_password.TabIndex = 10;
            this.change_password.Text = "确认修改";
            this.change_password.UseVisualStyleBackColor = true;
            this.change_password.Click += new System.EventHandler(this.change_password_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(762, 160);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(130, 33);
            this.cancel_button.TabIndex = 11;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.account.Location = new System.Drawing.Point(89, 74);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(119, 19);
            this.account.TabIndex = 8;
            this.account.Text = "placeholder";
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 315);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.change_password);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.Load += new System.EventHandler(this.PasswordChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label new_password_lable;
        private System.Windows.Forms.TextBox new_password_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirm_password_txtbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox old_password_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button change_password;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label account;
    }
}