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
    public partial class DeptList : Form
    {
        public DeptList()
        {
            InitializeComponent();
        }

        private void goback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DoctorMainMenu().Show();
        }

        private void DeptList_Load(object sender, EventArgs e)
        {
            dept_info.Rows.Clear();

            string cmd = "select * from DEPARTMENT;";
            mDepartments = Department.LoadDepartments(BeWithHerConnector.ExecuteQuery(cmd));

            for (int i = 0; i < mDepartments.Count; i++)
            {
                Department department = mDepartments[i];

                dept_info.Rows.Add();
                dept_info.Rows[dept_info.Rows.Count - 1].Cells["d_id"].Value = department.ID;
                dept_info.Rows[dept_info.Rows.Count - 1].Cells["d_name"].Value = department.Name;
                dept_info.Rows[dept_info.Rows.Count - 1].Cells["d_hospital"].Value = department.Hospital;
                dept_info.Rows[dept_info.Rows.Count - 1].Cells["d_addr"].Value = department.Address;
                dept_info.Rows[dept_info.Rows.Count - 1].Cells["d_phone"].Value = department.Phone;
                dept_info.Rows[dept_info.Rows.Count - 1].Cells["modify"].Value = "修改";
            }

        }

        private void new_dept_button_Click(object sender, EventArgs e)
        {
            DialogResult result = new DeptModify().ShowDialog();
            DeptList_Load(null, null);
            //if (result == DialogResult.OK) DeptList_Load(null, null);
        }

        List<Department> mDepartments = null;

        private void dept_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "modify" && e.RowIndex >= 0)
            {
                DialogResult result = new DeptModify(mDepartments[e.RowIndex]).ShowDialog();
                DeptList_Load(null, null);
                //if (result == DialogResult.OK) DeptList_Load(null, null);
            }


        }
    }
}
