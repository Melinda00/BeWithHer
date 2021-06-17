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
            string userCmd = String.Format("select count(U_ID) from UINFO where U_ID = '{0}' and U_PASWD = '{1}';", uid_txtbox.Text, password_txtbox.Text);
            string doctorCmd = String.Format("select count(DOC_ID) from DOCTOR where DOC_ID = '{0}' and DOC_PASWD = '{1}';", uid_txtbox.Text, password_txtbox.Text);
            List<object[]> userResult = BeWithHerConnector.ExecuteQuery(userCmd);
            List<object[]> doctorResult = BeWithHerConnector.ExecuteQuery(doctorCmd);
            if (Convert.ToInt32(userResult[0][0]) == 1)
            {
                Program.SwitchForm<UserMainMenu>(this);
            }
            else if(Convert.ToInt32(doctorResult[0][0]) == 1)
            {
                Program.SwitchForm<DoctorMainMenu>(this);
            }
            else
            {
                MessageBox.Show("用户名不存在或密码不正确");
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            //Program.SwitchForm<RegisterSelector>(this);
            Program.CreateFormDialog<RegisterSelector>(this);
        }
    }
}
