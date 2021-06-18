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
    }
}
