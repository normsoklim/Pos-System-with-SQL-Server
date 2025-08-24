using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_System.models; 
using Pos_Final.views; 

namespace Pos_Final.Models
{
    public class Category : Action 
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
        public string CreateBy { get; set; } 
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public int UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; }

        private string sql = "";
        private int RowEffected;
        private DataGridViewRow DGV; 


        public Category()
        {

        }
        public Category(int id, string categoryName, bool status)
        {
            Id = id;
            CategoryName = categoryName;
            Status = status;
        }

        public bool IsCheckDouplicated(string columnName, object strColumnName, string message)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from tblCategory where " + columnName + " = @CategoryName";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@CategoryName", strColumnName);

                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                if (Database.tbl.Rows.Count > 0)
                {
                    MessageBox.Show("Category " + message + " has been already");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            return true;
        }

        public override void Save()
        {
            try
            {
               
                Database.ConnectionDB();

                if (IsCheckDouplicated("CategoryName", this.CategoryName, "CategoryName") == false)
                {

                    return;
                }

                this.sql = "insert into tblCategory(CategoryName,Status,CreateBy,CreateAt)values(@CategoryName,@Status,@CreateBy,GETDATE());";

                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@CategoryName", this.CategoryName);
                Database.Cmd.Parameters.AddWithValue("@Status", this.Status);
           
                Database.Cmd.Parameters.AddWithValue("@CreateBy", int.Parse(User.UserId));

                this.RowEffected = Database.Cmd.ExecuteNonQuery();

                if (this.RowEffected > 0)
                {
                    MessageBox.Show("Category saved successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving category: " + ex.Message);
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
                this.sql = "select top 10 Id,CategoryName,Status from tblCategory order by Id asc";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);

               
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.CategoryName = r["CategoryName"].ToString();

                    if (r["Status"] != DBNull.Value)
                    {
                        this.Status = Convert.ToBoolean(r["Status"]);
                    }
                    else
                    {
                        this.Status = false;
                    }

                    object[] row = {
                        this.Id,
                        this.CategoryName,
                        this.Status
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error Loading Category :{ex.Message}"); // Corrected message for clarity
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
                    DGV = new DataGridViewRow();
                    DGV = dg.SelectedRows[0];
                    this.Id = int.Parse(DGV.Cells[0].Value.ToString());
                    this.sql = "Delete from tblCategory where Id=@Id";
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
                MessageBox.Show($"Error Delete Category : {ex.Message}"); // Corrected message for clarity
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
                DGV = new DataGridViewRow();
                DGV = dg.SelectedRows[0];
                this.Id = int.Parse(DGV.Cells[0].Value.ToString());
                this.sql = "Update tblCategory set " +
                    "CategoryName=@CategoryName," +
                    "Status=@Status," +
                    "UpdateBy=@UpdateBy," +
                    "UpdateAt=GETDATE()" +
                    "where Id=@Id";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@CategoryName", this.CategoryName);
                Database.Cmd.Parameters.AddWithValue("@Status", this.Status);
                // Assuming User.UserId is a string that can be parsed to int or is directly assignable
                Database.Cmd.Parameters.AddWithValue("@UpdateBy", int.Parse(User.UserId));
                Database.Cmd.Parameters.AddWithValue("@Id", this.Id);
                Database.Cmd.ExecuteNonQuery(); // Correctly using ExecuteNonQuery for UPDATE

                MessageBox.Show("Update Item Successfully ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Update Category : {ex.Message}"); // Corrected message for clarity
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
                this.sql = "select * from tblCategory where CategoryName like '%' + @CategoryName + '%' ";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@CategoryName", this.CategoryName);

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.CategoryName = r["CategoryName"].ToString();
                    // Safer boolean parsing
                    if (r["Status"] != DBNull.Value)
                    {
                        this.Status = Convert.ToBoolean(r["Status"]);
                    }
                    else
                    {
                        this.Status = false;
                    }

                    object[] row = {
                        this.Id,
                        this.CategoryName,
                        this.Status
                    };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Search Category : {ex.Message}"); // Corrected message for clarity
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }
    }
}
