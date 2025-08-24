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

namespace Pos_Final.views.Report
{
    public partial class ProductReport : Form
    {
        public ProductReport()
        {
            InitializeComponent();
        }

        private void ProductReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
          
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            Models.PrintReport.PrintReportViewer(reportViewer1, "ProductReport","select * from tblProduct","DataSetProduct");
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
