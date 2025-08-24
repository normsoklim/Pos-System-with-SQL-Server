using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_System.models;

namespace Pos_Final.Models
{
    public class SaleDetail : Action
    {
        public string Name { get; set; }
        public DateTime SaleDate { get; set; }
        public double TotalAmount { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string sql = "";

      

        public void Save(DataGridView dataGridView)
        {
            
            dataGridView.Rows.Add( SaleId, ProductId, Qty, Price, Total);

        }
        public SaleDetail() { }
        public SaleDetail( int saldId, int productId, int qty, double price, double total)
        {
            this.SaleId = saldId;
            ProductId = productId;
            Qty = qty;
            Price = price;
            Total = total;
        }

        public override void Save()
        {
          
        }
        public override void LoadingDataToDataGridView(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); 
                this.sql = "select * from View_Sale_Report order by SaleId asc";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                   
                    this.SaleId = int.Parse(r["SaleId"].ToString());
                    this.SaleDate = DateTime.Parse(r["SaleDate"].ToString());
                    this.TotalAmount = double.Parse(r["TotalAmount"].ToString());
                    string productNanme= r["ProductName"].ToString();
                    this.Qty= int.Parse(r["Qty"].ToString());
                    this.Price = double.Parse(r["Price"].ToString());
                    this.Total = double.Parse(r["Total"].ToString());

                    object[] row = {
                      
                        this.SaleId,
                        SaleDate.ToString("dd-MM-yyyy"),
                        this.TotalAmount.ToString("$ #,##0.00"),
                        productNanme,
                        this.Qty,
                        this.Price,
                        this.Total.ToString("$ #,##0.00")
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading SaleDetail: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB();
            }
        }
        public int GetProductId(ComboBox cboProduct)
        {

            return int.Parse(cboProduct.SelectedValue.ToString());
        }
        public override void UpdateById(DataGridView dg)
        {
            
        }

        public override void DeleteById(DataGridView dg)
        {
           
        }


        public override void Search(DataGridView dg, string searchTerm)
        {
           
        }
       
         


    }

}

