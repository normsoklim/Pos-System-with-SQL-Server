using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_Final.Models;
using Pos_Final.views.SaleDetial;

namespace Pos_Final.views.Sales
{
    public partial class SaleForm : Form
    {
         Sale sale;
        public static int id = 1;
        public SaleForm()
        {
            InitializeComponent();
            sale = new Sale();
            sale.SetCustomer(cboCustomer);

        }
        private void SaleForm_Load(object sender, EventArgs e)
        {
           
        }
      
        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            
          
        }

        private void btnUpdateSale_Click(object sender, EventArgs e)
        {
           
        }

        private void cboCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboUserId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadSales()
        {
            
        }


        private void btnSaveSales_Click(object sender, EventArgs e)
        {
           



        }
        private void roundControlnputRoleform_Load(object sender, EventArgs e)
        {

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaleSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ValidateNumberInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void UpdateTotalAmountLabel()
        {
           
        }
       

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {
         


        }
        

        private void SaleForm_Load_1(object sender, EventArgs e)
        {

        }

        private void SaleDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
         

        }
        private void dgSales_SelectionChanged(object sender, EventArgs e)
        {
           
        }
        

        private void roundControl3_Load(object sender, EventArgs e)
        {

        }
        private void dgSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSaleDetail_Click(object sender, EventArgs e)
        {
            
        }

        private void lblDollar_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txtScanbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtScanbarcode.Text.Equals(""))
                {
                    txtScanbarcode.Focus();
                    return;
                }
                Sale sale = new Sale();
                sale.Barcode = long.Parse(txtScanbarcode.Text.Trim());
                sale.ScanBarcode(dgSale);
                lblTotalAmount.Text = sale.CalculateTotalAmount(dgSale).ToString("$ #,##0.00");
                sale.TransferToKhmer(dgSale, lblTotalKhmer);
                txtScanbarcode.Clear();
                txtScanbarcode.Focus();
            }
        }

       
        private void txtCashRecieve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCashRecieve.Text.Equals(""))
                {
                    txtCashRecieve.Focus();
                    return;
                }
                double cashReceive, cashReturn, totalAmount;
                totalAmount = double.Parse(lblTotalAmount.Text.Trim().Replace("$", "").Replace(",", ""));
                cashReceive = double.Parse(txtCashRecieve.Text.Trim());
                if (cashReceive >= totalAmount)
                {
                    cashReturn = cashReceive - totalAmount;
                    txtCashRecieve.Text = cashReceive.ToString();
                    lblCashReturn.Text = cashReturn.ToString("$ #,##0.00");
                    lblReturnKhmer.Text = (cashReturn * 4100).ToString("៛ #,##0.00");

                }
                else
                {
                    MessageBox.Show("Cash Receive must be greater than or equal to Total Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCashRecieve.Clear();
                    txtCashRecieve.Focus();

                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
          
            try
            {
                double calculatedTotal = new Sale().CalculateTotalAmount(dgSale); 
                double cashRecieve = double.Parse(txtCashRecieve.Text.Trim());
                double cashReturn = cashRecieve - calculatedTotal;

                if (cashReturn < 0)
                {
                    MessageBox.Show("Cash received is less than total amount.");
                    return;
                }

                Sale sale = new Sale();
                sale.CustomerId = sale.GetCustomer(cboCustomer);
                sale.CashRecieve = cashRecieve;
                sale.CashReturn = cashReturn;

                sale.CommitData(dgSale, cashRecieve, cashReturn);
                Clear(); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid number format. Please enter valid amounts.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during sale: " + ex.Message);
            }
        }
        public void Clear()
        {
            txtCashRecieve.Clear();
            lblCashReturn.Text = "";
            txtCashRecieve.Text = "";
            lblTotalAmount.Text = "";
            lblReturnKhmer.Text = "";
            lblTotalKhmer.Text = "";
            cboCustomer.Text = "";
            
        }
        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblReturnKhmer_Click(object sender, EventArgs e)
        {

        }

        private void lblReturnKhmer_AutoSizeChanged(object sender, EventArgs e)
        {
           
        }

        private void roundControl5_Load(object sender, EventArgs e)
        {

        }
        private void lblTotalAmount_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSaleDetail_Click_1(object sender, EventArgs e)
        {
            SaleDetailForm saleDetailForm = new SaleDetailForm(sale.SaleId);
            saleDetailForm.ShowDialog();
            saleDetailForm.FormClosed += SaleDetailForm_FormClosed;
         
        }

        private void roundControlHeaderSale_Load(object sender, EventArgs e)
        {

        }
    }
}
