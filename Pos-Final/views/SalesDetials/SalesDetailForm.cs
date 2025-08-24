using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using Pos_Final.Models;
using Pos_Final.views.Sales;


namespace Pos_Final.views.SaleDetial
{
    public partial class SaleDetailForm : Form
    {
        SaleDetail salesDetail;
        
        
        public static int id = 1;
        private int saleId;
        private int currentSaleDetailId = 0;

        public SaleDetailForm()
        {
            InitializeComponent();
       
            salesDetail = new SaleDetail();
            salesDetail.LoadingDataToDataGridView(dgSalesDetail);
            
        }
        public SaleDetailForm(int saleId) : this() 
        {
            this.saleId = saleId;
            LoadSaleDetails();
           

        }
        private void LoadSaleDetails()
        {
            
        }

        private void btnSaveSalesDetail_Click_1(object sender, EventArgs e)
        {
            
        }


        private void btnUpdateDetail_Click_1(object sender, EventArgs e)
        {
           
            
        }

     
        private void btnDeleteDetail_Click_1(object sender, EventArgs e)
        {
            
        }
    
        private void SalesDetailForm_Load(object sender, EventArgs e)
        {
            salesDetail.LoadingDataToDataGridView(dgSalesDetail);
        }
        private void txtSaleSearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void detialFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roundControlHeaderSale_Load(object sender, EventArgs e)
        {

        }
        private void dgSalesDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSalesDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearFields()
        {


        }

        private void lblQtyInStock_Click(object sender, EventArgs e)
        {

        }

        private void lblSellPrice_Click(object sender, EventArgs e)
        {

        }
        private void txtQtySale_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtPriceSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboProductId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSaleId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IblDollar_Click(object sender, EventArgs e)
        {

        }

        private void IblRiel_Click(object sender, EventArgs e)
        {

        }


        private void roundControlSale_Load(object sender, EventArgs e)
        {

        }

        private void roundControl3_Load(object sender, EventArgs e)
        {

        }

        private void rcAmount_Load(object sender, EventArgs e)
        {

        }

        private void roundControl2_Load(object sender, EventArgs e)
        {

        }

        private void roundControl6_Load(object sender, EventArgs e)
        {

        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
