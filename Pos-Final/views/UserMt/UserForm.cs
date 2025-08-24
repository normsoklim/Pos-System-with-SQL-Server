using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Pos_Final.Models;

namespace Pos_Final.views.UserMt
{
    public partial class UserForm : Form
    {

        User user;
        private System.Windows.Forms.DataGridView dgvUserDashboard;
        public UserForm()
        {
            InitializeComponent();

            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            user = new User();
            
            user.LoadingDataToDataGridView(dgAllUser);
            user.SetRoleName(cboRoleName);
        }
      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            user = new User();
            user.DeleteById(dgAllUser);
        }
        private void dgAllUser_DoubleClick(object sender, EventArgs e)
        {
          
        }
        public static int id = 1;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtUserName, txtPassword, txtEmail) == true) { return; }
            user = new User();
            user.Name = txtUserName.Text.Trim();
            user.Gender = cbGender.Text.Trim();
            user.Password = txtPassword.Text.Trim();
            user.Email = txtEmail.Text.Trim();

            if (rTrue.Checked)
            {
                user.Status = true;
            }
            else
            {
                user.Status = false;
            }

            user.RoleId = user.GetRoleId(cboRoleName);
            user.Save();
            MyFunction.ClearTextBox(txtUserName, txtPassword, txtEmail);
            cboRoleName.Text = "";
            txtUserName.Focus();
            user.LoadingDataToDataGridView(dgAllUser); 

        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (MyFunction.IsTextBoxEmpty(txtUserName, txtPassword, txtEmail) == true) { return; }
            user = new User();
            user.Name = txtUserName.Text.Trim();
            user.Gender = cbGender.Text.Trim();
            user.Password = txtPassword.Text.Trim();
            user.Email = txtEmail.Text.Trim();

            if (rTrue.Checked)
            {
                user.Status = true;
            }
            else
            {
                user.Status = false;
            }
            user.RoleId = user.GetRoleId(cboRoleName);
            user.UpdateById(dgAllUser);
            MyFunction.ClearTextBox(txtUserName, txtPassword, txtEmail);
            cboRoleName.Text = "";
            txtUserName.Focus();
            user.LoadingDataToDataGridView(dgAllUser);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            user = new User();
            user.Name = txtSearch.Text.Trim();
            user.SearchById(dgAllUser);
        }

       

        private void dgAllUser_DoubleClick_1(object sender, EventArgs e)
        {
            user = new User();
            user.TransferDataToControls(dgAllUser, txtUserName, cbGender, txtPassword, txtEmail, rTrue, rFalse, cboRoleName);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                user = new User();
                user.Name = txtSearch.Text.Trim();
                user.SearchById(dgAllUser);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        } private void label10_Click(object sender, EventArgs e)
        {

        }
        private void chStatusUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtIdUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAllUser_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgAllUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtAllPss_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchOlduser_Click(object sender, EventArgs e)
        {
           
        }

        private void roundControl2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbRoleName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundControlnputRoleform_Load(object sender, EventArgs e)
        {

        }

        private void dgAllUser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundControl1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboRoleName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundControl4_Load(object sender, EventArgs e)
        {

        }
    }
}
