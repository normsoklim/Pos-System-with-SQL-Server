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

namespace Pos_Final.views.Products
{
    public partial class CategoryForm : Form
    {
        public Category category;
        public static int id = 1;

        public CategoryForm()
        {
            InitializeComponent();
            category = new Category();
            category.LoadingDataToDataGridView(dgCategory);
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            category = new Category();
            category.LoadingDataToDataGridView(dgCategory);

        }

      

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtCategoryName) == true) { return; }
            category = new Category();
            category.Id = id;
            category.CategoryName = txtCategoryName.Text;
            if (rTrue.Checked)
            {
                category.Status = true;
            }
            else
            {
                category.Status = false;
            }


            category.Save();
            MyFunction.ClearTextBox(txtCategoryName);
            txtCategoryName.Focus();
            category.LoadingDataToDataGridView(dgCategory);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            category = new Category();
            category.DeleteById(dgCategory);
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (MyFunction.IsTextBoxEmpty(txtCategoryName) == true) { return; }
            category = new Category();
            category.Id = id;
            category.CategoryName = txtCategoryName.Text;
            if (rTrue.Checked)
            {
                category.Status = true;
            }
            else
            {
                category.Status = false;
            }

            category.UpdateById(dgCategory);
            MyFunction.ClearTextBox(txtCategoryName);
            txtCategoryName.Focus();
            category.LoadingDataToDataGridView(dgCategory);
        }

        private void dgCategory_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            category = new Category();
            category.CategoryName = txtSearchCategory.Text.Trim();
            category.SearchById(dgCategory);
        }

        private void cbStatusCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Handle status change if needed
        }

        private void txtNameCategory_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text change if needed
        }

        private void dgCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell content click if needed
        }

        private void roundControl1_Load(object sender, EventArgs e)
        {
            // Optional: Handle custom control load if needed
        }

        private void roundControlHeaderUserRole_Load(object sender, EventArgs e)
        {
            // Optional: Handle custom control load if needed
        }

        private void panelCategoryList_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Handle panel paint if needed
        }

        private void panelInputCategory_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Handle panel paint if needed
        }

        private void rCCateogryList_Load(object sender, EventArgs e)
        {
            // Optional: Handle custom control load if needed
        }

        private void rcInputCategory_Load(object sender, EventArgs e)
        {
            // Optional: Handle custom control load if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click if needed
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgCategory_DoubleClick_1(object sender, EventArgs e)
        {
            category = new Category();
            category.TransferDataToControll(dgCategory, txtCategoryName, rTrue, rFalse);
        }
    }
}