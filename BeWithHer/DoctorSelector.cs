using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeWithHer
{
    public partial class DoctorSelector : Form
    {
        public DoctorSelector()
        {
            InitializeComponent();
        }

        private void start_con_button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new NewConsult().Show();
        }

        private void DoctorSelector_Load(object sender, EventArgs e)
        {
            
            string cmd = "select DOC_ID, DOC_NAME, DOC_SEX, DOC_AGE, DOC_DEPT, DOC_PHONE, DOC_CTER, DOC_REMARK from DOCTOR;";
            List<object[]> result = BeWithHerConnector.ExecuteQuery(cmd);
            
            for (int i = 0; i < result.Count; i++)
            {
                Credential doctorCredential = new Credential();
                doctorCredential.ID = Convert.ToString(result[i][0]);
                doctorCredential.Name = Convert.ToString(result[i][1]);
                doctorCredential.Sex = Convert.ToString(result[i][2]);
                doctorCredential.Age = Convert.ToString(result[i][3]);
                doctorCredential.Department = Convert.ToString(result[i][4]);
                doctorCredential.Phone = Convert.ToString(result[i][5]);
                doctorCredential.Adm = Convert.ToString(result[i][6]) == "T";
                doctorCredential.Remark = Convert.ToString(result[i][7]);
                mDoctorCredentials.Add(doctorCredential);

                doctor_info.Rows.Add();
                doctor_info.Rows[doctor_info.Rows.Count - 1].Cells["id"].Value = doctorCredential.ID;
                doctor_info.Rows[doctor_info.Rows.Count - 1].Cells["name"].Value = doctorCredential.Name;
                doctor_info.Rows[doctor_info.Rows.Count - 1].Cells["sex"].Value = doctorCredential.Sex;
                doctor_info.Rows[doctor_info.Rows.Count - 1].Cells["age"].Value = doctorCredential.Age;
                doctor_info.Rows[doctor_info.Rows.Count - 1].Cells["dept"].Value = doctorCredential.Department;
                doctor_info.Rows[doctor_info.Rows.Count - 1].Cells["select"].Value = "选择";
                doctor_info.Rows[doctor_info.Rows.Count - 1].Cells["detail"].Value = "详情";
            }

        }

        private void doctor_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "detail" && e.RowIndex >= 0)
            {
                new DoctorInfoCard(mDoctorCredentials[e.RowIndex]).ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "select" && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("确定选择医生 " + senderGrid.Rows[e.RowIndex].Cells["name"].Value + " 吗？",
                    "确认", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Hide();
                    new NewConsult(mDoctorCredentials[e.RowIndex]).Show();
                }
            }

        }


        private List<Credential> mDoctorCredentials = new List<Credential>();
    }

    
}
