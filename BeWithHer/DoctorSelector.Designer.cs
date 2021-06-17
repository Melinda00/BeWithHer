
namespace BeWithHer
{
    partial class DoctorSelector
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
            this.start_con_button.Location = new System.Drawing.Point(419, 286);
            this.start_con_button.Name = "start_con_button";
            this.start_con_button.Size = new System.Drawing.Size(75, 23);
            this.start_con_button.TabIndex = 0;
            this.start_con_button.Text = "开始咨询";
            this.start_con_button.UseVisualStyleBackColor = true;
            // 
            // DoctorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.start_con_button);
            this.Name = "DoctorSelector";
            this.Text = "DoctorSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_con_button;
    }
}