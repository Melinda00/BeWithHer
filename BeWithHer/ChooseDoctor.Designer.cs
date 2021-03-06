
namespace BeWithHer
{
    partial class ChooseDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseDoctor));
            this.goback_button = new System.Windows.Forms.Button();
            this.view_doctor_button = new System.Windows.Forms.Button();
            this.doctor_table_button = new System.Windows.Forms.Button();
            this.last_doctor_button = new System.Windows.Forms.Button();
            this.doctor_table_label = new System.Windows.Forms.Label();
            this.last_doctor_label = new System.Windows.Forms.Label();
            this.view_doctor_label = new System.Windows.Forms.Label();
            this.random_doctor_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goback_button
            // 
            this.goback_button.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.goback_button.Location = new System.Drawing.Point(441, 226);
            this.goback_button.Margin = new System.Windows.Forms.Padding(4);
            this.goback_button.Name = "goback_button";
            this.goback_button.Size = new System.Drawing.Size(100, 29);
            this.goback_button.TabIndex = 0;
            this.goback_button.Text = "取消";
            this.goback_button.UseVisualStyleBackColor = true;
            // 
            // view_doctor_button
            // 
            this.view_doctor_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.view_doctor_button.Location = new System.Drawing.Point(317, 34);
            this.view_doctor_button.Margin = new System.Windows.Forms.Padding(4);
            this.view_doctor_button.Name = "view_doctor_button";
            this.view_doctor_button.Size = new System.Drawing.Size(179, 33);
            this.view_doctor_button.TabIndex = 1;
            this.view_doctor_button.Text = "开始筛选";
            this.view_doctor_button.UseVisualStyleBackColor = true;
            // 
            // doctor_table_button
            // 
            this.doctor_table_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.doctor_table_button.Location = new System.Drawing.Point(317, 75);
            this.doctor_table_button.Margin = new System.Windows.Forms.Padding(4);
            this.doctor_table_button.Name = "doctor_table_button";
            this.doctor_table_button.Size = new System.Drawing.Size(179, 34);
            this.doctor_table_button.TabIndex = 2;
            this.doctor_table_button.Text = "开始盲选";
            this.doctor_table_button.UseVisualStyleBackColor = true;
            // 
            // last_doctor_button
            // 
            this.last_doctor_button.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.last_doctor_button.Location = new System.Drawing.Point(317, 117);
            this.last_doctor_button.Margin = new System.Windows.Forms.Padding(4);
            this.last_doctor_button.Name = "last_doctor_button";
            this.last_doctor_button.Size = new System.Drawing.Size(179, 29);
            this.last_doctor_button.TabIndex = 3;
            this.last_doctor_button.Text = "跟上次一样";
            this.last_doctor_button.UseVisualStyleBackColor = true;
            // 
            // doctor_table_label
            // 
            this.doctor_table_label.AutoSize = true;
            this.doctor_table_label.BackColor = System.Drawing.Color.Transparent;
            this.doctor_table_label.Font = new System.Drawing.Font("方正清刻本悦宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_table_label.Location = new System.Drawing.Point(37, 79);
            this.doctor_table_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doctor_table_label.Name = "doctor_table_label";
            this.doctor_table_label.Size = new System.Drawing.Size(250, 22);
            this.doctor_table_label.TabIndex = 4;
            this.doctor_table_label.Text = "盲选符合筛选条件的医生：";
            // 
            // last_doctor_label
            // 
            this.last_doctor_label.AutoSize = true;
            this.last_doctor_label.BackColor = System.Drawing.Color.Transparent;
            this.last_doctor_label.Font = new System.Drawing.Font("方正清刻本悦宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_doctor_label.Location = new System.Drawing.Point(37, 117);
            this.last_doctor_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.last_doctor_label.Name = "last_doctor_label";
            this.last_doctor_label.Size = new System.Drawing.Size(210, 22);
            this.last_doctor_label.TabIndex = 5;
            this.last_doctor_label.Text = "选择上次咨询的医生：";
            // 
            // view_doctor_label
            // 
            this.view_doctor_label.AutoSize = true;
            this.view_doctor_label.BackColor = System.Drawing.Color.Transparent;
            this.view_doctor_label.Font = new System.Drawing.Font("方正清刻本悦宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_doctor_label.Location = new System.Drawing.Point(37, 42);
            this.view_doctor_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.view_doctor_label.Name = "view_doctor_label";
            this.view_doctor_label.Size = new System.Drawing.Size(250, 22);
            this.view_doctor_label.TabIndex = 6;
            this.view_doctor_label.Text = "根据您的要求筛选的医生：";
            // 
            // random_doctor_button
            // 
            this.random_doctor_button.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.random_doctor_button.Location = new System.Drawing.Point(317, 154);
            this.random_doctor_button.Margin = new System.Windows.Forms.Padding(4);
            this.random_doctor_button.Name = "random_doctor_button";
            this.random_doctor_button.Size = new System.Drawing.Size(179, 31);
            this.random_doctor_button.TabIndex = 7;
            this.random_doctor_button.Text = "随机匹配";
            this.random_doctor_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正清刻本悦宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "系统随机选择的医生：";
            // 
            // ChooseDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.random_doctor_button);
            this.Controls.Add(this.view_doctor_label);
            this.Controls.Add(this.last_doctor_label);
            this.Controls.Add(this.doctor_table_label);
            this.Controls.Add(this.last_doctor_button);
            this.Controls.Add(this.doctor_table_button);
            this.Controls.Add(this.view_doctor_button);
            this.Controls.Add(this.goback_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChooseDoctor";
            this.Text = "选择您的医生";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goback_button;
        private System.Windows.Forms.Button view_doctor_button;
        private System.Windows.Forms.Button doctor_table_button;
        private System.Windows.Forms.Button last_doctor_button;
        private System.Windows.Forms.Label doctor_table_label;
        private System.Windows.Forms.Label last_doctor_label;
        private System.Windows.Forms.Label view_doctor_label;
        private System.Windows.Forms.Button random_doctor_button;
        private System.Windows.Forms.Label label1;
    }
}