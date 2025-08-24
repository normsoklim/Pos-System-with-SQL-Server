using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_Final.Models;

namespace Pos_Final.views.Products
{
    public partial class AddForm : Form
    {
        AddStock addStock;

        public bool IsEditMode { get; internal set; }
        public int EditStockId { get; internal set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            addStock = new AddStock();
            addStock.SetSupplierName(cboSppName);
        }

        private void btnSaveStock_Click(object sender, EventArgs e)
        {
            addStock = new AddStock
            {
                supplierId = addStock.GetSupplierId(cboSppName),
                productId = int.Parse(lblId.Text.Trim()),
                Qty = int.Parse(txtQty.Text.Trim()),
                Price = double.Parse(txtPrice.Text.Trim())
            };
            addStock.UpdateStock();
            Close();
        }

        private void cboSppName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void rcInputProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
