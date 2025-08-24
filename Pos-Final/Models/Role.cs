using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_Final.views;
using Pos_System.models;

namespace Pos_Final.Models
{
    public class Role : Action
    {
        // Properties
        public int Id { get; set; }
        public string RoleName { get; set; }
        public bool Status { get; set; } = true;
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public string UpdateBy { get; set; }
        public static string RoleId { get; set; } // Consider if this should be an instance property or a different type

        private string sql = "";
        private int RowEffected;
        private DataGridViewRow DGV; // This should ideally be a local variable in methods where it's used

        // Constructors
        public Role() { }

        public Role(int id, string name, bool status)
        {
            Id = id;
            RoleName = name;
            Status = status;
        }

        // Method to add a new role
        public override void Save()
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "insert into tblRole(RoleName,Status , CreateBy, CreateAt)values (@RoleName,@Status,@CreateBy,GETDATE())";

                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                Database.Cmd.Parameters.AddWithValue("@RoleName", this.RoleName);
                Database.Cmd.Parameters.AddWithValue("@Status", this.Status);
                Database.Cmd.Parameters.AddWithValue("@CreateBy", User.UserId); // Assuming User.UserId is a string

                this.RowEffected = Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for INSERT

                if (this.RowEffected > 0)
                {
                    MessageBox.Show("Role saved successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error Create Role :{ex.Message}");
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
                this.sql = "select top 10 Id,RoleName,Status,CreateBy ,CreateAt from tblRole order by Id asc";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                // Removed Database.Cmd.ExecuteNonQuery(); as it's not needed for SELECT with SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.RoleName = r["RoleName"].ToString();
                    this.Status = r["Status"] != DBNull.Value && Convert.ToBoolean(r["Status"]);
                    object[] row = {
                        this.Id,
                        this.RoleName,
                        this.Status
                    };
                    dg.Rows.Add(row);
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

        // Method to delete a role by ID
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
                    this.sql = "Delete from tblRole where Id=@Id";
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
                MessageBox.Show($"Error Delete Role : {ex.Message}"); // Corrected message for clarity
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        // Method to update a role by ID
        public override void UpdateById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                DGV = new DataGridViewRow(); // Reinitialize DGV for clarity
                DGV = dg.SelectedRows[0];
                this.Id = int.Parse(DGV.Cells[0].Value.ToString());
                this.sql = "UPDATE tblRole SET " +
                            "RoleName = @RoleName ," +
                            "Status = @Status," +
                            " UpdateBy = @UpdateBy," +
                            " UpdateAt = GETDATE() " +
                            "WHERE Id = @Id";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@RoleName", this.RoleName);
                Database.Cmd.Parameters.AddWithValue("@Status", this.Status);
                Database.Cmd.Parameters.AddWithValue("@UpdateBy", User.UserId); // Assuming User.UserId is a string
                Database.Cmd.Parameters.AddWithValue("@Id", this.Id);

                Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for UPDATE

                MessageBox.Show("Update Item Successfully ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating role: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public void TransferDataToControll(DataGridView dg, TextBox txtRoleName, RadioButton rTrue, RadioButton rFasle)
        {
            DGV = new DataGridViewRow();
            DGV = dg.SelectedRows[0];
            txtRoleName.Text = DGV.Cells[1].Value.ToString();

            // Handle null and proper boolean conversion
            if (DGV.Cells[2].Value != null)
            {
                bool statusValue;
                if (bool.TryParse(DGV.Cells[2].Value.ToString(), out statusValue))
                {
                    rTrue.Checked = statusValue;
                    rFasle.Checked = !statusValue;
                }
                else
                {
                    // Handle case where value isn't a proper boolean
                    rTrue.Checked = false;
                    rFasle.Checked = true;
                }
            }
            else
            {
                rTrue.Checked = false;
                rFasle.Checked = true;
            }
        }

        public override void SearchById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from tblRole where RoleName like '%' + @RoleName + '%' ";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@RoleName", this.RoleName);

                // Removed Database.Cmd.ExecuteNonQuery(); as it's not needed for SELECT with SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.RoleName = r["RoleName"].ToString();
                    this.Status = Convert.ToBoolean(r["Status"]);
                    // The commented out lines below are not part of the DataGridView row, so they are kept commented.
                    //this.CreateBy = r["CreateBy"].ToString();
                    //this.CreateAt = Convert.ToDateTime(r["CreateAt"]);
                    //this.UpdateBy = r["UpdateBy"].ToString();
                    //this.UpdateAt = Convert.ToDateTime(r["UpdateAt"]);
                    object[] row = {
                        this.Id,
                        this.RoleName,
                        this.Status
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Search Role : {ex.Message}"); // Corrected message for clarity
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }
    }
}
