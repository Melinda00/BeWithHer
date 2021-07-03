
namespace BeWithHer
{
    partial class DoctorConsultReply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorConsultReply));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reply_button = new System.Windows.Forms.Button();
            this.goback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(700, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // reply_button
            // 
            this.reply_button.Location = new System.Drawing.Point(615, 355);
            this.reply_button.Name = "reply_button";
            this.reply_button.Size = new System.Drawing.Size(123, 42);
            this.reply_button.TabIndex = 1;
            this.reply_button.Text = "提交回复";
            this.reply_button.UseVisualStyleBackColor = true;
            // 
            // goback
            // 
            this.goback.Location = new System.Drawing.Point(447, 355);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(123, 42);
            this.goback.TabIndex = 2;
            this.goback.Text = "返回医生主菜单";
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // DoctorConsultReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.reply_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoctorConsultReply";
            this.Text = "医生回复界面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button reply_button;
        private System.Windows.Forms.Button goback;
    }
}