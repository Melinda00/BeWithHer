
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
            this.dept_info = new System.Windows.Forms.DataGridView();
            this.goback = new System.Windows.Forms.Button();
            this.new_dept_button = new System.Windows.Forms.Button();
            this.d_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dept_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dept_info
            // 
            this.dept_info.AllowUserToAddRows = false;
            this.dept_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dept_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dept_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d_id,
            this.d_name,
            this.d_hospital,
            this.d_addr,
            this.d_phone,
            this.modify});
            this.dept_info.Location = new System.Drawing.Point(12, 1);
            this.dept_info.Name = "dept_info";
            this.dept_info.RowHeadersWidth = 51;
            this.dept_info.RowTemplate.Height = 27;
            this.dept_info.Size = new System.Drawing.Size(899, 283);
            this.dept_info.TabIndex = 2;
            this.dept_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dept_info_CellContentClick);
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
            this.goback.Click += new System.EventHandler(this.goback_Click);
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
            this.new_dept_button.Click += new System.EventHandler(this.new_dept_button_Click);
            // 
            // d_id
            // 
            this.d_id.HeaderText = "科室号";
            this.d_id.MinimumWidth = 6;
            this.d_id.Name = "d_id";
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
            // DeptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.new_dept_button);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.dept_info);
            this.Name = "DeptList";
            this.Text = "DeptList";
            this.Load += new System.EventHandler(this.DeptList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dept_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dept_info;
        private System.Windows.Forms.Button goback;
        private System.Windows.Forms.Button new_dept_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_phone;
        private System.Windows.Forms.DataGridViewButtonColumn modify;
    }
}