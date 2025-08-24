using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_System.models; // Assuming Database class is here
using Pos_Final.Models; // For User.UserId

namespace Pos_Final.Models
{
    internal class Supplier : Action // Assuming 'Action' is a base class you have
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Tel { get; set; }
        public string Address { get; set; }
        public int CreateBy { get; set; } // Changed to int to match User.UserId
        public DateTime CreateAt { get; set; } // Changed to DateTime
        public int UpdateBy { get; set; } // Changed to int to match User.UserId
        public DateTime UpdateAt { get; set; } // Changed to DateTime


        private string sql = "";
        private int RowEffected;
        private DataGridViewRow DGV;

        // Constructor
        public Supplier() { }

        // Method to check for duplicated entries
        public bool IsCheckDouplicated(string columnName, object strColumnName, string message)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from tblSupplier where " + columnName + " = @Value"; // Use a generic parameter name
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Value", strColumnName); // Pass the value to the generic parameter

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                if (Database.tbl.Rows.Count > 0)
                {
                    MessageBox.Show("Supplier " + message + " has been already");
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

        // Method to save a new supplier
        public override void Save()
        {
            try
            {
                // Perform duplication checks. Each call to IsCheckDouplicated opens and closes the connection.
                // So, we need to ensure the connection is open for the INSERT statement afterwards.
                if (IsCheckDouplicated("Name", this.Name, "Name") == false)
                {
                    return;
                }
                Database.ConnectionDB(); // Re-open connection after first check
                if (IsCheckDouplicated("Tel", this.Tel, "Tel") == false)
                {
                    return;
                }
                Database.ConnectionDB(); // Re-open connection after second check

                this.sql = "insert into tblSupplier(Name,Tel ,Address, CreateBy, CreateAt)values (@Name,@Tel,@Address,@CreateBy,GETDATE())";

                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                Database.Cmd.Parameters.AddWithValue("@Name", this.Name);
                Database.Cmd.Parameters.AddWithValue("@Tel", this.Tel);
                Database.Cmd.Parameters.AddWithValue("@Address", this.Address);
                Database.Cmd.Parameters.AddWithValue("@CreateBy", int.Parse(User.UserId)); // Ensure User.UserId is parsed to int

                this.RowEffected = Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for INSERT

                if (this.RowEffected > 0)
                {
                    MessageBox.Show("Supplier saved successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error Create Supplier : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        // Method to delete a supplier by ID
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
                    this.sql = "Delete from tblSupplier where Id=@Id";
                    Database.Cmd = new SqlCommand(this.sql, Database.Con);
                    Database.Cmd.Parameters.AddWithValue("@Id", this.Id);
                    this.RowEffected = Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for DELETE

                    if (RowEffected > 0)
                    {
                        MessageBox.Show("Delete item Successfully", "Delete", MessageBoxButtons.OK);
                        dg.Rows.Remove(DGV);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Delete Supplier : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        // Method to update a supplier by ID
        public override void UpdateById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open for the entire Update operation
                DGV = new DataGridViewRow(); // Reinitialize DGV for clarity
                DGV = dg.SelectedRows[0];
                this.Id = int.Parse(DGV.Cells[0].Value.ToString());

                // Perform duplication checks if needed before update
                // Re-open connection after IsCheckDouplicated closes it
                if (IsCheckDouplicated("Name", this.Name, "Name") == false)
                {
                    return;
                }
                Database.ConnectionDB();
                if (IsCheckDouplicated("Tel", this.Tel, "Tel") == false)
                {
                    return;
                }
                Database.ConnectionDB();

                this.sql = "UPDATE tblSupplier SET " +
                            "Name = @Name ," +
                            "Tel = @Tel," +
                            "Address = @Address," +
                            " UpdateBy = @UpdateBy," +
                            " UpdateAt = GETDATE() " +
                            "WHERE Id = @Id";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                Database.Cmd.Parameters.AddWithValue("@Name", this.Name);
                Database.Cmd.Parameters.AddWithValue("@Tel", this.Tel);
                Database.Cmd.Parameters.AddWithValue("@Address", this.Address);
                Database.Cmd.Parameters.AddWithValue("@UpdateBy", int.Parse(User.UserId)); // Ensure User.UserId is parsed to int
                Database.Cmd.Parameters.AddWithValue("@Id", this.Id);

                this.RowEffected = Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for UPDATE

                if (this.RowEffected > 0)
                {
                    MessageBox.Show("Supplier Update successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error Update Supplier : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        // Method to load data into DataGridView
        public override void LoadingDataToDataGridView(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select top 10 Id,Name,Tel,Address,CreateBy ,CreateAt from tblSupplier order by Id asc";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                // Removed Database.Cmd.ExecuteNonQuery(); as it's not needed for SELECT with SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.Name = r["Name"].ToString();
                    this.Tel = long.Parse(r["Tel"].ToString());
                    this.Address = r["Address"].ToString();

                    object[] row = {
                        this.Id,
                        this.Name,
                        this.Tel,
                        this.Address
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplier: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        // Method to transfer selected DataGridView row data to controls
        public void TransferDataToControll(DataGridView dg, TextBox txtNameSpp, TextBox txtTel, TextBox txtAddress)
        {
            // This method does not interact with the database, so no connection management needed.
            DGV = new DataGridViewRow();
            DGV = dg.SelectedRows[0];
            txtNameSpp.Text = DGV.Cells[1].Value.ToString();
            txtTel.Text = DGV.Cells[2].Value.ToString();
            txtAddress.Text = DGV.Cells[3].Value.ToString();
        }

        // Method to search suppliers by ID (or Name in this case)
        public override void SearchById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from tblSupplier where Name like '%' + @Name + '%' ";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Name", this.Name);

                // Removed Database.Cmd.ExecuteNonQuery(); as it's not needed for SELECT with SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.Name = r["Name"].ToString();
                    this.Tel = long.Parse(r["Tel"].ToString());
                    this.Address = r["Address"].ToString();

                    object[] row = {
                        this.Id,
                        this.Name,
                        this.Tel,
                        this.Address
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Search Supplier : {ex.Message}"); // Corrected message for clarity
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }
    }
}
