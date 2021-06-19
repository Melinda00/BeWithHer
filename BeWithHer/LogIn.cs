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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(uid_txtbox.Text == "" || password_txtbox.Text == "")
            {
                MessageBox.Show("账号和密码不能为空");
                return;
            }

            string userCmd = String.Format("select count(U_ID) from UINFO where U_ID = '{0}' and U_PASWD = '{1}';", uid_txtbox.Text, password_txtbox.Text);
            string doctorCmd = String.Format("select count(DOC_ID) from DOCTOR where DOC_ID = '{0}' and DOC_PASWD = '{1}';", uid_txtbox.Text, password_txtbox.Text);
            List<object[]> userResult = BeWithHerConnector.ExecuteQuery(userCmd);
            List<object[]> doctorResult = BeWithHerConnector.ExecuteQuery(doctorCmd);
            if (Convert.ToInt32(userResult[0][0]) == 1)
            {
                this.Hide();
                new UserMainMenu().Show();
                Program.CurrentCredential = new Credential() { ID = uid_txtbox.Text, IsUser = true };
            }
            else if(Convert.ToInt32(doctorResult[0][0]) == 1)
            {
                string cmd = string.Format("select DOC_CTER from DOCTOR where DOC_ID = '{0}';", uid_txtbox.Text);
                bool adm = Convert.ToString(BeWithHerConnector.ExecuteQuery(cmd)[0][0]) == "T";
                this.Hide();
                new DoctorMainMenu().Show();
                Program.CurrentCredential = new Credential() { ID = uid_txtbox.Text, IsUser = false, Adm = adm };
            }
            else
            {
                MessageBox.Show("用户名不存在或密码不正确");
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = (new RegisterSelector()).ShowDialog();
            if(dialogResult == DialogResult.Yes)
            {
                this.Hide();
                new UserRegister().Show();
            }
            else if(dialogResult == DialogResult.No)
            {
                this.Hide();
                new DoctorRegister().Show();
            }


        }
    }
}
