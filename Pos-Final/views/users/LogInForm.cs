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

namespace Pos_Final
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
          
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void roundControl1_Load(object sender, EventArgs e)
        {

        }

        private void roundControl4_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }
        }

        private void cboShowPss_CheckedChanged(object sender, EventArgs e)
        {
             txtPassword.PasswordChar = cboShowPss.Checked ? '\0' : '*';
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(" "))
            {
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Focus();
                return;
            }
            User user = new User();
            user.Name = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.LogIn(this);
        }
    }
}

