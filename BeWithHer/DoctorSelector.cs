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

        public DoctorSelector(List<Credential> doctors)
        {
            InitializeComponent();
            mDoctorCredentials = doctors;
            doctor_info.Columns[6].Visible = false;
        }


        private void DoctorSelector_Load(object sender, EventArgs e)
        {
            if(mDoctorCredentials == null)
            {
                string cmd = "select * from DOCTOR;";
                List<object[]> result = BeWithHerConnector.ExecuteQuery(cmd);
                mDoctorCredentials = Credential.LoadDoctors(result);
            }

            for (int i = 0; i < mDoctorCredentials.Count; i++)
            {
                Credential doctorCredential = mDoctorCredentials[i];

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


        private List<Credential> mDoctorCredentials = null;

        private void goback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserMainMenu().Show();
        }

    }

    
}
