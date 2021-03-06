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
    public partial class ConsultHistory : Form
    {


        public ConsultHistory()
        {
            InitializeComponent();
        }

        private void ConsultHistory_Load(object sender, EventArgs e)
        {
            string cmd = "";
            if(Program.CurrentCredential.IsUser)
            {
                cmd = string.Format("select * from CONINFO where U_ID = '{0}';", Program.CurrentCredential.ID);
          
            }
            else
            {
                cmd = string.Format("select * from CONINFO where DOC_ID = '{0}';", Program.CurrentCredential.ID);
                consult_history.Columns[1].HeaderText = "用户";
            }

            
           
            mConsultInfos = ConsultInfo.LoadConsultInfos(BeWithHerConnector.ExecuteQuery(cmd));
            for (int i = 0; i < mConsultInfos.Count; i++)
            {
                ConsultInfo consultInfo = mConsultInfos[i];

                consult_history.Rows.Add();
                consult_history.Rows[consult_history.Rows.Count - 1].Cells["date"].Value = consultInfo.Date;
                if(Program.CurrentCredential.IsUser)
                {
                    consult_history.Rows[consult_history.Rows.Count - 1].Cells["doctor"].Value = Convert.ToString(BeWithHerConnector.ExecuteQuery(string.Format("select DOC_NAME from DOCTOR where DOC_ID = '{0}';", consultInfo.DoctorID))[0][0]);
                    consult_history.Rows[consult_history.Rows.Count - 1].Cells["state"].Value = consultInfo.DoctorReply != "" ? "医生已回复" : "医生未回复";
                }
                   
                else
                {
                    consult_history.Rows[consult_history.Rows.Count - 1].Cells["doctor"].Value = Convert.ToString(BeWithHerConnector.ExecuteQuery(string.Format("select U_NAME from UINFO where U_ID = '{0}';", consultInfo.UserID))[0][0]);
                    consult_history.Rows[consult_history.Rows.Count - 1].Cells["state"].Value = consultInfo.DoctorReply != "" ? "已回复" : "未回复";
                }
                consult_history.Rows[consult_history.Rows.Count - 1].Cells["detail"].Value = "查看详情";


            }

        }

        private List<ConsultInfo> mConsultInfos = null;


        private void consult_history_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "detail" && e.RowIndex >= 0)
            {
                new ConsultInfoViewer(mConsultInfos[e.RowIndex]).ShowDialog();
            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserMainMenu().Show();
        }
    }
}
