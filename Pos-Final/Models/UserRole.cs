using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Pos_System.models;
using Pos_Final.Models; // For User.UserId

namespace Pos_Final.Models
{
    public class UserRole : Action
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public int UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; } = DateTime.Now;
        public string Name { get; set; } // This property seems to be for display purposes (UserName)
        public string RoleName { get; set; } // This property seems to be for display purposes

        private string sql = "";
        private int RowEffected;
        private DataGridViewRow DGV;

        public UserRole() { }

        public UserRole(int id, int userId, int roleId)
        {
            Id = id;
            UserId = userId;
            RoleId = roleId;
        }

        public override void Save()
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open

                // SQL to insert and then get the new ID using SCOPE_IDENTITY()
                this.sql = @"INSERT INTO tblUserRole
                    (UserId, RoleId, CreateBy, CreateAt, UpdateBy, UpdateAt)
                    VALUES (@UserId, @RoleId, @CreateBy, GETDATE(), @UpdateBy, GETDATE());
                    SELECT SCOPE_IDENTITY();"; // Added SELECT SCOPE_IDENTITY()

                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@UserId", this.UserId);
                Database.Cmd.Parameters.AddWithValue("@RoleId", this.RoleId);
                // Ensure User.UserId is parsed to int for CreateBy and UpdateBy
                Database.Cmd.Parameters.AddWithValue("@CreateBy", int.Parse(User.UserId));
                Database.Cmd.Parameters.AddWithValue("@UpdateBy", int.Parse(User.UserId)); // Assuming UpdateBy is also current user

                // ExecuteScalar is used when you expect a single value back (like SCOPE_IDENTITY())
                this.Id = Convert.ToInt32(Database.Cmd.ExecuteScalar());

                // No need for a separate ExecuteNonQuery here, as ExecuteScalar already executed the INSERT
                // this.RowEffected = Database.Cmd.ExecuteNonQuery(); 

                MessageBox.Show("User Role saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user role: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public int GetRoleId(ComboBox cboRole)
        {
            int id = 0;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select Id from tblRole where RoleName=@RoleName"; // Select Id
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@RoleName", cboRole.Text.Trim());

                // No need for ExecuteNonQuery here, as you are retrieving data
                // Database.Cmd.ExecuteNonQuery();
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                if (Database.tbl.Rows.Count > 0)
                {
                    id = Convert.ToInt32(Database.tbl.Rows[0]["Id"]); // Access by column name
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error GetRoleId : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
            return id;
        }

        public int GetUserId(ComboBox cboUser)
        {
            int id = 0;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "SELECT Id FROM tblUser WHERE Name = @Name"; // Select Id
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Name", cboUser.Text.Trim());

                // No need for ExecuteNonQuery here, as you are retrieving data
                // Database.Cmd.ExecuteNonQuery();
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                if (Database.tbl.Rows.Count > 0)
                {
                    id = Convert.ToInt32(Database.tbl.Rows[0]["Id"]); // Access by column name
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error GetUserId : {ex.Message}"); // Corrected message for clarity
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
            return id;
        }

        public void SetRoleName(ComboBox cboRole)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "SELECT RoleName FROM tblRole";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                cboRole.Items.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    cboRole.Items.Add(r["RoleName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public void SetUserName(ComboBox cboUser)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "SELECT Name FROM tblUser";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                cboUser.Items.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    cboUser.Items.Add(r["Name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}"); // Corrected message for clarity
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public void TransferDataToControls(DataGridView dg, ComboBox cboUser, ComboBox cboRole)
        {
            try
            {
                // This method does not interact with the database, so no connection management needed.
                if (dg.SelectedRows.Count > 0)
                {
                    DGV = dg.SelectedRows[0];
                    this.Id = int.Parse(DGV.Cells[0].Value.ToString());
                    cboUser.Text = DGV.Cells[1].Value.ToString();
                    cboRole.Text = DGV.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error transferring data: {ex.Message}");
            }
        }

        public override void LoadingDataToDataGridView(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from View_UserRole order by Id asc";

                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = Convert.ToInt32(r["Id"]);
                    string userName = r["Name"].ToString();
                    string roleName = r["RoleName"].ToString();

                    object[] row = {
                        this.Id,
                        userName,
                        roleName
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user roles: {ex.Message}");
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
                    this.sql = "Delete from tblUserRole where Id=@Id";
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
                MessageBox.Show($"Error Delete User Role : {ex.Message}"); // Corrected message for clarity
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
                this.sql = "Update tblUserRole set " +
                    "UserId=@UserId," +
                    "RoleId =@RoleId," +
                    "UpdateBy=@UpdateBy," +
                    "UpdateAt=GETDATE()" +
                    "where Id=@Id";

                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@UserId", this.UserId);
                Database.Cmd.Parameters.AddWithValue("@RoleId", this.RoleId);
                Database.Cmd.Parameters.AddWithValue("@UpdateBy", int.Parse(User.UserId)); // Ensure User.UserId is parsed to int
                Database.Cmd.Parameters.AddWithValue("@Id", this.Id);

                // For UPDATE, we use ExecuteNonQuery, not ExecuteScalar.
                // The 'Id' property should already be set from the selected row, not from ExecuteScalar.
                this.RowEffected = Database.Cmd.ExecuteNonQuery();

                if (this.RowEffected > 0)
                {
                    MessageBox.Show("User role updated successfully"); // Changed message for clarity
                }
                else
                {
                    MessageBox.Show("No changes made or user role not found for update.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user role: {ex.Message}");
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
                this.sql = "select * from View_UserRole where Name like '%' +@Name+ '%' ";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Name", this.Name);

                // No need for ExecuteNonQuery here, as you are retrieving data
                // Database.Cmd.ExecuteNonQuery();
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    string userName = r["Name"].ToString();
                    string roleName = r["RoleName"].ToString();

                    object[] row = { this.Id, userName, roleName };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Search UserRole : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }
    }
}
