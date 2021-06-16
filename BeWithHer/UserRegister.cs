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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {

            if(RegisterInfoErrorCheck(uid_txtbox.Text, password_txtbox.Text, nickname_txtbox.Text, 
                age_txtbox.Text, phone_txtbox.Text, period_txtbox.Text))
            {
                return;
            }

            string cmdString = String.Format("insert into UINFO values('{0}', '{1}', '{2}', '{3}', '{4}', {5});",
                    uid_txtbox.Text, password_txtbox.Text, nickname_txtbox.Text, age_txtbox.Text, phone_txtbox.Text, period_txtbox.Text);

            try
            {
                BeWithHerConnector.ExecuteNonQuery(cmdString);
                MessageBox.Show("Register complete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // return true if there exist error (invalid register info)
        private bool RegisterInfoErrorCheck(string uid, string password, string nickname, string age, string phone, string period)
        {

            if (uid_txtbox.Text == "" || password_txtbox.Text == "")
            {
                MessageBox.Show("必须输入用户名和密码");
                return true;
            }

            if (UidExist(uid_txtbox.Text))
            {
                MessageBox.Show("用户名已存在");
                return true;
            }

            int iPeriod = 0;
            try
            {
                iPeriod = Convert.ToInt32(period);
            }
            catch
            {
                MessageBox.Show("输入无效周期");
                return true;
            }

            if(iPeriod <= 0 || iPeriod > 31)
            {
                MessageBox.Show("输入无效周期");
                return true;
            }

            return false;
        }

        private bool UidExist(string uid)
        {
            bool userExist = Convert.ToInt32(BeWithHerConnector.ExecuteQuery(String.Format("select count(U_ID) from UINFO where U_ID = '{0}';", uid))[0][0]) == 1;
            bool doctorExist = Convert.ToInt32(BeWithHerConnector.ExecuteQuery(String.Format("select count(DOC_ID) from DOCTOR where DOC_ID = '{0}';", uid))[0][0]) == 1;
            return userExist || doctorExist;
        }
    }
}
