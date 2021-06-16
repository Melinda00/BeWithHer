
namespace BeWithHer
{
    partial class UserRegister
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uid_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.nickname_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.period_label = new System.Windows.Forms.Label();
            this.uid_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.nickname_txtbox = new System.Windows.Forms.TextBox();
            this.age_txtbox = new System.Windows.Forms.TextBox();
            this.phone_txtbox = new System.Windows.Forms.TextBox();
            this.period_txtbox = new System.Windows.Forms.TextBox();
            this.register_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.goback_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uid_label
            // 
            this.uid_label.AutoSize = true;
            this.uid_label.Location = new System.Drawing.Point(123, 78);
            this.uid_label.Name = "uid_label";
            this.uid_label.Size = new System.Drawing.Size(37, 15);
            this.uid_label.TabIndex = 0;
            this.uid_label.Text = "账号";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(123, 124);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(37, 15);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "密码";
            // 
            // nickname_label
            // 
            this.nickname_label.AutoSize = true;
            this.nickname_label.Location = new System.Drawing.Point(123, 168);
            this.nickname_label.Name = "nickname_label";
            this.nickname_label.Size = new System.Drawing.Size(37, 15);
            this.nickname_label.TabIndex = 2;
            this.nickname_label.Text = "昵称";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(123, 210);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(37, 15);
            this.age_label.TabIndex = 3;
            this.age_label.Text = "年龄";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(123, 252);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(37, 15);
            this.phone_label.TabIndex = 4;
            this.phone_label.Text = "电话";
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.Location = new System.Drawing.Point(123, 300);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(37, 15);
            this.period_label.TabIndex = 5;
            this.period_label.Text = "周期";
            // 
            // uid_txtbox
            // 
            this.uid_txtbox.Location = new System.Drawing.Point(255, 75);
            this.uid_txtbox.Name = "uid_txtbox";
            this.uid_txtbox.Size = new System.Drawing.Size(240, 25);
            this.uid_txtbox.TabIndex = 6;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(255, 121);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(240, 25);
            this.password_txtbox.TabIndex = 7;
            // 
            // nickname_txtbox
            // 
            this.nickname_txtbox.Location = new System.Drawing.Point(255, 165);
            this.nickname_txtbox.Name = "nickname_txtbox";
            this.nickname_txtbox.Size = new System.Drawing.Size(240, 25);
            this.nickname_txtbox.TabIndex = 8;
            // 
            // age_txtbox
            // 
            this.age_txtbox.Location = new System.Drawing.Point(255, 207);
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(240, 25);
            this.age_txtbox.TabIndex = 9;
            // 
            // phone_txtbox
            // 
            this.phone_txtbox.Location = new System.Drawing.Point(255, 249);
            this.phone_txtbox.Name = "phone_txtbox";
            this.phone_txtbox.Size = new System.Drawing.Size(240, 25);
            this.phone_txtbox.TabIndex = 10;
            // 
            // period_txtbox
            // 
            this.period_txtbox.Location = new System.Drawing.Point(255, 297);
            this.period_txtbox.Name = "period_txtbox";
            this.period_txtbox.Size = new System.Drawing.Size(240, 25);
            this.period_txtbox.TabIndex = 11;
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Location = new System.Drawing.Point(338, 45);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(67, 15);
            this.register_label.TabIndex = 12;
            this.register_label.Text = "用户注册";
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(169, 355);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(96, 34);
            this.register_button.TabIndex = 13;
            this.register_button.Text = "注册";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // goback_button
            // 
            this.goback_button.Location = new System.Drawing.Point(424, 355);
            this.goback_button.Name = "goback_button";
            this.goback_button.Size = new System.Drawing.Size(96, 34);
            this.goback_button.TabIndex = 16;
            this.goback_button.Text = "后退";
            this.goback_button.UseVisualStyleBackColor = true;
            this.goback_button.Click += new System.EventHandler(this.goback_button_Click);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goback_button);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.period_txtbox);
            this.Controls.Add(this.phone_txtbox);
            this.Controls.Add(this.age_txtbox);
            this.Controls.Add(this.nickname_txtbox);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.uid_txtbox);
            this.Controls.Add(this.period_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.nickname_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.uid_label);
            this.Name = "UserRegister";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uid_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label nickname_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label period_label;
        private System.Windows.Forms.TextBox uid_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox nickname_txtbox;
        private System.Windows.Forms.TextBox age_txtbox;
        private System.Windows.Forms.TextBox phone_txtbox;
        private System.Windows.Forms.TextBox period_txtbox;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button goback_button;
    }
}

