using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing; // Added for Image
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_System.models; // Assuming Database class is here

namespace Pos_Final.Models
{
    public class Product : Action // Assuming 'Action' is a base class you have
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Barcode { get; set; }
        public int QtyInStock { get; set; }
        public double SellPrice { get; set; }
        public double TotalPrice { get; set; }
        public string Photo { get; set; }
        public static string PathPhoto { get; set; } = string.Empty;
        public string ProductName { get; set; }
        public static string CategoryName { get; set; } // This is a static property, consider if it should be instance
        public int CategoryId { get; set; }
        private string sql = "";
        private int RowEffected;
        private DataGridViewRow DGV; // This should ideally be a local variable in methods where it's used


        public Product() { }
        public Product(int id, string name, long barcode, int qtyinstock, double sellprice, string photo)
        {
            Id = id;
            Name = name;
            Barcode = barcode;
            QtyInStock = qtyinstock;
            SellPrice = sellprice;
            Photo = photo;
        }

        public int GetTotalProductCount()
        {
            int count = 0;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "SELECT COUNT(Id) FROM tblProduct";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                count = (int)Database.Cmd.ExecuteScalar(); // Correctly using ExecuteScalar for aggregate
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting product count: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
            return count;
        }

        public bool IsCheckDouplicated(string columnName, object strColumnName, string message)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from tblProduct where " + columnName + " = @Value"; // Use a generic parameter name
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Value", strColumnName); // Pass the value to the generic parameter

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                if (Database.tbl.Rows.Count > 0)
                {
                    MessageBox.Show("Product " + message + " has been already");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
            return true;
        }

        public override void Save()
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open for the entire Save operation

                // Perform duplication checks
                if (IsCheckDouplicated("ProductName", this.Name, "Name") == false)
                {
                    return;
                }
                // Re-open connection after IsCheckDouplicated closes it
                Database.ConnectionDB();
                if (IsCheckDouplicated("Barcode", this.Barcode, "Barcode") == false)
                {
                    return;
                }
                // Re-open connection after IsCheckDouplicated closes it
                Database.ConnectionDB();

                this.sql = "insert into tblProduct (ProductName,Barcode,SellPrice,QtyInStock,Image,CategoryId,CreateBy,CreateAt)" +
                    "values(@ProductName,@Barcode,@SellPrice,@QtyInStock,@Image,@CategoryId,@CreateBy,GETDATE())";

                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                Database.Cmd.Parameters.AddWithValue("@ProductName", this.Name);
                Database.Cmd.Parameters.AddWithValue("@Barcode", this.Barcode);
                Database.Cmd.Parameters.AddWithValue("@SellPrice", this.SellPrice);
                Database.Cmd.Parameters.AddWithValue("@QtyInStock", this.QtyInStock);
                Database.Cmd.Parameters.AddWithValue("@Image", this.Photo);
                Database.Cmd.Parameters.AddWithValue("@CategoryId", this.CategoryId);
                Database.Cmd.Parameters.AddWithValue("@CreateBy", int.Parse(User.UserId)); // Ensure UserId is an integer

                this.RowEffected = Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for INSERT

                if (this.RowEffected > 0)
                {
                    MessageBox.Show("Product saved successfully");
                    Product.PathPhoto = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message);
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }
      

        public override void LoadingDataToDataGridView(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); 
                this.sql = "select top 10 * from View_Product_Category order by Id asc";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.Name = r["ProductName"].ToString();
                    this.Barcode = long.Parse(r["Barcode"].ToString());
                    this.SellPrice = double.Parse(r["SellPrice"].ToString());
                    this.QtyInStock = int.Parse(r["QtyInStock"].ToString());
                    string categoryName = r["CategoryName"].ToString();
                    object[] row = { this.Id, this.Name, this.Barcode, this.SellPrice, this.QtyInStock, categoryName };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Product : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public override void DeleteById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                if (dg.SelectedRows.Count == 0) return;

                var click = MessageBox.Show("Do you want to delete this record?", "Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (click == DialogResult.Yes)
                {
                    DGV = dg.SelectedRows[0];
                    this.Id = Convert.ToInt32(DGV.Cells[0].Value);

                    this.sql = "DELETE FROM tblProduct WHERE Id = @Id";
                    Database.Cmd = new SqlCommand(this.sql, Database.Con);
                    Database.Cmd.Parameters.AddWithValue("@Id", this.Id);
                    this.RowEffected = Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for DELETE

                    if (RowEffected > 0)
                    {
                        MessageBox.Show("Item deleted successfully", "Delete", MessageBoxButtons.OK);
                        dg.Rows.Remove(DGV);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public void TransferDataToControll(DataGridView dg, TextBox txtName, TextBox txtBarcode
            , TextBox txtSellPrice, ComboBox cboCategoryName, PictureBox picPhoto)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                DGV = new DataGridViewRow();
                DGV = dg.SelectedRows[0];
                this.Id = int.Parse(DGV.Cells[0].Value.ToString());
                this.sql = "select * from View_Product_Category where Id = @Id ";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Id", this.Id);

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                if (Database.tbl.Rows.Count > 0)
                {
                    txtName.Text = Database.tbl.Rows[0]["ProductName"].ToString();
                    txtBarcode.Text = Database.tbl.Rows[0]["Barcode"].ToString();
                    txtSellPrice.Text = Database.tbl.Rows[0]["SellPrice"].ToString();
                    cboCategoryName.Text = Database.tbl.Rows[0]["CategoryName"].ToString();
                    string imagePath = Database.tbl.Rows[0]["Image"].ToString(); // Use a local variable for clarity
                    if (string.IsNullOrEmpty(imagePath)) // Check for null or empty string
                    {
                        picPhoto.Image = null; // Set PictureBox image to null
                    }
                    else
                    {
                        // Check if the file exists before trying to load it
                        if (System.IO.File.Exists(imagePath))
                        {
                            picPhoto.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show("Image file not found at: " + imagePath, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            picPhoto.Image = null; // Clear the image if not found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading data: " + ex.Message);
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public override void UpdateById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open for the entire Update operation
                if (dg.Rows.Count <= 0) { return; }
                DGV = new DataGridViewRow();
                DGV = dg.SelectedRows[0];
                this.Id = int.Parse(DGV.Cells[0].Value.ToString());

                // Perform duplication checks
                // Re-open connection after IsCheckDouplicated closes it
                if (IsCheckDouplicated("ProductName", this.Name, "Name") == false)
                {
                    return;
                }
                Database.ConnectionDB();
                if (IsCheckDouplicated("Barcode", this.Barcode, "Barcode") == false)
                {
                    return;
                }
                Database.ConnectionDB();

                this.sql = "UPDATE tblProduct SET" +
                    " ProductName = @ProductName," +
                    " Barcode = @Barcode, " +
                    " SellPrice = @SellPrice," +
                    " Image = @Image," +
                    " CategoryId = @CategoryId," +
                    " UpdateBy = @UpdateBy, " +
                    " UpdateAt = GETDATE() " +
                    " WHERE Id = @Id";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@ProductName", this.Name); // Corrected parameter name
                Database.Cmd.Parameters.AddWithValue("@Barcode", this.Barcode);
                Database.Cmd.Parameters.AddWithValue("@SellPrice", this.SellPrice);
                Database.Cmd.Parameters.AddWithValue("@Image", this.Photo);
                Database.Cmd.Parameters.AddWithValue("@CategoryId", this.CategoryId);
                Database.Cmd.Parameters.AddWithValue("@UpdateBy", int.Parse(User.UserId)); // Ensure UserId is an integer
                Database.Cmd.Parameters.AddWithValue("@Id", this.Id);

                this.RowEffected = Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for UPDATE
                if (this.RowEffected > 0)
                {
                    MessageBox.Show("Update Item Successfully ");
                    Product.PathPhoto = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Update Product : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public void SetCategoryName(ComboBox cboCategoryName)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select CategoryName from tblCategory";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                cboCategoryName.Items.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    cboCategoryName.Items.Add(r["CategoryName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Load CategoryName: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public int GetCategoryId(ComboBox cboCategoryName)
        {
            int id = 0;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select Id from tblCategory where CategoryName = @CategoryName"; // Select Id
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@CategoryName", cboCategoryName.Text.Trim());

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
                MessageBox.Show($"Error GetCategoryId : {ex.Message}"); // Corrected message for clarity
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
            return id;
        }

        public override void SearchById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from View_Product_Category where ProductName like '%' + @ProductName + '%' ";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@ProductName", this.Name);

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.Name = r["ProductName"].ToString();
                    this.Barcode = long.Parse(r["Barcode"].ToString());
                    this.SellPrice = double.Parse(r["SellPrice"].ToString());
                    this.QtyInStock = int.Parse(r["QtyInStock"].ToString());

                    string CategoryName = r["CategoryName"].ToString();

                    object[] row = { this.Id, this.Name, this.Barcode, this.SellPrice, this.QtyInStock, CategoryName };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Search Product : {ex.Message}"); // Corrected message for clarity
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }
    }
}
