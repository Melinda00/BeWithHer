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
    public partial class UserMainMenu : Form
    {
        public UserMainMenu()
        {
            InitializeComponent();
        }

        private void new_consult_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = (new ChooseDoctor()).ShowDialog();
            
            switch (dialogResult)
            {
                
                case DialogResult.OK: //select
                    Hide();
                    new DoctorSelector().Show();
                    break;
                case DialogResult.Cancel: //blindly select
                    Hide();
                    new DoctorSelectorBlind().Show();
                    break;
                case DialogResult.Abort:  //last
                    break;
                case DialogResult.Retry:  //random
                    OnRandomSelectDoctor();
                    break;
                case DialogResult.Ignore: //go back
                    break;
                default:
                    break;
            }

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
            Program.CurrentCredential = null;
        }

        private void OnRandomSelectDoctor()
        {
            int doctorCount = Convert.ToInt32(BeWithHerConnector.ExecuteQuery("select count(DOC_ID) from DOCTOR;")[0][0]);
            int index = Program.AppRandom.Next(doctorCount);
            string cmd = String.Format("select * from DOCTOR limit 1 offset {0};", Convert.ToString(index));
            object[] doctorInfo = BeWithHerConnector.ExecuteQuery(cmd)[0];
            Credential doctor = Credential.LoadDoctor(doctorInfo);
  
            DialogResult dialogResult = new DoctorInfoCard(doctor, true).ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                this.Hide();
                new NewConsult(doctor).Show();
            }
            else if(dialogResult == DialogResult.Retry)
            {
                OnRandomSelectDoctor();
            }

        }

        private void change_myinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PasswordChange().Show();
        }

        private void reserve_con_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConsultingReserve().Show();
        }

        private void history_con_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConsultHistory().Show();
        }
    }
}
