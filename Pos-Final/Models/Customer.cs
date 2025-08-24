using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Pos_System.models; // Assuming Database class is here

namespace Pos_Final.Models
{
    internal class Customer : Action // Assuming 'Action' is a base class you have
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public long Tel { get; set; }
        public static string CustomerId { get; set; } // Consider if this should be an instance property or a different type
        public string Address { get; set; }
        private string sql = "";
        private int RowEffected;
        private DataGridViewRow DGV;

        public Customer() { }
        public Customer(int id, string customerName, string gender, long tel, string address)
        {
            Id = id;
            CustomerName = customerName;
            Gender = gender;
            Tel = tel;
            Address = address;
        }

        public bool IsCheckDouplicated(string columnName, object strColumnName, string message)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from tblCustomer where " + columnName + " = @Value"; // Use generic parameter name
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Value", strColumnName); // Pass the value to the generic parameter

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                if (Database.tbl.Rows.Count > 0)
                {
                    MessageBox.Show("Customer " + message + " has been already");
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
                // Perform duplication checks. Each call to IsCheckDouplicated opens and closes the connection.
                // So, we need to re-open the connection before the INSERT statement if the checks pass.
                if (string.IsNullOrWhiteSpace(this.CustomerName) || string.IsNullOrWhiteSpace(this.Gender) || string.IsNullOrWhiteSpace(this.Address))
                {
                    MessageBox.Show("Please fill in all required customer details (Name, Gender, Address).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (IsCheckDouplicated("CustomerName", this.CustomerName, "Name") == false) // Corrected message for clarity
                {
                    return;
                }
                Database.ConnectionDB(); // Re-open connection after first check

                // If Tel is also a unique constraint, you might want to check it too
                // if (IsCheckDouplicated("Tel", this.Tel, "Tel") == false)
                // {
                //     return;
                // }
                // Database.ConnectionDB(); // Re-open connection after second check if uncommented

                this.sql = "INSERT INTO tblCustomer (CustomerName, Gender, Tel, Address) VALUES (@CustomerName, @Gender, @Tel, @Address)";

                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                Database.Cmd.Parameters.AddWithValue("@CustomerName", this.CustomerName);
                Database.Cmd.Parameters.AddWithValue("@Gender", this.Gender);
                Database.Cmd.Parameters.AddWithValue("@Tel", this.Tel);
                Database.Cmd.Parameters.AddWithValue("@Address", this.Address);

                Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for INSERT

                MessageBox.Show("Customer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Improved message
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating customer: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    this.sql = "Delete from tblCustomer where Id=@Id";
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
                MessageBox.Show($"Error Delete Customer : {ex.Message}"); // Corrected message for clarity
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
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select top 10 Id,CustomerName,Gender,Tel,Address from tblCustomer order by Id asc";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                // Removed Database.Cmd.ExecuteNonQuery(); as it's not needed for SELECT with SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.CustomerName = r["CustomerName"].ToString();
                    this.Gender = r["Gender"].ToString();
                    this.Tel = long.Parse(r["Tel"].ToString());
                    this.Address = r["Address"].ToString();

                    object[] row = {
                        this.Id,
                        this.CustomerName,
                        this.Gender,
                        this.Tel,
                        this.Address
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Customer: {ex.Message}");
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
                Database.ConnectionDB(); // Ensure connection is open
                DGV = new DataGridViewRow(); // Reinitialize DGV for clarity
                DGV = dg.SelectedRows[0];
                this.Id = int.Parse(DGV.Cells[0].Value.ToString());
                this.sql = "update tblCustomer set CustomerName =@CustomerName , Gender = @Gender ,Tel = @Tel , Address = @Address where Id = @Id ";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                Database.Cmd.Parameters.AddWithValue("@CustomerName", this.CustomerName);
                Database.Cmd.Parameters.AddWithValue("@Gender", this.Gender);
                Database.Cmd.Parameters.AddWithValue("@Tel", this.Tel);
                Database.Cmd.Parameters.AddWithValue("@Address", this.Address);
                Database.Cmd.Parameters.AddWithValue("@Id", this.Id); // Add Id parameter for WHERE clause

                this.RowEffected = Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for UPDATE

                if (this.RowEffected > 0)
                {
                    MessageBox.Show("Update Item Successfully ");
                }
                else
                {
                    MessageBox.Show("No changes made or customer not found for update.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error Update Customer :{ex.Message}");
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
                this.sql = "select * from tblCustomer where CustomerName like '%' +@CustomerName+ '%' ";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@CustomerName", this.CustomerName);

                // Removed Database.Cmd.ExecuteNonQuery(); as it's not needed for SELECT with SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.CustomerName = r["CustomerName"].ToString();
                    this.Gender = r["Gender"].ToString();
                    this.Tel = long.Parse(r["Tel"].ToString());
                    this.Address = r["Address"].ToString();

                    object[] row = {
                        this.Id,
                        this.CustomerName,
                        this.Gender,
                        this.Tel,
                        this.Address
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Search Customer: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public void TransferDataToControls(DataGridView dg, TextBox txtCustomerName, ComboBox cbGender, TextBox txtTel, TextBox txtAddress)
        {
            // This method does not interact with the database, so no connection management needed.
            DGV = new DataGridViewRow();
            DGV = dg.SelectedRows[0];
            txtCustomerName.Text = DGV.Cells[1].Value.ToString();
            cbGender.Text = DGV.Cells[2].Value.ToString();
            txtTel.Text = DGV.Cells[3].Value.ToString();
            txtAddress.Text = DGV.Cells[4].Value.ToString();
        }
    }
}
