
namespace BeWithHer
{
    partial class ConsultHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultHistory));
            this.consult_history = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.goback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consult_history)).BeginInit();
            this.SuspendLayout();
            // 
            // consult_history
            // 
            this.consult_history.AllowUserToAddRows = false;
            this.consult_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consult_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consult_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.doctor,
            this.state,
            this.detail});
            this.consult_history.Location = new System.Drawing.Point(-1, 1);
            this.consult_history.Name = "consult_history";
            this.consult_history.RowHeadersWidth = 51;
            this.consult_history.RowTemplate.Height = 27;
            this.consult_history.Size = new System.Drawing.Size(800, 304);
            this.consult_history.TabIndex = 2;
            this.consult_history.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consult_history_CellContentClick);
            // 
            // date
            // 
            this.date.HeaderText = "咨询日期";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // doctor
            // 
            this.doctor.HeaderText = "医生";
            this.doctor.MinimumWidth = 6;
            this.doctor.Name = "doctor";
            // 
            // state
            // 
            this.state.HeaderText = "状态";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            // 
            // detail
            // 
            this.detail.HeaderText = "";
            this.detail.MinimumWidth = 6;
            this.detail.Name = "detail";
            this.detail.Text = "";
            // 
            // goback
            // 
            this.goback.Location = new System.Drawing.Point(680, 360);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(108, 41);
            this.goback.TabIndex = 3;
            this.goback.Text = "返回主菜单";
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // ConsultHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.consult_history);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultHistory";
            this.Text = "咨询历史";
            this.Load += new System.EventHandler(this.ConsultHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consult_history)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView consult_history;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.Button goback;
    }
}