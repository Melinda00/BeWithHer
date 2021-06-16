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
    public partial class DoctorRegister : Form
    {
        public DoctorRegister()
        {
            InitializeComponent();
        }


        private void register_button_Click(object sender, EventArgs e)
        {
            if (!ValidRegisterArgs()) return;

            string sex = "男";
            if (female_button.Checked) sex = "女";
            string adm = "F";
            if (adm_checkbox.Checked) adm = "T";
            string dept = department_combobox.Items[department_combobox.SelectedIndex].ToString();

            string cmd = String.Format("insert into DOCTOR values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                uid_txtbox.Text, password_txtbox.Text, name_txtbox.Text, sex, 
                dept, phone_txtbox.Text, remark_txtbox.Text, adm);

            try
            {
                BeWithHerConnector.ExecuteNonQuery(cmd);
                MessageBox.Show("注册成功");
                Program.SwitchForm<LogIn>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void goback_button_Click(object sender, EventArgs e)
        {
            Program.SwitchForm<LogIn>(this);
        }

        private bool ValidRegisterArgs()
        {
            if (uid_txtbox.Text == "" || password_txtbox.Text == "")
            {
                MessageBox.Show("账号和密码不能为空");
                return false;
            }

            if (RegisterUtils.UidExist(uid_txtbox.Text))
            {
                MessageBox.Show("账号已存在");
                return false;
            }

            if (uid_txtbox.TextLength > 12)
            {
                MessageBox.Show("账号必须在12位以下");
                return false;
            }

            if (password_txtbox.TextLength > 15)
            {
                MessageBox.Show("密码必须在15位以下");
                return false;
            }

            if (name_txtbox.TextLength > 15)
            {
                MessageBox.Show("昵称必须在20位以下");
                return false;
            }

            if (!male_button.Checked && !female_button.Checked)
            {
                MessageBox.Show("性别不能为空");
                return false;
            }

            if (department_combobox.Items[department_combobox.SelectedIndex].ToString() == "")
            {
                MessageBox.Show("科室不能为空");
                return false;
            }

            if (!RegisterUtils.ValidPhoneNum(phone_txtbox.Text))
            {
                MessageBox.Show("无效电话号码");
                return false;
            }

            if (remark_txtbox.TextLength > 100)
            {
                MessageBox.Show("备注必须在100位以下");
                return false;
            }

            return true;
        }



    }



}
