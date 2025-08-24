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
using Pos_Final.views.Suppliers;

namespace Pos_Final.views.Suppliers
{
    public partial class SupplierForm : Form
    {

        Supplier supplier;
     
        public static int id = 0;
        public SupplierForm()
        {
            InitializeComponent();
           

        }

        private void rcSupplier_Load(object sender, EventArgs e)
        {

        }

        private void rcHeaderSupplier_Load(object sender, EventArgs e)
        {

        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            supplier = new Supplier();
            supplier.LoadingDataToDataGridView(dgSupplier);
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtSupplierName, txtTel, txtAddress) == true) { return; }
            supplier = new Supplier();
            supplier.Id = id;
            supplier.Name = txtSupplierName.Text.Trim();
            supplier.Tel = long.Parse(txtTel.Text.Trim());
            supplier.Address = txtAddress.Text.Trim();
            supplier.Save();
            MyFunction.ClearTextBox(txtSupplierName, txtTel, txtAddress);
            txtSupplierName.Focus();
            supplier.LoadingDataToDataGridView(dgSupplier);
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            supplier = new Supplier();
            supplier.DeleteById(dgSupplier);

        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtSupplierName, txtTel, txtAddress) == true) { return; }
            supplier = new Supplier();
            supplier.Id = id;
            supplier.Name = txtSupplierName.Text.Trim();
            supplier.Tel = long.Parse(txtTel.Text.Trim());
            supplier.Address = txtAddress.Text.Trim();
            supplier.UpdateById(dgSupplier);
            MyFunction.ClearTextBox(txtSupplierName, txtTel,txtAddress);
            txtSupplierName.Focus();
            supplier.LoadingDataToDataGridView(dgSupplier);
        }
        private void txtSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            supplier = new Supplier();
            supplier.Name = txtSearchSupplier.Text.Trim();
            supplier.SearchById(dgSupplier);
        }
        private void rcInputSupplier_Load(object sender, EventArgs e)
        {

        }

        private void dgSupplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundControl1Sp_Load(object sender, EventArgs e)
        {

        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgSupplier_DoubleClick(object sender, EventArgs e)
        {
            supplier = new Supplier();
            supplier.TransferDataToControll(dgSupplier, txtSupplierName, txtTel,txtAddress);
        }
    }
}
