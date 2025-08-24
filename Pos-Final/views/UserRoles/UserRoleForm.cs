using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_Final.Models;
using Pos_Final.views.RoleUser;
using Pos_Final.views.UserMt;


namespace Pos_Final.views.UserRoles
{
    public partial class UserRoleForm : Form
    {
        
        UserRole userrole;
        
        public UserRoleForm()
        {
            InitializeComponent();

        }

        public bool tooStripButton { get; internal set; }
        public object Mainpanel { get; private set; }
   
        private void UserRole_Load(object sender, EventArgs e)
        {
            userrole = new UserRole();
            userrole.SetUserName(cboUser);
            userrole.SetRoleName(cboRole);
            userrole.LoadingDataToDataGridView(dgUserRole);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchUserRole_Click(object sender, EventArgs e)
        {

        }

      
        public static int id = 1;


        private void btnSaveAllUser_Click(object sender, EventArgs e)
        {
            userrole = new UserRole();
            userrole.UserId = userrole.GetUserId(cboUser);
            userrole.RoleId = userrole.GetRoleId(cboRole);
            userrole.Save();
            cboRole.Text = "";
            cboUser.Text = "";
            userrole.LoadingDataToDataGridView(dgUserRole);
        }

        private void btnDeleteuser_Click(object sender, EventArgs e)
        {
            userrole = new UserRole();
            userrole.DeleteById(dgUserRole);
        }
       
        private void btnUpdateuser_Click(object sender, EventArgs e)
        {

            userrole = new UserRole();
            userrole.UserId = userrole.GetUserId(cboUser);
            userrole.RoleId = userrole.GetRoleId(cboRole);
            userrole.UpdateById(dgUserRole);
            cboRole.Text = "";
            cboUser.Text = "";
            userrole.LoadingDataToDataGridView(dgUserRole);

        }
        
        private void txtSearchUserRole_TextChanged(object sender, EventArgs e)
        {
            userrole = new UserRole();
            userrole.Name = txtSearchUserRole.Text.Trim();
            userrole.SearchById(dgUserRole);
        }

       
        public static bool IsTextBoxEmpty(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }

        public static bool IsComboBoxEmpty(ComboBox comboBox)
        {
            return comboBox.SelectedValue == null || comboBox.SelectedIndex == -1;
        }

        public static void ClearComboBox(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;  // Clears the selected item
        }

        private void ControlPanelUserList10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoleId_Click_1(object sender, EventArgs e)
        {

        }

        private void UserId_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void picUserList_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        } 
        private void ControlpanelInputUserRole_Paint(object sender, PaintEventArgs e)
        {

        }      
        private void roundControlUserRole_Load(object sender, EventArgs e)
        {

        }

        private void dgUserRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          


        }

        private void roundControlHeaderUserRole_Load(object sender, EventArgs e)
        {

        }

        private void roundControl3_Load(object sender, EventArgs e)
        {

        }

        private void roundControl3_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreatAt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }  
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void roundControlinterface_Load(object sender, EventArgs e)
        {

        }

        private void cbUserId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbRoleId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgUserRole_DoubleClick(object sender, EventArgs e)
        {
            userrole = new UserRole();
            userrole.TransferDataToControls(dgUserRole, cboUser, cboRole);
        }
    }
}
