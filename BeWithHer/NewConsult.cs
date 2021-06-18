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
    public partial class NewConsult : Form
    {
        public NewConsult(Credential doctorCredential)
        {
            InitializeComponent();
            consult_date.Text = DateTime.Today.ToString("yyyy/MM/dd");
            mSelectedDoctor = doctorCredential;
            selected_doctor_label.Text = mSelectedDoctor.Name;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string cmd = String.Format("insert into CONINFO values('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}, {7}, '{8}');", 
                GenerateBarCode(), Program.CurrentCredential.ID, mSelectedDoctor.ID, consult_date.Text, GetColor(), GetFlow(), GetState(), GetGrade(), rmk_txtbox.Text);
            BeWithHerConnector.ExecuteNonQuery(cmd);
            MessageBox.Show("提交咨询完成");
            this.Hide();
            new UserMainMenu().Show();
        }


        private string GenerateBarCode()
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string result = "";
            for(int i = 0; i < 8; i++)
            {
                result += chars[new Random().Next(0, chars.Length)];
            }
            if (!BarCodeExist(result)) return result;
            else return GenerateBarCode();
        }

        private bool BarCodeExist(string barCode)
        {
            return Convert.ToInt32(BeWithHerConnector.ExecuteQuery(String.Format("select count(BARCODE_ID) from CONINFO where BARCODE_ID = '{0}';", barCode))[0][0]) == 1;
        }

        private string GetColor()
        {
            if (color1.Checked) return "1";
            else if (color2.Checked) return "2";
            else if (color3.Checked) return "3";
            else if (color4.Checked) return "4";
            else if (color5.Checked) return "5";
            else return "";
        }

        private string GetFlow()
        {
            if (flow1.Checked) return "1";
            else if (flow2.Checked) return "2";
            else if (flow3.Checked) return "3";
            else if (flow4.Checked) return "4";
            else if (flow5.Checked) return "5";
            else return "";
        }

        private string GetState()
        {
            if (state1.Checked) return "1";
            else if (state2.Checked) return "2";
            else if (state3.Checked) return "3";
            else if (state4.Checked) return "4";
            else if (state5.Checked) return "5";
            else return "";
        }

        private string GetGrade()
        {
            if (grade1.Checked) return "1";
            else if (grade2.Checked) return "2";
            else if (grade3.Checked) return "3";
            else if (grade4.Checked) return "4";
            else if (grade5.Checked) return "5";
            else return "";
        }

        private Credential mSelectedDoctor = null;
    }
}
