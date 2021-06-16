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
    public partial class RegisterSelector : Form
    {
        public RegisterSelector()
        {
            InitializeComponent();
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            Program.SwitchForm<UserRegister>(this);
        }

        private void doctor_button_Click(object sender, EventArgs e)
        {
            Program.SwitchForm<DoctorRegister>(this);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Program.SwitchForm<LogIn>(this);
        }
    }
}
