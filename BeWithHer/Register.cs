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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string cmdString = String.Format("insert into UINFO  values('{0}', '{1}', '{2}', '{3}', '{4}', {5});",
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
    }
}
