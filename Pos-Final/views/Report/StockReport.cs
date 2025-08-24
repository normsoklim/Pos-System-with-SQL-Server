using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_Final.views.Report
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            Models.PrintReport.PrintReportViewer(reportViewer1, "StockReport", "select * from View_AddStock", "DataSetStock");
        }
    }
}
