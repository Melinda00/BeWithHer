
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorSelector));
            this.doctor_info = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.goback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_info)).BeginInit();
            this.SuspendLayout();
            // 
            // doctor_info
            // 
            this.doctor_info.AllowUserToAddRows = false;
            this.doctor_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctor_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctor_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.sex,
            this.age,
            this.dept,
            this.detail,
            this.select});
            this.doctor_info.Location = new System.Drawing.Point(-4, 0);
            this.doctor_info.Name = "doctor_info";
            this.doctor_info.RowHeadersWidth = 51;
            this.doctor_info.RowTemplate.Height = 27;
            this.doctor_info.Size = new System.Drawing.Size(803, 305);
            this.doctor_info.TabIndex = 1;
            this.doctor_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctor_info_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "姓名";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // sex
            // 
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            // 
            // age
            // 
            this.age.HeaderText = "年龄";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            // 
            // dept
            // 
            this.dept.HeaderText = "科室";
            this.dept.MinimumWidth = 6;
            this.dept.Name = "dept";
            // 
            // detail
            // 
            this.detail.HeaderText = "";
            this.detail.MinimumWidth = 6;
            this.detail.Name = "detail";
            this.detail.Text = "";
            // 
            // select
            // 
            this.select.HeaderText = "";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            this.select.Text = "";
            // 
            // goback
            // 
            this.goback.Location = new System.Drawing.Point(619, 364);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(123, 42);
            this.goback.TabIndex = 2;
            this.goback.Text = "返回主菜单";
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // DoctorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.doctor_info);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorSelector";
            this.Text = "选择您的咨询医生";
            this.Load += new System.EventHandler(this.DoctorSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctor_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView doctor_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewButtonColumn select;
        private System.Windows.Forms.Button goback;
    }
}