using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos_Final.Models;
using Pos_Final.views.SaleDetial;
using Pos_Final.views.Customers;
using Pos_Final.views.Products;
using Pos_Final.views.RoleUser;
using Pos_Final.views.Suppliers;
using Pos_Final.views.UserMt;
using Pos_Final.views.UserRoles;
using Pos_Final.views.Sales;
using Pos_System.models;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using Pos_Final.views.Report;
using System.Runtime.InteropServices;
using Pos_Final.views.Home;


namespace Pos_Final.views.users
{
    public partial class FormMain : Form
    {
        internal string toolStripStatusUsername;
        [DllImport("user32.dll",CharSet = CharSet.Auto)]
         public static extern bool ReleaseCapture();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public FormMain()
        {
            InitializeComponent();
         
          

        }
        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {
            
           
        }
        public void RefreshForm()
        {
            if (Mainpanel.Controls.Count > 0)
            {
                // Get the current control
                Control currentControl = Mainpanel.Controls[0];

                // Save the type of the current form
                Type currentFormType = currentControl.GetType();

                // Remove the old form
                Mainpanel.Controls.Clear();

                // Create a new instance of the same form
                Form refreshedForm = (Form)Activator.CreateInstance(currentFormType);
                refreshedForm.TopLevel = false;
                refreshedForm.FormBorderStyle = FormBorderStyle.None;
                refreshedForm.Dock = DockStyle.Fill;

                // Add the refreshed form to the panel
                Mainpanel.Controls.Add(refreshedForm);
                refreshedForm.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                User userOnLoad = new User();
                int totalUsersOnLoad = userOnLoad.GetTotalUserCount();
                lblAllUser.Text = $"{totalUsersOnLoad}";

                AddStock addStock = new AddStock();
                int totalStockOnLoad = addStock.GetTotalStockCount();
                lblAllStock.Text = $"{totalStockOnLoad}";


                Product product = new Product();    
                int totalProductsOnLoad = product.GetTotalProductCount();
                lblAllPt.Text = $"{totalProductsOnLoad}";


                Sale sale = new Sale();
                decimal totalSalesOnLoad = sale.GetTotalSaleAmount();
                lblAllSale.Text = " " + totalSalesOnLoad.ToString("$##,##0.00");

                Refresh();
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load total : {ex.Message}");
            }
        }

        private void btnUserRole_Click(object sender, EventArgs e)
        {
            // Create an instance of the UserRoleForm
            UserRoleForm userrole = new UserRoleForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None // Remove the form border
            };

        
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(userrole);

          
            userrole.Dock = DockStyle.Fill;
            RefreshForm();
            // Show the form
            userrole.Show();

        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            // Create an instance of the UserRoleForm
            RoleForm role = new RoleForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None // Remove the form border
            };

            // Clear any existing controls in the panel (optional)
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(role);

            // Set the form's Dock property to fill the panel (optional)
            role.Dock = DockStyle.Fill;
            RefreshForm();
            // Show the form
            role.Show();
            

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            // Create an instance of the UserRoleForm
            ProductForm product = new ProductForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None // Remove the form border
            };

            // Clear any existing controls in the panel (optional)
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(product);

            // Set the form's Dock property to fill the panel (optional)
            product.Dock = DockStyle.Fill;
            RefreshForm();
            // Show the form
            product.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            // Create an instance of the UserRoleForm
            CategoryForm category = new CategoryForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None // Remove the form border
            };

            // Clear any existing controls in the panel (optional)
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(category);

            // Set the form's Dock property to fill the panel (optional)
            category.Dock = DockStyle.Fill;
            RefreshForm();
            // Show the form
            category.Show();

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm supplier = new SupplierForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None // Remove the form border
            };

            // Clear any existing controls in the panel (optional)
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(supplier);

            // Set the form's Dock property to fill the panel (optional)
            supplier.Dock = DockStyle.Fill;
            RefreshForm();
            // Show the form
            supplier.Show();


        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None // Remove the form border
            };

            // Clear any existing controls in the panel (optional)
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(sale);

            // Set the form's Dock property to fill the panel (optional)
            sale.Dock = DockStyle.Fill;
            RefreshForm();
            // Show the form
            sale.Show();
        }

        private void btnSaleDetail_Click(object sender, EventArgs e)
        {
            SaleDetailForm saleDetail = new SaleDetailForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None// Remove the form border
               

            };

            // Clear any existing controls in the panel (optional)
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(saleDetail);

            // Set the form's Dock property to fill the panel (optional)
            saleDetail.Dock = DockStyle.Fill;
            RefreshForm();
            // Show the form
            saleDetail.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customer= new CustomerForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None // Remove the form border
            };

            // Clear any existing controls in the panel (optional)
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(customer);

            // Set the form's Dock property to fill the panel (optional)
            customer.Dock = DockStyle.Fill;
            RefreshForm();
            // Show the form
            customer.Show();
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            HomeForm home = new HomeForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None // Remove the form border
            };

            // Clear any existing controls in the panel (optional)
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(home);

            // Set the form's Dock property to fill the panel (optional)
            home.Dock = DockStyle.Fill;
            RefreshForm();
            // Show the form
            home.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void btnAllUser_Click(object sender, EventArgs e)
        {
            // Create an instance of the UserRoleForm
            UserForm user = new UserForm
            {
                TopLevel = false, // Ensure the form is not top-level
                FormBorderStyle = FormBorderStyle.None // Remove the form border
            };

            // Clear any existing controls in the panel (optional)
            Mainpanel.Controls.Clear();

            // Add the form to the panel's controls
            Mainpanel.Controls.Add(user);

            // Set the form's Dock property to fill the panel (optional)
            user.Dock = DockStyle.Fill;

            // Show the form
            user.Show();
            RefreshForm();

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxUserName_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusUser_Click(object sender, EventArgs e)
        {

        }

        private void roundControl1_Load(object sender, EventArgs e)
        {

        }

        private void Mainpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void roundControl2_Load(object sender, EventArgs e)
        {

        }

        private void Toppanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult check =  MessageBox.Show("Are you sure you want to sign out?", "Sign Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LogInForm loginForm = new LogInForm();
                loginForm.Show();
                
            }
            this.Hide();

        }

        private void roundControl3_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
      

        private void lblAllUser_Click(object sender, EventArgs e)
        {
            

        }

        private void lblAllStock_Click(object sender, EventArgs e)
        {

        }

        private void lblAllPt_Click(object sender, EventArgs e)
        {

        }

        private void lblAllSale_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e) 
        {
             
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadToChart(dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }
        

        public void LoadToChart(DateTime fromDate, DateTime toDate)
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=POS_DB;User ID=sa;Password=123;Encrypt=False";

            try
            {
                // ===== Reset Chart =====
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.ChartAreas.Clear();
                chart1.Legends.Clear();

                // ===== Title =====
                Title chartTitle = chart1.Titles.Add("📊 POS Dashboard Overview");
                chartTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                chartTitle.ForeColor = Color.FromArgb(45, 45, 45);
                chartTitle.Alignment = ContentAlignment.TopCenter;

                // ===== Legend =====
                Legend legend = new Legend("MainLegend")
                {
                    Docking = Docking.Bottom,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Alignment = StringAlignment.Center,
                    IsTextAutoFit = true,
                    BorderColor = Color.LightGray,
                    BorderWidth = 1
                };
                chart1.Legends.Add(legend);

                // ===== Chart Areas =====
                ChartArea area1 = CreateStyledChartArea("CostProfitArea", 0, 0, 70, 60, "Product", "Amount ($)"); // bigger
                ChartArea area2 = CreateStyledChartArea("PieArea", 70, 0, 30, 60, "", ""); // Pie
                ChartArea area3 = CreateStyledChartArea("BarArea", 0, 60, 50, 40, "Customer", "Sales"); // smaller
                ChartArea area4 = CreateStyledChartArea("CategoryArea", 50, 60, 50, 40, "Category", "Sales"); // Column chart

                chart1.ChartAreas.Add(area1);
                chart1.ChartAreas.Add(area2);
                chart1.ChartAreas.Add(area3);
                chart1.ChartAreas.Add(area4);

                // ===== Color Palette =====
                Color[] palette = { Color.SteelBlue, Color.MediumSeaGreen, Color.Orange, Color.MediumPurple, Color.IndianRed, Color.Goldenrod };
                int colorIndex = 0;

                // ===== Chart 1: Original Price & Profit =====
                string sqlPriceProfit = $@"
            SELECT 
                p.ProductName,
                SUM(sd.Qty * sd.Price) AS TotalPrice,
                SUM(sd.Qty * sd.Price * 0.2) AS TotalProfit
            FROM tblSaleDetail sd
            JOIN tblProduct p ON sd.ProductId = p.Id
            JOIN tblSale s ON sd.SaleId = s.Id
            WHERE CAST(s.SaleDate AS DATE) BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'
            GROUP BY p.ProductName
            ORDER BY TotalPrice DESC";

                FillSeries(chart1, "Original Price", sqlPriceProfit, "ProductName", "TotalPrice",
                           SeriesChartType.Line, "CostProfitArea", palette[colorIndex++]);

                FillSeries(chart1, "Profit", sqlPriceProfit, "ProductName", "TotalProfit",
                           SeriesChartType.Line, "CostProfitArea", palette[colorIndex++]);

                chart1.Series["Original Price"].BorderWidth = 3;
                chart1.Series["Original Price"].MarkerStyle = MarkerStyle.Circle;
                chart1.Series["Original Price"].MarkerSize = 7;
                chart1.Series["Original Price"].IsValueShownAsLabel = true;

                chart1.Series["Profit"].BorderWidth = 3;
                chart1.Series["Profit"].MarkerStyle = MarkerStyle.Diamond;
                chart1.Series["Profit"].MarkerSize = 7;
                chart1.Series["Profit"].IsValueShownAsLabel = true;

                // ===== Pie Chart: Top Products =====
                string sqlTopProducts = $@"
            SELECT TOP 5 p.ProductName, SUM(sd.Qty) AS TotalQuantitySold
            FROM tblSaleDetail sd
            JOIN tblProduct p ON sd.ProductId = p.Id
            JOIN tblSale s ON sd.SaleId = s.Id
            WHERE CAST(s.SaleDate AS DATE) BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'
            GROUP BY p.ProductName
            ORDER BY TotalQuantitySold DESC";

                FillSeries(chart1, "Top Products", sqlTopProducts, "ProductName", "TotalQuantitySold",
                           SeriesChartType.Pie, "PieArea", palette[colorIndex++]);

                chart1.Series["Top Products"]["PieLabelStyle"] = "Outside";
                chart1.Series["Top Products"]["PieLineColor"] = "Gray";
                chart1.Series["Top Products"]["PieDrawingStyle"] = "Concave";
                chart1.Series["Top Products"].Font = new Font("Segoe UI", 10, FontStyle.Bold);

                foreach (DataPoint p in chart1.Series["Top Products"].Points)
                    p["Exploded"] = "true";

                // ===== Bar Chart: Customer Sales =====
                string sqlCustomerSales = $@"
            SELECT TOP 5 c.CustomerName, SUM(s.TotalAmount) AS TotalSales
            FROM tblSale s
            JOIN tblCustomer c ON s.CustomerId = c.Id
            WHERE CAST(s.SaleDate AS DATE) BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'
            GROUP BY c.CustomerName
            ORDER BY TotalSales DESC";

                FillSeries(chart1, "Customer Sales", sqlCustomerSales, "CustomerName", "TotalSales",
                           SeriesChartType.Bar, "BarArea", palette[colorIndex++]);

                chart1.Series["Customer Sales"].IsValueShownAsLabel = true;
                chart1.Series["Customer Sales"].LabelFormat = "C0";
                chart1.Series["Customer Sales"].Font = new Font("Segoe UI", 9, FontStyle.Bold);

                // ===== Column Chart: Sales by Category =====
                string sqlCategorySales = $@"
            SELECT c.CategoryName, SUM(sd.Qty * sd.Price) AS TotalCategorySales
            FROM tblSaleDetail sd
            JOIN tblProduct p ON sd.ProductId = p.Id
            JOIN tblCategory c ON p.CategoryId = c.Id
            JOIN tblSale s ON sd.SaleId = s.Id
            WHERE CAST(s.SaleDate AS DATE) BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'
            GROUP BY c.CategoryName
            ORDER BY TotalCategorySales DESC";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sqlCategorySales, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);

                    Series categorySeries = new Series("Sales by Category")
                    {
                        ChartType = SeriesChartType.Column,
                        ChartArea = "CategoryArea",
                        IsValueShownAsLabel = true,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold)
                    };

                    Color[] paletteCat = { Color.SteelBlue, Color.MediumSeaGreen, Color.Orange, Color.MediumPurple, Color.IndianRed, Color.Goldenrod };
                    int colorIndexCat = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        int pointIndex = categorySeries.Points.AddXY(row["CategoryName"].ToString(), Convert.ToDouble(row["TotalCategorySales"]));
                        categorySeries.Points[pointIndex].Color = paletteCat[colorIndexCat % paletteCat.Length];
                        categorySeries.Points[pointIndex].LabelForeColor = Color.Black;
                        colorIndexCat++;
                    }

                    ChartArea categoryArea = chart1.ChartAreas["CategoryArea"];
                    categoryArea.AxisX.LabelStyle.Angle = -30;
                    categoryArea.AxisX.Interval = 1;

                    chart1.Series.Add(categorySeries);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message, "Chart Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ChartArea CreateStyledChartArea(string name, float x, float y, float width, float height, string xTitle, string yTitle)
        {
            var area = new ChartArea(name)
            {
                Position = new ElementPosition(x, y, width, height),
                BackColor = Color.White
            };

            // Axis Styling
            area.AxisX.Title = xTitle;
            area.AxisY.Title = yTitle;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.LineColor = Color.DimGray;
            area.AxisY.LineColor = Color.DimGray;

            if (name == "PieArea")
            {
                area.BackColor = Color.Transparent;
                area.Area3DStyle.Enable3D = true;
                area.Area3DStyle.Inclination = 30;
                area.Area3DStyle.Rotation = 20;
            }

            return area;
        }

        private void FillSeries(Chart chart, string seriesName, string sql,
                                string xField, string yField,
                                SeriesChartType chartType, string chartAreaName, Color color)
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=POS_DB;Integrated Security=True";

            if (chart.Series.IndexOf(seriesName) >= 0)
                chart.Series.Remove(chart.Series[seriesName]);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    Series series = new Series(seriesName)
                    {
                        ChartType = chartType,
                        ChartArea = chartAreaName,
                        Color = color,
                        Font = new Font("Segoe UI", 8, FontStyle.Regular),
                        IsValueShownAsLabel = chartType != SeriesChartType.Line,
                        LabelForeColor = Color.Black
                    };

                    if (chartType == SeriesChartType.Pie)
                    {
                        series.LabelFormat = "P0";
                        series.LegendText = "#VALX (#PERCENT)";
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        object xVal = row[xField];
                        object yVal = row[yField];

                        series.XValueType = ChartValueType.String;
                        series.Points.AddXY(xVal.ToString(), Convert.ToDouble(yVal));
                    }

                    chart.Series.Add(series);
                }
            }
        }




        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ProductReport productReport = new ProductReport();
            productReport.Show();   
           
        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            SaleReportForm saleReport = new SaleReportForm();
            saleReport.Show();


        }

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            StockReport stockReport = new StockReport();
            stockReport.Show();
           
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadToChart(dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            LoadToChart(dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }
    }
}
