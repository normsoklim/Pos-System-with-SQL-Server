using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_System.models;
using Pos_Final.Models; // For User.UserId

namespace Pos_Final.Models
{
    // Assuming 'Action' is a base class that provides common database operation methods
    public class AddStock : Action
    {
        public int Id { get; set; }
        public int productId { get; set; }
        public int supplierId { get; set; }
        public string productName { get; set; }
        public string supplierName { get; set; }
        public double Qty { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateAt { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsEditMode { get; set; } = false;
        public int EditStockId { get; set; } = 0;


        private string sql = "";
        private int RowEffected;
        private DataGridViewRow DGV; // Used as a temporary holder for DataGridViewRow

        public AddStock() { }

        // Constructor for creating an AddStock object (if needed for specific operations)
        public AddStock(int id, int productId, int supplierId, double qty, double price, double amount)
        {
            Id = id;
            this.productId = productId;
            this.supplierId = supplierId;
            Qty = qty;
            Price = price;
            Amount = amount;
        }

        public int GetTotalStockCount()
        {
            int count = 0;
            try
            {
                Database.ConnectionDB(); 
                this.sql = "SELECT COUNT(Id) FROM tblAddStock";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                count = (int)Database.Cmd.ExecuteScalar(); // Correctly using ExecuteScalar for aggregate
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting stock count: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); 
            }
            return count;
        }

        public void SetSupplierName(ComboBox cboSppName)
        {
            try
            {
                Database.ConnectionDB(); 
                this.sql = "select Name from tblSupplier";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                cboSppName.Items.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    cboSppName.Items.Add(r["Name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Load SupplierName: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB();
            }
        }

        public int GetSupplierId(ComboBox cboSppName)
        {
            int id = 0;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select Id from tblSupplier where Name=@Name"; // Select Id
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Name", cboSppName.Text.Trim());

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
                MessageBox.Show($"Error Get Supplier Id : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
            return id;
        }

       
        public void SetProducName(ComboBox cboProduct)
        {
            try
            {
                Database.ConnectionDB();
                this.sql = "select ProductName from tblProduct";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                cboProduct.Items.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    cboProduct.Items.Add(r["ProductName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Load ProductName: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB();
            }
        }

     
        public int GetProductId(ComboBox cboProduct)
        {
            int id = 0;
            try
            {
                Database.ConnectionDB();
                this.sql = "select Id from tblProduct where ProductName=@ProductName";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@ProductName", cboProduct.Text.Trim());

                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                if (Database.tbl.Rows.Count > 0)
                {
                    id = int.Parse(Database.tbl.Rows[0]["Id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Get Product Id : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB();
            }
            return id;
        }

        
        public DataTable GetProductDetails(string productName)
        {
            DataTable dt = new DataTable();
            try
            {
                Database.ConnectionDB();
                this.sql = "SELECT QtyInStock, SellPrice FROM tblProduct WHERE ProductName = @ProductName";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@ProductName", productName);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting product details: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB();
            }
            return dt;
        }

        
        private DataTable GetExistingAddStockEntry(int productId, int supplierId, SqlTransaction transaction)
        {
            string sql = "SELECT * FROM tblAddStock WHERE ProductId = @ProductId AND SupplierId = @SupplierId";
            SqlCommand cmd = new SqlCommand(sql, Database.Con, transaction);
            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.Parameters.AddWithValue("@SupplierId", supplierId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Transaction = transaction;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void UpdateStock() 
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                Database.ConnectionDB();
                sqlTransaction = Database.Con.BeginTransaction();

           
                DataTable existingEntry = GetExistingAddStockEntry(this.productId, this.supplierId, sqlTransaction);

                if (existingEntry.Rows.Count > 0)
                {
                    int existingId = Convert.ToInt32(existingEntry.Rows[0]["Id"]);

                    // Update tblAddStock
                    this.sql = "UPDATE tblAddStock SET Qty = Qty + @NewQty, Price = @NewPrice, Amount = (Qty + @NewQty) * @NewPrice, UpdateBy = @UpdateBy, UpdateAt = GETDATE() WHERE Id = @Id";
                    Database.Cmd = new SqlCommand(this.sql, Database.Con, sqlTransaction);
                    Database.Cmd.Parameters.AddWithValue("@NewQty", this.Qty);
                    Database.Cmd.Parameters.AddWithValue("@NewPrice", this.Price);
                    Database.Cmd.Parameters.AddWithValue("@UpdateBy", int.Parse(User.UserId));
                    Database.Cmd.Parameters.AddWithValue("@Id", existingId);
                    Database.Cmd.ExecuteNonQuery();

                    // Update product stock
                    this.sql = "UPDATE tblProduct SET QtyInStock = QtyInStock + @QtyToAdd WHERE Id = @ProductId";
                    Database.Cmd = new SqlCommand(this.sql, Database.Con, sqlTransaction);
                    Database.Cmd.Parameters.AddWithValue("@QtyToAdd", this.Qty);
                    Database.Cmd.Parameters.AddWithValue("@ProductId", this.productId);
                    Database.Cmd.ExecuteNonQuery();

                    MessageBox.Show("Stock Updated Successfully (Existing Entry)");
                }
                else
                {
                    // Insert new entry
                    this.sql = "INSERT INTO tblAddStock (SupplierId,ProductId,Qty,Price,Amount,CreateBy,CreateAt) VALUES(@SupplierId,@ProductId,@Qty,@Price,@Amount,@CreateBy,GETDATE())";
                    Database.Cmd = new SqlCommand(this.sql, Database.Con, sqlTransaction);
                    Database.Cmd.Parameters.AddWithValue("@SupplierId", this.supplierId);
                    Database.Cmd.Parameters.AddWithValue("@ProductId", this.productId);
                    Database.Cmd.Parameters.AddWithValue("@Qty", this.Qty);
                    Database.Cmd.Parameters.AddWithValue("@Price", this.Price);
                    this.Amount = this.Qty * this.Price;
                    Database.Cmd.Parameters.AddWithValue("@Amount", this.Amount);
                    Database.Cmd.Parameters.AddWithValue("@CreateBy", int.Parse(User.UserId));
                    Database.Cmd.ExecuteNonQuery();

                    // Update product stock
                    this.sql = "UPDATE tblProduct SET QtyInStock = QtyInStock + @QtyToAdd WHERE Id = @Id";
                    Database.Cmd = new SqlCommand(this.sql, Database.Con, sqlTransaction);
                    Database.Cmd.Parameters.AddWithValue("@QtyToAdd", this.Qty);
                    Database.Cmd.Parameters.AddWithValue("@Id", this.productId);
                    Database.Cmd.ExecuteNonQuery();

                    MessageBox.Show("New Stock Added Successfully");
                }

                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Stock :" + ex.Message);
                if (sqlTransaction != null)
                {
                    try { sqlTransaction.Rollback(); }
                    catch (Exception rollEx) { MessageBox.Show("Rollback Error: " + rollEx.Message); }
                }
            }
            finally
            {
                Database.CloseConnectionDB();
            }
        }
              
        public override void Save()
        {
            UpdateStock(); 
        }

        public override void LoadingDataToDataGridView(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from View_AddStock order by Id asc";

                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = Convert.ToInt32(r["Id"]);
                    string supplierName = r["SupplierName"].ToString();
                    string productName = r["ProductName"].ToString();
                    this.Qty = Convert.ToDouble(r["Qty"]);
                    this.Price = Convert.ToDouble(r["Price"]);
                    this.Amount = Convert.ToDouble(r["Amount"]);

                    object[] row = {
                        this.Id,
                        supplierName,
                        productName,
                        this.Qty,
                        this.Price,
                        this.Amount
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Add Stock: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB();
            }
        }

        public override void DeleteById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                if (dg.Rows.Count <= 0)
                {
                    return;
                }
                var click = MessageBox.Show("Do you want to Delete Record ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (click == DialogResult.Yes)
                {
                    DGV = new DataGridViewRow(); // Reinitialize DGV for clarity
                    DGV = dg.SelectedRows[0];
                    this.Id = int.Parse(DGV.Cells[0].Value.ToString());

                    // Fetch current Qty from the record being deleted to revert stock
                    double qtyToDelete = 0;
                    int productIdToDelete = 0;
                    string fetchSql = "SELECT ProductId, Qty FROM tblAddStock WHERE Id = @Id";
                    using (SqlCommand fetchCmd = new SqlCommand(fetchSql, Database.Con))
                    {
                        fetchCmd.Parameters.AddWithValue("@Id", this.Id);
                        Database.da = new SqlDataAdapter(fetchCmd);
                        DataTable tempTbl = new DataTable();
                        Database.da.Fill(tempTbl);
                        if (tempTbl.Rows.Count > 0)
                        {
                            productIdToDelete = Convert.ToInt32(tempTbl.Rows[0]["ProductId"]);
                            qtyToDelete = Convert.ToDouble(tempTbl.Rows[0]["Qty"]);
                        }
                    }
                    Database.ConnectionDB(); // Re-open connection after fetch

                    SqlTransaction deleteTransaction = Database.Con.BeginTransaction();
                    try
                    {
                        // Delete from tblAddStock
                        this.sql = "Delete from tblAddStock where Id=@Id";
                        Database.Cmd = new SqlCommand(this.sql, Database.Con, deleteTransaction);
                        Database.Cmd.Parameters.AddWithValue("@Id", this.Id);
                        this.RowEffected = Database.Cmd.ExecuteNonQuery();

                        if (RowEffected > 0)
                        {
                            // Subtract the quantity from tblProduct.QtyInStock
                            if (productIdToDelete > 0 && qtyToDelete > 0)
                            {
                                string updateProductSql = "UPDATE tblProduct SET QtyInStock = QtyInStock - @QtyToSubtract WHERE Id = @ProductId";
                                Database.Cmd = new SqlCommand(updateProductSql, Database.Con, deleteTransaction);
                                Database.Cmd.Parameters.AddWithValue("@QtyToSubtract", qtyToDelete);
                                Database.Cmd.Parameters.AddWithValue("@ProductId", productIdToDelete);
                                Database.Cmd.ExecuteNonQuery();
                            }

                            deleteTransaction.Commit();
                            MessageBox.Show("Delete item Successfully", "Delete", MessageBoxButtons.OK);
                            dg.Rows.Remove(DGV);
                        }
                        else
                        {
                            deleteTransaction.Rollback();
                            MessageBox.Show("No record found to delete or no changes made.", "Delete Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception transEx)
                    {
                        deleteTransaction?.Rollback();
                        MessageBox.Show($"Error during delete transaction: {transEx.Message}", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Delete Add Stock : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public override void UpdateById(DataGridView dg)
        {
            SqlTransaction updateTransaction = null;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                updateTransaction = Database.Con.BeginTransaction();

                DGV = new DataGridViewRow(); // Reinitialize DGV for clarity
                DGV = dg.SelectedRows[0];
                this.Id = int.Parse(DGV.Cells[0].Value.ToString());

                // Fetch old quantity and product ID before updating tblAddStock
                double oldQty = 0;
                int oldProductId = 0;
                string fetchOldDataSql = "SELECT ProductId, Qty FROM tblAddStock WHERE Id = @Id";
                using (SqlCommand fetchCmd = new SqlCommand(fetchOldDataSql, Database.Con, updateTransaction))
                {
                    fetchCmd.Parameters.AddWithValue("@Id", this.Id);
                    Database.da = new SqlDataAdapter(fetchCmd);
                    DataTable tempTbl = new DataTable();
                    Database.da.Fill(tempTbl);
                    if (tempTbl.Rows.Count > 0)
                    {
                        oldProductId = Convert.ToInt32(tempTbl.Rows[0]["ProductId"]);
                        oldQty = Convert.ToDouble(tempTbl.Rows[0]["Qty"]);
                    }
                }

                // Update tblAddStock
                this.sql = "Update tblAddStock set " +
                    "SupplierId=@SupplierId," +
                    "ProductId =@ProductId," +
                    "Qty=@Qty," +
                    "Price=@Price," +
                    "Amount=@Amount," +
                    "UpdateBy=@UpdateBy," +
                    "UpdateAt=GETDATE()" +
                    "where Id=@Id";

                Database.Cmd = new SqlCommand(this.sql, Database.Con, updateTransaction);
                Database.Cmd.Parameters.AddWithValue("@SupplierId", this.supplierId);
                Database.Cmd.Parameters.AddWithValue("@ProductId", this.productId);
                Database.Cmd.Parameters.AddWithValue("@Qty", this.Qty);
                Database.Cmd.Parameters.AddWithValue("@Price", this.Price);
                this.Amount = this.Qty * this.Price; // Re-calculate amount
                Database.Cmd.Parameters.AddWithValue("@Amount", this.Amount);
                Database.Cmd.Parameters.AddWithValue("@UpdateBy", int.Parse(User.UserId));
                Database.Cmd.Parameters.AddWithValue("@Id", this.Id);

                this.RowEffected = Database.Cmd.ExecuteNonQuery();

                if (this.RowEffected > 0)
                {
                    // Adjust tblProduct QtyInStock based on the change in quantity
                    if (oldProductId > 0)
                    {
                        double qtyDifference = this.Qty - oldQty; // New Qty - Old Qty
                        string updateProductSql = "UPDATE tblProduct SET QtyInStock = QtyInStock + @QtyDifference WHERE Id = @ProductId";
                        Database.Cmd = new SqlCommand(updateProductSql, Database.Con, updateTransaction);
                        Database.Cmd.Parameters.AddWithValue("@QtyDifference", qtyDifference);
                        Database.Cmd.Parameters.AddWithValue("@ProductId", this.productId); // Use the new productId in case it changed
                        Database.Cmd.ExecuteNonQuery();
                    }

                    updateTransaction.Commit();
                    MessageBox.Show("AddStock updated successfully");
                }
                else
                {
                    updateTransaction.Rollback();
                    MessageBox.Show("No changes made or AddStock record not found for update.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating AddStock: {ex.Message}");
                updateTransaction?.Rollback();
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public override void SearchById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from View_AddStock where ProductName like '%' +@ProductName+ '%' ";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@ProductName", this.productName); // Use productName property

                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    string supplierName = r["SupplierName"].ToString();
                    string productName = r["ProductName"].ToString();
                    this.Qty = Convert.ToDouble(r["Qty"]);
                    this.Price = Convert.ToDouble(r["Price"]);
                    this.Amount = Convert.ToDouble(r["Amount"]);

                    object[] row = { this.Id, supplierName, productName, this.Qty, this.Price, this.Amount };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Search AddStock : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public void TransferDataToControls(DataGridView dg, ComboBox cboSppName, ComboBox cboProduct, Label lblQty
            , Label lblPrice, Label lblTotalAmount)
        {
            try
            {
                if (dg.SelectedRows.Count > 0)
                {
                    DGV = dg.SelectedRows[0];
                    this.Id = int.Parse(DGV.Cells[0].Value.ToString());
                    cboSppName.Text = DGV.Cells[1].Value.ToString(); // SupplierName
                    cboProduct.Text = DGV.Cells[2].Value.ToString(); // ProductName
                    lblQty.Text = DGV.Cells[3].Value.ToString(); // Qty
                    lblPrice.Text = DGV.Cells[4].Value.ToString(); // Price
                    lblTotalAmount.Text = DGV.Cells[5].Value.ToString(); // Amount
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error transferring data to controls: {ex.Message}");
            }
          
        }

      

    }
}
