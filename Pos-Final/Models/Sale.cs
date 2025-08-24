using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Pos_Final.Models;
using Pos_Final.views;
using Pos_System.models;

namespace Pos_Final.Models
{
    public class Sale : Product
    {
        // Properties
        public string Sql { get; set; }
        public int Qty { get; set; }
        public double CashRecieve { get; set; }
        public double CashReturn { get; set; }
        public int SaleId { get; set; }
        public string sql = "";
        public int CustomerId { get; set; }
        public static string CustomerName { get; set; }

        public double CalculateAmount()
        {
            return this.Qty * this.SellPrice;
        }

        public decimal GetTotalSaleAmount() // Changed return type to decimal
        {
            decimal totalAmount = 0.0m; // Initialize with decimal zero
            try
            {
                Database.ConnectionDB(); // Opens the connection
                this.sql = "SELECT ISNULL(SUM(TotalAmount), 0) FROM tblSale"; // Use ISNULL to handle no rows (returns 0 instead of DBNull)
                using (SqlCommand cmd = new SqlCommand(this.sql, Database.Con))
                {
                    object result = cmd.ExecuteScalar(); // ExecuteScalar is correct for single value
                    if (result != DBNull.Value)
                    {
                        totalAmount = Convert.ToDecimal(result); // Convert to decimal
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting Total Sale Amount: {ex.Message}");
                // Optionally, log the error more comprehensively
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
            return totalAmount;
        }


        public double CalculateTotalAmount(DataGridView dgSale)
        {
            double sum = 0;
            foreach (DataGridViewRow DGV in dgSale.Rows)
            {
                // Ensure the cell value is not null before parsing
                if (DGV.Cells[5].Value != null && double.TryParse(DGV.Cells[5].Value.ToString(), out double cellValue))
                {
                    sum += cellValue;
                }
            }
            return sum;
        }


        public void ScanBarcode(DataGridView dgSale)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from tblProduct where Barcode = @Barcode "; // Use 'sql' property consistently
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Barcode", this.Barcode);

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                if (Database.tbl.Rows.Count > 0)
                {
                    this.Id = int.Parse(Database.tbl.Rows[0]["Id"].ToString());
                    this.Barcode = long.Parse(Database.tbl.Rows[0]["Barcode"].ToString());
                    this.Name = Database.tbl.Rows[0]["ProductName"].ToString();
                    this.Qty = 1; // Default quantity for new item
                    this.SellPrice = double.Parse(Database.tbl.Rows[0]["SellPrice"].ToString());

                    bool itemFoundInGrid = false;
                    foreach (DataGridViewRow DGV in dgSale.Rows)
                    {
                        if (DGV.Cells[1].Value != null && long.TryParse(DGV.Cells[1].Value.ToString(), out long checkBarcode))
                        {
                            if (checkBarcode == Barcode)
                            {
                                // Update quantity and total for existing item
                                this.Qty = int.Parse(DGV.Cells[3].Value.ToString()) + 1;
                                DGV.Cells[3].Value = this.Qty;
                                DGV.Cells[5].Value = this.CalculateAmount(); // Recalculate total for the row
                                itemFoundInGrid = true;
                                break; // Exit loop once item is found and updated
                            }
                        }
                    }

                    if (!itemFoundInGrid)
                    {
                        // Add new row if item not found in grid
                        Object[] row =
                        {
                            this.Id,
                            this.Barcode,
                            this.Name,
                            this.Qty,
                            this.SellPrice,
                            this.CalculateAmount()
                        };
                        dgSale.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Product not found with this barcode.", "Scan Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scan barcode : " + ex.Message);
            }
            finally
            {
                Database.CloseConnectionDB();
            }
        }

        public void CommitData(DataGridView dgSale, double cashRecieve, double cashReturn)
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open before starting transaction
                sqlTransaction = Database.Con.BeginTransaction();
                double totalAmount = CalculateTotalAmount(dgSale);

                this.CashRecieve = cashRecieve; // <-- Set it here
                this.CashReturn = cashReturn;   // <-- Set it her

                // Insert into tblSale
                this.sql = "insert into tblSale (CustomerId,SaleDate,UserId,TotalAmount) values (@CustomerId,GETDATE(),@UserId,@TotalAmount) select SCOPE_IDENTITY();";
                Database.Cmd = new SqlCommand(this.sql, Database.Con, sqlTransaction);
                Database.Cmd.Parameters.AddWithValue("@CustomerId", this.CustomerId);
                // Ensure User.UserId is parsed to int if tblSale.UserId is int
                Database.Cmd.Parameters.AddWithValue("@UserId",int.Parse(User.UserId));
                Database.Cmd.Parameters.AddWithValue("@TotalAmount", CalculateTotalAmount(dgSale));
                this.SaleId = Convert.ToInt32(Database.Cmd.ExecuteScalar());
                
               

                foreach (DataGridViewRow DGV in dgSale.Rows)
                {
                    if (DGV.Cells[0].Value == null) continue;

                    int productId = int.Parse(DGV.Cells[0].Value.ToString());
                    int qty = int.Parse(DGV.Cells[3].Value.ToString());
                    double price = double.Parse(DGV.Cells[4].Value.ToString());
                    double total = qty * price;

                    // Insert into tblSaleDetail
                    this.sql = "insert into tblSaleDetail(SaleId, ProductId, Qty, Price, Total) values (@SaleId, @ProductId, @Qty, @Price, @Total)";
                    Database.Cmd = new SqlCommand(this.sql, Database.Con, sqlTransaction);
                    Database.Cmd.Parameters.AddWithValue("@SaleId", this.SaleId);
                    Database.Cmd.Parameters.AddWithValue("@ProductId", productId);
                    Database.Cmd.Parameters.AddWithValue("@Qty", qty);
                    Database.Cmd.Parameters.AddWithValue("@Price", price);
                    Database.Cmd.Parameters.AddWithValue("@Total", total);
                    Database.Cmd.ExecuteNonQuery();


                    this.sql = "update tblProduct set QtyInStock = QtyInStock - @Qty where Id = @ProductId";
                    Database.Cmd = new SqlCommand(this.sql, Database.Con, sqlTransaction);
                    Database.Cmd.Parameters.AddWithValue("@Qty", qty);
                    Database.Cmd.Parameters.AddWithValue("@ProductId", productId);
                    Database.Cmd.ExecuteNonQuery();
                }
                sqlTransaction.Commit();
                MessageBox.Show("Sale has Successful ");
                PrintSaleReport(SaleId);
                dgSale.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error commit data : " + ex.Message);
                sqlTransaction?.Rollback();
            }
            finally
            {
                Database.CloseConnectionDB();
            }
        }
        public void SetCustomer(ComboBox cboCustomer)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select CustomerName from tblCustomer";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                cboCustomer.Items.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    cboCustomer.Items.Add(r["CustomerName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Load CustomerName: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public int GetCustomer(ComboBox cboCustomer)
        {
            int id = 0;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select Id from tblCustomer where CustomerName = @CustomerName"; // Select Id and fix parameter name
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@CustomerName", cboCustomer.Text.Trim()); // Removed trailing space

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                if (Database.tbl.Rows.Count > 0)
                {
                    id = int.Parse(Database.tbl.Rows[0]["Id"].ToString()); // Access by column name
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Get Customer ID : {ex.Message}"); // Corrected message for clarity
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
            return id;
        }
        public void TransferToKhmer(DataGridView dgSale, Label lblTotalKhmer)
        {
            try
            {
                double exchangeRate = 4100; 
                double totalUSD = CalculateTotalAmount(dgSale);
                double totalKHR = totalUSD * exchangeRate;
                lblTotalKhmer.Text = $"៛ {totalKHR:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting to Riel: " + ex.Message);
            }
            
        }

        public void PrintSaleReport(int id)
        {
            try
            {
                Database.ConnectionDB(); // ✅ Open DB connection

                this.sql = "SELECT * FROM View_Sale_Report WHERE SaleId = @SaleId";
                Database.Cmd = new SqlCommand(sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@SaleId", id);

                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                ReportDataSource rds = new ReportDataSource("DataSetSaleReport", Database.tbl);

                LocalReport rpt = new LocalReport();
                rpt.ReportPath = Application.StartupPath + @"\Reports\SaleReport.rdlc";
                rpt.DataSources.Clear();
                rpt.DataSources.Add(rds);
                ReportParameter[] parameters = new ReportParameter[]
                {
            new ReportParameter("CashRecieve", CashRecieve.ToString("N2")), // format as 12.34
            new ReportParameter("CashReturn", CashReturn.ToString("N2"))
                };
                rpt.SetParameters(parameters);

                //PrintReport objPrint = new PrintReport();
                //objPrint.Export(rpt);
                //objPrint.m_currentPageIndex = 0;
                //objPrint.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Reporting: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // ✅ Always close the connection
            }
        }

    }

}
     