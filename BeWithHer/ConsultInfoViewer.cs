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
            doctor_reply_txtbox.ReadOnly = true;

        }
    }
}
