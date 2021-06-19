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
    public partial class DoctorMainMenu : Form
    {
        public DoctorMainMenu()
        {
            InitializeComponent();
        }



        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.CurrentCredential = null;
            new LogIn().Show();
        }

        private void change_password_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PasswordChange().Show();
        }


        private void reserve_con_Click(object sender, EventArgs e)
        {

        }

        private void unreplied_consult_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConsultHistory().Show();
        }
    }
}
