
namespace BeWithHer
{
    partial class RegisterSelector
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
            this.user_button = new System.Windows.Forms.Button();
            this.doctor_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.selector_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_button
            // 
            this.user_button.Location = new System.Drawing.Point(29, 143);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(80, 32);
            this.user_button.TabIndex = 0;
            this.user_button.Text = "用户";
            this.user_button.UseVisualStyleBackColor = true;
            this.user_button.Click += new System.EventHandler(this.user_button_Click);
            // 
            // doctor_button
            // 
            this.doctor_button.Location = new System.Drawing.Point(166, 143);
            this.doctor_button.Name = "doctor_button";
            this.doctor_button.Size = new System.Drawing.Size(81, 32);
            this.doctor_button.TabIndex = 1;
            this.doctor_button.Text = "医生";
            this.doctor_button.UseVisualStyleBackColor = true;
            this.doctor_button.Click += new System.EventHandler(this.doctor_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(301, 143);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(83, 32);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "返回";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // selector_label
            // 
            this.selector_label.AutoSize = true;
            this.selector_label.Location = new System.Drawing.Point(136, 69);
            this.selector_label.Name = "selector_label";
            this.selector_label.Size = new System.Drawing.Size(127, 15);
            this.selector_label.TabIndex = 3;
            this.selector_label.Text = "注册用户还是医生";
            // 
            // RegisterSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 256);
            this.Controls.Add(this.selector_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.doctor_button);
            this.Controls.Add(this.user_button);
            this.Name = "RegisterSelector";
            this.Text = "RegisterSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Button doctor_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label selector_label;
    }
}