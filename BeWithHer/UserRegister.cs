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

            if (!ValidRegisterArgs()) return;

            string cmdString = String.Format("insert into UINFO values('{0}', '{1}', '{2}', '{3}', '{4}', {5});",
                    uid_txtbox.Text, password_txtbox.Text, nickname_txtbox.Text, age_txtbox.Text, phone_txtbox.Text, period_txtbox.Text);

            try
            {
                BeWithHerConnector.ExecuteNonQuery(cmdString);
                MessageBox.Show("注册成功");
                Program.SwitchForm<LogIn>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // return true if there exist error (invalid register info)
        private bool ValidRegisterArgs()
        {

            if (uid_txtbox.Text == "" || password_txtbox.Text == "")
            {
                MessageBox.Show("必须输入用户名和密码");
                return false;
            }

            if (RegisterUtils.UidExist(uid_txtbox.Text))
            {
                MessageBox.Show("账号已存在");
                return false;
            }

            if (uid_txtbox.TextLength > 18)
            {
                MessageBox.Show("账号必须小于18位");
                return false;
            }

            if(password_txtbox.TextLength > 15)
            {
                MessageBox.Show("密码必须小于15位");
                return false;
            }

            if(nickname_txtbox.TextLength > 20)
            {
                MessageBox.Show("昵称必须小于20位");
                return false;
            }

            if (!RegisterUtils.ValidPhoneNum(phone_txtbox.Text))
            {
                MessageBox.Show("无效电话号码");
                return false;
            }

            if(!RegisterUtils.ValidAge(age_txtbox.Text))
            {
                MessageBox.Show("无效年龄");
                return false;
            }

            if(!RegisterUtils.ValidPeriod(period_txtbox.Text))
            {
                MessageBox.Show("无效周期");
                return false;
            }

            return true;
        }


        private void goback_button_Click(object sender, EventArgs e)
        {
            Program.SwitchForm<LogIn>(this);
        }
    }
}
