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
    public partial class DoctorInfoCard : Form
    {
        public DoctorInfoCard(Credential doctorCredential)
        {
            InitializeComponent();
            mDoctorCredential = doctorCredential;
        }

        private void DoctorInfoCard_Load(object sender, EventArgs e)
        {
            name_label.Text = mDoctorCredential.Name;
            age_label.Text = mDoctorCredential.Age;
            sex_label.Text = mDoctorCredential.Sex;
            dept_label.Text = mDoctorCredential.Department;
            phone_label.Text = mDoctorCredential.Phone;
            adm_label.Text = mDoctorCredential.Adm ? "是" : "否";
            intro_label.Text = mDoctorCredential.Remark;
        }

        Credential mDoctorCredential = null;
    }
}
