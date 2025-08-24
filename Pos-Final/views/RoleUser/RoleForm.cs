using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_Final.Models;


namespace Pos_Final.views.RoleUser
{
    public partial class RoleForm : Form
    {
        public Role role;
       
        public RoleForm()
        {

            InitializeComponent();
            role = new Role();
            role.LoadingDataToDataGridView(dgRoleUser);


        }
        private void RoleForm_Load(object sender, EventArgs e)
        {
            role = new Role();
            role.LoadingDataToDataGridView(dgRoleUser);
        }


        private void txtRoleName_TextChanged(object sender, EventArgs e)
        {

        }
        public static int id = 1;
        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtRoleName) == true) { return; }
            role = new Role();
            role.Id = id;
            role.RoleName = txtRoleName.Text;
            if (rTrue.Checked)
            {
                role.Status = true;
            }
            else
            {
                role.Status = false;
            }

            role.Save();
            MyFunction.ClearTextBox(txtRoleName);
            txtRoleName.Focus();
            role.LoadingDataToDataGridView(dgRoleUser);
        }
        private void dgRoleUser_DoubleClick(object sender, EventArgs e)
        {
           
        }
      

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            role = new Role();
            role.DeleteById(dgRoleUser);
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtRoleName) == true) { return; }
            role = new Role();
            role.Id = id;
            role.RoleName = txtRoleName.Text;
            if (rTrue.Checked)
            {
                role.Status = true;
            }
            else
            {
                role.Status = false;
            }

            role.UpdateById(dgRoleUser);
            MyFunction.ClearTextBox(txtRoleName);
            txtRoleName.Focus();
            role.LoadingDataToDataGridView(dgRoleUser);
        }

        private void txtRoleId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgRoleUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundControlRole_Load(object sender, EventArgs e)
        {

        }

        private void Rolepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRoleSearch_TextChanged(object sender, EventArgs e)
        {
            role = new Role();
            role.RoleName = txtRoleSearch.Text.Trim();
            role.SearchById(dgRoleUser);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void roundControl1_Load(object sender, EventArgs e)
        {

        }

        private void roundControlnputRoleform_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {

        }

        private void roundControlRoleHeader_Load(object sender, EventArgs e)
        {

        }

        private void dgRoleUser_DoubleClick_1(object sender, EventArgs e)
        {
            role = new Role();
            role.TransferDataToControll(dgRoleUser, txtRoleName, rTrue, rFalse);
        }
    }
}
