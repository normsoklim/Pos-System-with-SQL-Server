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

namespace Pos_Final.views.Customers
{
    public partial class CustomerForm : Form
    {
        Customer customer;
     
        public static int id = 0;
        public CustomerForm()
        {
            InitializeComponent();
            customer = new Customer();
            customer.LoadingDataToDataGridView(dgCustomer);

        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerSV_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtCustomerName, txtTel, txtAddress) == true) { return; }
            customer = new Customer();
            customer.Id = id;
            customer.CustomerName = txtCustomerName.Text.Trim();
            customer.Gender = cboGender.Text.Trim();
            customer.Tel = long.Parse(txtTel.Text.Trim());
            customer.Address = txtAddress.Text.Trim();
            customer.Save();
            MyFunction.ClearTextBox(txtCustomerName, txtTel, txtAddress);
            txtCustomerName.Focus();
            customer.LoadingDataToDataGridView(dgCustomer);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            customer.DeleteById(dgCustomer);
        }


        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtCustomerName, txtTel, txtAddress) == true) { return; }
            customer = new Customer();
            customer.Id = id;
            customer.CustomerName = txtCustomerName.Text.Trim();
            customer.Gender = cboGender.Text.Trim();
            customer.Tel = long.Parse(txtTel.Text.Trim());
            customer.Address = txtAddress.Text.Trim();
            customer.UpdateById(dgCustomer);
            MyFunction.ClearTextBox(txtCustomerName, txtTel, txtAddress);
            txtCustomerName.Focus();
            customer.LoadingDataToDataGridView(dgCustomer);
        }
       

        private void txtAddressCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchCustomer_TextChanged_1(object sender, EventArgs e)
        {
           customer = new Customer();   
           customer.CustomerName = txtSearchCustomer.Text.Trim();
           customer.SearchById(dgCustomer);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgCustomer_DoubleClick(object sender, EventArgs e)
        {
            customer = new Customer();
            customer.TransferDataToControls(dgCustomer,txtCustomerName,cboGender,txtTel,txtAddress);
        }

        private void roundControlHeaderCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
