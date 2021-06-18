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
    public partial class DoctorSelectorBlind : Form
    {
        public DoctorSelectorBlind()
        {
            InitializeComponent();
        }

        private void start_con_button_Click(object sender, EventArgs e)
        {
            if (!RegisterUtils.ValidAge(agefrom_txtbox.Text) || !RegisterUtils.ValidAge(ageto_txtbox.Text))
            {
                MessageBox.Show("无效年龄");
                return;
            }


            string sex = male_button.Checked ? "男" : "女";
            string cmd = String.Format("select * from doctor where DOC_SEX = '{0}' and convert(DOC_AGE, unsigned integer)  > {1} and convert(DOC_AGE, unsigned integer) < {2} limit 10;", 
                sex, agefrom_txtbox.Text, ageto_txtbox.Text);
            List<Credential> doctors = Credential.LoadDoctors(BeWithHerConnector.ExecuteQuery(cmd));
            if(doctors.Count == 0)
            {
                MessageBox.Show("没有满足条件的医生");
                return;
            }
            else
            {
                for(int i = 0; i < doctors.Count; i++)
                {
                    mDoctorButtons[i].Enabled = mDoctorButtons[i].Visible = true;
                    NewConsult newConsult = new NewConsult(doctors[i]);
                    mDoctorButtons[i].Click += (s, ea) => { this.Hide(); newConsult.Show(); };
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Button[] mDoctorButtons = null;

        private void DoctorSelectorBlind_Load(object sender, EventArgs e)
        {
            mDoctorButtons = new Button[] { button0, button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in mDoctorButtons) button.Enabled = button.Visible = false;
        }
    }
}
