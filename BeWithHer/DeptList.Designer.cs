
namespace BeWithHer
{
    partial class DeptList
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
            this.doctor_info = new System.Windows.Forms.DataGridView();
            this.D_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.goback = new System.Windows.Forms.Button();
            this.new_dept_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_info)).BeginInit();
            this.SuspendLayout();
            // 
            // doctor_info
            // 
            this.doctor_info.AllowUserToAddRows = false;
            this.doctor_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctor_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctor_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D_ID,
            this.d_name,
            this.d_hospital,
            this.d_addr,
            this.d_phone,
            this.modify});
            this.doctor_info.Location = new System.Drawing.Point(12, 1);
            this.doctor_info.Name = "doctor_info";
            this.doctor_info.RowHeadersWidth = 51;
            this.doctor_info.RowTemplate.Height = 27;
            this.doctor_info.Size = new System.Drawing.Size(899, 283);
            this.doctor_info.TabIndex = 2;
            // 
            // D_ID
            // 
            this.D_ID.HeaderText = "科室号";
            this.D_ID.MinimumWidth = 6;
            this.D_ID.Name = "D_ID";
            // 
            // d_name
            // 
            this.d_name.HeaderText = "科室名";
            this.d_name.MinimumWidth = 6;
            this.d_name.Name = "d_name";
            // 
            // d_hospital
            // 
            this.d_hospital.HeaderText = "科室所在医院名";
            this.d_hospital.MinimumWidth = 6;
            this.d_hospital.Name = "d_hospital";
            // 
            // d_addr
            // 
            this.d_addr.HeaderText = "科室地址";
            this.d_addr.MinimumWidth = 6;
            this.d_addr.Name = "d_addr";
            // 
            // d_phone
            // 
            this.d_phone.HeaderText = "科室电话";
            this.d_phone.MinimumWidth = 6;
            this.d_phone.Name = "d_phone";
            // 
            // modify
            // 
            this.modify.HeaderText = "修改";
            this.modify.MinimumWidth = 6;
            this.modify.Name = "modify";
            // 
            // goback
            // 
            this.goback.Location = new System.Drawing.Point(755, 343);
            this.goback.Name = "goback";
            this.goback.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.goback.Size = new System.Drawing.Size(147, 43);
            this.goback.TabIndex = 3;
            this.goback.Text = "返回主界面";
            this.goback.UseVisualStyleBackColor = true;
            // 
            // new_dept_button
            // 
            this.new_dept_button.Location = new System.Drawing.Point(558, 343);
            this.new_dept_button.Name = "new_dept_button";
            this.new_dept_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.new_dept_button.Size = new System.Drawing.Size(147, 43);
            this.new_dept_button.TabIndex = 4;
            this.new_dept_button.Text = "新建科室信息";
            this.new_dept_button.UseVisualStyleBackColor = true;
            // 
            // DeptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.new_dept_button);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.doctor_info);
            this.Name = "DeptList";
            this.Text = "DeptList";
            ((System.ComponentModel.ISupportInitialize)(this.doctor_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView doctor_info;
        private System.Windows.Forms.Button goback;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_phone;
        private System.Windows.Forms.DataGridViewButtonColumn modify;
        private System.Windows.Forms.Button new_dept_button;
    }
}