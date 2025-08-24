using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Pos_Final.Models;

namespace Pos_Final.views.Products
{
    public partial class ProductForm : Form
    {
        Product product;
        private OpenFileDialog openFileDialog;
        

        public static int id = 1;
        

        public ProductForm()
        {
            InitializeComponent();
          
           
        }
      

        private void ProductForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtName, txtBarcode, txtSellPrice) == true) { return; }
            product = new Product();
            product.Id = id;
            product.Name = txtName.Text;
            product.Barcode = long.Parse(txtBarcode.Text.Trim());
            product.SellPrice = double.Parse(txtSellPrice.Text.Trim());
            product.Photo = Product.PathPhoto;
            product.CategoryId = product.GetCategoryId(cboCategoryName);
            product.Save();
            picImage.Image = null;
            MyFunction.ClearTextBox(txtName, txtBarcode, txtSellPrice);
            txtName.Focus();
            product.LoadingDataToDataGridView(dgProduct);
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.DeleteById(dgProduct);
            product.LoadingDataToDataGridView(dgProduct);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(openFileDialog.FileName);
                Product.PathPhoto = openFileDialog.FileName;
            }
        }

        private void dgProductList_DoubleClick(object sender, EventArgs e)
        {
           
        }
        private void txtSearchPt_TextChanged(object sender, EventArgs e)
        {
            product = new Product();
            product.Name = txtSearchPt.Text.Trim();
            product.SearchById(dgProduct);
        }
        private void roundControlProduct_Load(object sender, EventArgs e)
        {

        }

        private void roundControlHeaderProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtName, txtBarcode, txtSellPrice) == true) { return; }
            product = new Product();
            product.Id = id;
            product.Name = txtName.Text;
            product.Barcode = long.Parse(txtBarcode.Text.Trim());
            product.SellPrice = double.Parse(txtSellPrice.Text.Trim());
            product.Photo = Product.PathPhoto;
            product.CategoryId = product.GetCategoryId(cboCategoryName);
            product.UpdateById(dgProduct);
            MyFunction.ClearTextBox(txtName, txtBarcode, txtSellPrice);
            picImage.Image = null;
            product.LoadingDataToDataGridView(dgProduct);
        }

      
        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSellPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtQtyInStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rcInputProduct_Load(object sender, EventArgs e)
        {

        }

        private void cbCategoryId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void roundControl7_Load(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load_1(object sender, EventArgs e)
        {
            product = new Product();
            product.LoadingDataToDataGridView(dgProduct);
            product.SetCategoryName(cboCategoryName);
        }

        private void dgProduct_DoubleClick(object sender, EventArgs e)
        {
            product = new Product();
            product.TransferDataToControll
                (
                   dgProduct, txtName, txtBarcode, txtSellPrice, cboCategoryName, picImage
                );
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            DataGridViewRow DGV = new DataGridViewRow();
            DGV = dgProduct.SelectedRows[0];
            addForm.lblId.Text = DGV.Cells[0].Value.ToString();
            addForm.lblName.Text = DGV.Cells[1].Value.ToString();
            addForm.ShowDialog();
            product.LoadingDataToDataGridView(dgProduct);
        }

       
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
