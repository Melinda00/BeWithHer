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
    public partial class ConsultInfoViewer : Form
    {
        public ConsultInfoViewer(ConsultInfo consultInfo)
        {
            InitializeComponent();
            mConsultInfo = consultInfo;
        }



        private ConsultInfo mConsultInfo = null;
   

        private void ConsultInfoViewer_Load(object sender, EventArgs e)
        {
            color.Text = Convert.ToString(mConsultInfo.Color);
            flow.Text = Convert.ToString(mConsultInfo.Flow);
            state.Text = Convert.ToString(mConsultInfo.State);
            grade.Text = Convert.ToString(mConsultInfo.Grade);
            user_remark_txtbox.Text = mConsultInfo.UserRemark;
            user_remark_txtbox.ReadOnly = true;
            doctor_reply_txtbox.Text = mConsultInfo.DoctorReply;
            doctor_reply_txtbox.ReadOnly = Program.CurrentCredential.IsUser;
            reply_button.Enabled = reply_button.Visible = !Program.CurrentCredential.IsUser;

        }

        private void reply_button_Click(object sender, EventArgs e)
        {
            string rmk = user_remark_txtbox.Text + "@" + doctor_reply_txtbox.Text;
            string cmd = string.Format("update CONINFO set CON_REMARK = '{0}' where BARCODE_ID = '{1}';", rmk, mConsultInfo.BarCode);
            try
            {
                BeWithHerConnector.ExecuteNonQuery(cmd);
                MessageBox.Show("回复完成");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
