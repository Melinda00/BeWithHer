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
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserMainMenu().Show();
        }

        private void change_password_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("select count(U_ID) from UINFO where U_ID = '{0}' and U_PASWD = {1};", account.Text, old_password_txtbox.Text);
            if (Convert.ToInt32(BeWithHerConnector.ExecuteQuery(cmd)[0][0]) == 0)
            {
                MessageBox.Show("用户名不存在或旧密码不正确");
                return;
            }

            if (new_password_txtbox.Text.Length > 15)
            {

                MessageBox.Show("密码必须小于15位");
                return;
            }

            if(new_password_txtbox.Text != confirm_password_txtbox.Text)
            {
                MessageBox.Show("两次输入的密码不一致");
                return;
            }


            cmd = string.Format("update UINFO set U_PASWD = '{0}' where U_ID = '{1}';", new_password_txtbox.Text, account.Text);
            BeWithHerConnector.ExecuteNonQuery(cmd);
            MessageBox.Show("修改完成，请重新登录");
            this.Hide();
            new LogIn().Show();
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            account.Text = Program.CurrentCredential.ID;
        }
    }
}
