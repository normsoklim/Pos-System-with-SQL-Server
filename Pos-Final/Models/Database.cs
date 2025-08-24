using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace Pos_System.models
{
    public static class Database
    {
        public static SqlConnection Con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=POS_DB;
User ID=sa;Password=123;Encrypt=False");
        public static SqlCommand Cmd = null;
        public static SqlDataAdapter da = null;
        public static DataTable tbl = null;

        public static void ConnectionDB()
        {
            try
            {
                if(Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Connection to Database :{ex.Message}");
            }
        }
        public static void CloseConnectionDB()
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error closing database connection: {ex.Message}");
            }
        }
    }
}
