using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Data;
// Removed System.Web as it's typically not needed for WinForms applications
// using System.Web;
using Pos_System.models;
using Pos_Final.views.users; // Assuming FormMain is in this namespace
using Pos_Final.views.UserMt; // Assuming other related views are here

namespace Pos_Final.Models
{
    internal class User : Action // Assuming 'Action' is a base class you have
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; } = true;
        public DateTime CreateAt { get; set; }
        public int CreateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public int UpdateBy { get; set; }
        public static string UserLogIn { get; set; }
        public static string UserId { get; set; }
        public int RoleId { get; set; }
        public static string RoleName { get; set; }
        public string sql = "";
        private int RowEffected;
        DataGridViewRow DGV; 

        public User() { }

        public User(int id, string name, string password, string gender, string email, bool status)
        {
            Id = id;
            Name = name;
            Password = password;
            Gender = gender;
            Email = email;
            Status = status;
        }

        public void LogIn(Form form)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from View_User_Role where [Name] = @Name and [Password] = @Password and Status = 1";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Name", this.Name);
                Database.Cmd.Parameters.AddWithValue("@Password", this.Password);

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                if (Database.tbl.Rows.Count > 0)
                {
                    FormMain main = new FormMain();
                    User.UserLogIn = Database.tbl.Rows[0]["Name"].ToString();
                    User.UserId = Database.tbl.Rows[0]["Id"].ToString();
                    User.RoleName = Database.tbl.Rows[0]["RoleName"].ToString();
                    // Assuming toolStripStatusUser is accessible and correctly named in FormMain
                    main.toolStripStatusUser.Text = "Welcome 🎉: " + User.UserLogIn;
                    main.Show();
                    form.Hide();
                }
                else
                {
                    MessageBox.Show("UserName and Password is invalid !", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public override void Save()
        {
            SqlTransaction transation = null;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open before starting transaction
                transation = Database.Con.BeginTransaction();

                this.sql = "insert into tblUser " +
                    "(Name,Gender,Password,Email,Status,CreateBy,CreateAt) " +
                    "values (@Name,@Gender,@Password,@Email,@Status,@CreateBy,GETDATE()); " +
                    "select SCOPE_IDENTITY();"; // Use semicolon to separate statements

                Database.Cmd = new SqlCommand(this.sql, Database.Con, transation);

                Database.Cmd.Parameters.AddWithValue("@Name", this.Name);
                Database.Cmd.Parameters.AddWithValue("@Gender", Gender);
                Database.Cmd.Parameters.AddWithValue("@Password", this.Password);
                Database.Cmd.Parameters.AddWithValue("@Email", this.Email);
                Database.Cmd.Parameters.AddWithValue("@Status", this.Status);
                // Ensure UserId is an integer for CreateBy
                Database.Cmd.Parameters.AddWithValue("@CreateBy", int.Parse(User.UserId));

                // Execute first command and get the new user ID (uses ExecuteScalar for single value)
                this.Id = Convert.ToInt32(Database.Cmd.ExecuteScalar());

                // Use to save userrole (uses ExecuteNonQuery for INSERT)
                this.sql = "insert into tblUserRole(UserId,RoleId)values(@UserId,@RoleId)";
                Database.Cmd = new SqlCommand(this.sql, Database.Con, transation);
                Database.Cmd.Parameters.AddWithValue("@UserId", this.Id);
                Database.Cmd.Parameters.AddWithValue("@RoleId", this.RoleId);
                Database.Cmd.ExecuteNonQuery();
                transation.Commit();

                MessageBox.Show("Create User Successfully ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Create User : {ex.Message}");
                transation?.Rollback(); // Rollback if transaction exists
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
                    this.sql = "Delete from tblUser where Id = @Id";
                    Database.Cmd = new SqlCommand(this.sql, Database.Con);
                    Database.Cmd.Parameters.AddWithValue("@Id", this.Id);
                    this.RowEffected = Database.Cmd.ExecuteNonQuery(); // Uses ExecuteNonQuery for DELETE

                    if (RowEffected > 0)
                    {
                        MessageBox.Show("Delete item Successfully", "Delete", MessageBoxButtons.OK);
                        dg.Rows.Remove(DGV);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Delete User : {ex.Message}");
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
                this.sql = "select top 10 * from View_User_Role order by Id asc";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.Name = r["Name"].ToString();
                    this.Gender = r["Gender"].ToString();
                    this.Password = r["Password"].ToString();
                    this.Email = r["Email"].ToString();
                    this.Status = bool.Parse(r["Status"].ToString());
                    string roleName = r["RoleName"].ToString();
                    object[] row = { this.Id, this.Name, this.Gender, this.Password, this.Email, this.Status, roleName };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading User : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public override void UpdateById(DataGridView dg)
        {
            SqlTransaction transation = null;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open before starting transaction
                transation = Database.Con.BeginTransaction();
                DGV = new DataGridViewRow(); // Reinitialize DGV for clarity
                DGV = dg.SelectedRows[0];
                this.Id = int.Parse(DGV.Cells[0].Value.ToString());

                this.sql = "Update tblUser set " +
                    "Name = @Name," +
                    "Gender = @Gender," +
                    "Password = @Password," +
                    "Email = @Email," +
                    "Status = @Status," +
                    "UpdateBy = @UpdateBy," +
                    "UpdateAt = GETDATE() " +
                    "where Id = @Id";
                Database.Cmd = new SqlCommand(this.sql, Database.Con, transation);
                Database.Cmd.Parameters.AddWithValue("@Name", this.Name);
                Database.Cmd.Parameters.AddWithValue("@Gender", Gender);
                Database.Cmd.Parameters.AddWithValue("@Password", this.Password);
                Database.Cmd.Parameters.AddWithValue("@Email", this.Email);
                Database.Cmd.Parameters.AddWithValue("@Status", this.Status);
                // Ensure UserId is an integer for UpdateBy
                Database.Cmd.Parameters.AddWithValue("@UpdateBy", int.Parse(User.UserId));
                Database.Cmd.Parameters.AddWithValue("@Id", this.Id);
                Database.Cmd.ExecuteNonQuery(); // Uses ExecuteNonQuery for UPDATE

                this.sql = "update tblUserRole set RoleId = @RoleId where UserId = @UserId";
                Database.Cmd = new SqlCommand(this.sql, Database.Con, transation);
                Database.Cmd.Parameters.AddWithValue("@RoleId", RoleId);
                Database.Cmd.Parameters.AddWithValue("@UserId", this.Id);

                Database.Cmd.ExecuteNonQuery(); // Uses ExecuteNonQuery for UPDATE
                transation.Commit();
                MessageBox.Show("Update User Successfully ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Update User : {ex.Message}");
                transation?.Rollback(); // Rollback if transaction exists
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public void TransferDataToControls(DataGridView dg, TextBox txtUserName, ComboBox cbGender, TextBox txtPassword, TextBox txtEmail
            , RadioButton rTrue, RadioButton rFasle, ComboBox cboRoleName)
        {
            DGV = new DataGridViewRow(); // Reinitialize DGV for clarity
            DGV = dg.SelectedRows[0];
            txtUserName.Text = DGV.Cells[1].Value.ToString();
            cbGender.Text = DGV.Cells[2].Value.ToString();
            txtPassword.Text = DGV.Cells[3].Value.ToString();
            txtEmail.Text = DGV.Cells[4].Value.ToString();

            if (DGV.Cells[5].Value.ToString().Equals("True"))
            {
                rTrue.Checked = true;
                rFasle.Checked = false; // Ensure the other radio button is unchecked
            }
            else
            {
                rFasle.Checked = true; // Corrected: if not true, then false
                rTrue.Checked = false; // Ensure the other radio button is unchecked
            }
            cboRoleName.Text = DGV.Cells[6].Value.ToString();
        }

        public override void SearchById(DataGridView dg)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select * from View_User_Role where Name like '%' + @Name + '%'";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@Name", this.Name);

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                dg.Rows.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    this.Id = int.Parse(r["Id"].ToString());
                    this.Name = r["Name"].ToString();
                    this.Gender = r["Gender"].ToString();
                    this.Password = r["Password"].ToString();
                    this.Email = r["Email"].ToString();
                    this.Status = bool.Parse(r["Status"].ToString());
                    string roleName = r["RoleName"].ToString();

                    object[] row = { this.Id, this.Name, this.Gender, this.Password, this.Email, this.Status, roleName };
                    dg.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Search User : {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public void SetRoleName(ComboBox cboRoleName)
        {
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select RoleName from tblRole";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                cboRoleName.Items.Clear();
                foreach (DataRow r in Database.tbl.Rows)
                {
                    cboRoleName.Items.Add(r["RoleName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Load RoleName: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
        }

        public int GetRoleId(ComboBox cboRoleName)
        {
            int id = 0;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "select Id from tblRole where RoleName = @RoleName"; // Select Id instead of *
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                Database.Cmd.Parameters.AddWithValue("@RoleName", cboRoleName.Text.Trim());

                // For SELECT statements, use SqlDataAdapter.Fill()
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                if (Database.tbl.Rows.Count > 0)
                {
                    id = int.Parse(Database.tbl.Rows[0]["Id"].ToString()); // Access by column name for clarity
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

        public int GetTotalUserCount()
        {
            int count = 0;
            try
            {
                Database.ConnectionDB(); // Ensure connection is open
                this.sql = "SELECT COUNT(Id) FROM tblUser";
                Database.Cmd = new SqlCommand(this.sql, Database.Con);
                count = (int)Database.Cmd.ExecuteScalar(); // Uses ExecuteScalar for single value aggregate
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting user count: {ex.Message}");
            }
            finally
            {
                Database.CloseConnectionDB(); // Ensure connection is closed
            }
            return count;
        }
    }
}
