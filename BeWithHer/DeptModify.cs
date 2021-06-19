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
    public partial class DeptModify : Form
    {
        public DeptModify()
        {
            InitializeComponent();
        }

        public DeptModify(Department department)
        {
            InitializeComponent();
            DeptExist = true;
            id_txtbox.Text = department.ID;
            name_txtbox.Text = department.Name;
            hospital_txtbox.Text = department.Hospital;
            addr_txtbox.Text = department.Address;
            phone_txtbox.Text = department.Phone;
            id_txtbox.ReadOnly = true;
        }


   
        private bool DeptExist = false;

        private bool ValidArgs()
        {
            return true;
        }

        private void verify_button_Click(object sender, EventArgs e)
        {
            if(!ValidArgs())
            {
                MessageBox.Show("参数无效");
                return;
            }

            if(DeptExist)
            {
                string cmd = string.Format("update DEPARTMENT set D_NAME = '{0}', D_HOSPITAL = '{1}', D_ADDR = '{2}', D_PHONE = '{3}' where D_ID = '{4}';", name_txtbox.Text, hospital_txtbox.Text,addr_txtbox.Text, phone_txtbox.Text, id_txtbox.Text);
                BeWithHerConnector.ExecuteNonQuery(cmd);
                //verify_button.DialogResult = DialogResult.OK;
                MessageBox.Show("修改完成");
                this.Hide();
            }
            else
            {
                string cmd = string.Format("insert into DEPARTMENT values('{0}', '{1}', '{2}', '{3}', '{4}');", id_txtbox.Text, name_txtbox.Text, hospital_txtbox.Text, addr_txtbox.Text, phone_txtbox.Text);
                BeWithHerConnector.ExecuteNonQuery(cmd);
                //verify_button.DialogResult = DialogResult.OK;
                MessageBox.Show("新建完成");
                this.Hide();
            }
        }
    }
}
