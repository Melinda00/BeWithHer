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
        public RegisterSelector(Form logInForm)
        {
            InitializeComponent();
            mLogInForm = logInForm;
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            Program.SwitchForm<UserRegister>(new Form[] { this, mLogInForm });
        }

        private void doctor_button_Click(object sender, EventArgs e)
        {
            Program.SwitchForm<DoctorRegister>(new Form[] { this, mLogInForm });
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form mLogInForm = null;
    }
}
