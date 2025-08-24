using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Pos_Final.Models;
using Pos_System.models;

namespace Pos_Final.views.Report
{
    public partial class SaleReportForm : Form
    {
        private string sql;

        public double CashRecieve { get; set; }
        public double CashReturn { get; set; }

        public SaleReportForm()
        {
            InitializeComponent();
            
        }

        private void SaleReportForm_Load(object sender, EventArgs e)
        {
            PrintReport(reportViewer1, 15); 
         
            this.reportViewer1.RefreshReport();

        }

        private void PrintReport(ReportViewer reportViewer1, int id)
        {
            Database.ConnectionDB();

            try
            {
                string filePath = Application.StartupPath + @"\Reports\SaleReport.rdlc";
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found: " + filePath);
                    return;
                }

                // Load data
                Database.Cmd = new SqlCommand("SELECT * FROM View_Sale_Report WHERE SaleId = @SaleId", Database.Con);
                Database.Cmd.Parameters.AddWithValue("@SaleId", id);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);

                if (Database.tbl.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for SaleId = " + id);
                    return;
                }

                reportViewer1.Reset(); // Clear old report
                reportViewer1.LocalReport.ReportPath = filePath;
                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("DataSetSaleReport", Database.tbl);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter[] parameters = new ReportParameter[]
                {
                  new ReportParameter("CashRecieve", this.CashRecieve.ToString("N2")),
                  new ReportParameter("CashReturn", this.CashReturn.ToString("N2"))


                };
                reportViewer1.LocalReport.SetParameters(parameters);

                reportViewer1.LocalReport.Refresh(); // important
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Report: {ex.Message}");
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
