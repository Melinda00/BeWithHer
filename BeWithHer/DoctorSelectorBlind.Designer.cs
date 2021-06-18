
namespace BeWithHer
{
    partial class DoctorSelectorBlind
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
            this.start_con_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_con_button
            // 
            this.start_con_button.Location = new System.Drawing.Point(583, 352);
            this.start_con_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_con_button.Name = "start_con_button";
            this.start_con_button.Size = new System.Drawing.Size(100, 29);
            this.start_con_button.TabIndex = 1;
            this.start_con_button.Text = "开始咨询";
            this.start_con_button.UseVisualStyleBackColor = true;
            this.start_con_button.Click += new System.EventHandler(this.start_con_button_Click);
            // 
            // DoctorSelectorBlind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start_con_button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoctorSelectorBlind";
            this.Text = "DoctorSelectorBlind";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_con_button;
    }
}