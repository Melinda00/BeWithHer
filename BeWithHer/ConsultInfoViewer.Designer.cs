
namespace BeWithHer
{
    partial class ConsultInfoViewer
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
            this.ok_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.flow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.user_remark_txtbox = new System.Windows.Forms.TextBox();
            this.doctor_reply_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.reply_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(271, 354);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(147, 43);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "返回";
            this.ok_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "血色：";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(186, 40);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(15, 15);
            this.color.TabIndex = 2;
            this.color.Text = "3";
            // 
            // flow
            // 
            this.flow.AutoSize = true;
            this.flow.Location = new System.Drawing.Point(326, 40);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(15, 15);
            this.flow.TabIndex = 4;
            this.flow.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "流量：";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(650, 40);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(15, 15);
            this.grade.TabIndex = 6;
            this.grade.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "痛经程度：";
            // 
            // user_remark_txtbox
            // 
            this.user_remark_txtbox.Location = new System.Drawing.Point(284, 96);
            this.user_remark_txtbox.Multiline = true;
            this.user_remark_txtbox.Name = "user_remark_txtbox";
            this.user_remark_txtbox.Size = new System.Drawing.Size(388, 96);
            this.user_remark_txtbox.TabIndex = 7;
            // 
            // doctor_reply_txtbox
            // 
            this.doctor_reply_txtbox.Location = new System.Drawing.Point(284, 229);
            this.doctor_reply_txtbox.Multiline = true;
            this.doctor_reply_txtbox.Name = "doctor_reply_txtbox";
            this.doctor_reply_txtbox.Size = new System.Drawing.Size(388, 96);
            this.doctor_reply_txtbox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "用户描述:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "医生回复:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "状态：";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(474, 40);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(15, 15);
            this.state.TabIndex = 13;
            this.state.Text = "3";
            // 
            // reply_button
            // 
            this.reply_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.reply_button.Enabled = false;
            this.reply_button.Location = new System.Drawing.Point(477, 354);
            this.reply_button.Name = "reply_button";
            this.reply_button.Size = new System.Drawing.Size(147, 43);
            this.reply_button.TabIndex = 15;
            this.reply_button.Text = "回复";
            this.reply_button.UseVisualStyleBackColor = true;
            this.reply_button.Visible = false;
            this.reply_button.Click += new System.EventHandler(this.reply_button_Click);
            // 
            // ConsultInfoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reply_button);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.doctor_reply_txtbox);
            this.Controls.Add(this.user_remark_txtbox);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ok_button);
            this.Name = "ConsultInfoViewer";
            this.Text = "ConsultInfoViewer";
            this.Load += new System.EventHandler(this.ConsultInfoViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label flow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox user_remark_txtbox;
        private System.Windows.Forms.TextBox doctor_reply_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Button reply_button;
    }
}