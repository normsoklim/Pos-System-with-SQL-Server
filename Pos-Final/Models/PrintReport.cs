using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using Pos_System.models;
using Warning = Microsoft.Reporting.WinForms.Warning;

namespace Pos_Final.Models
{
    public class PrintReport
    {
        public int m_currentPageIndex;
        public IList<Stream> m_streams;

        public void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
            {
                throw new Exception("Error: No stream to print. Call Export() first.");
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Invalid printer settings.");
            }

            m_currentPageIndex = 0;
            printDoc.Print();


        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);

            ev.Graphics.DrawImage(pageImage, ev.PageBounds);
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);

        }
        private Stream CreateScreen(string name, string fileNameExtension,
            Encoding encoding, string mimeType, bool willSeek
            )
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;

        }
        public void Export(LocalReport report)
        {
                    string deviceInfo =
             "<DeviceInfo>" +
             "  <OutputFormat>EMF</OutputFormat>" +
             "  <PageWidth>7.2cm</PageWidth>" +
             "  <PageHeight>15cm</PageHeight>" +
             "  <MarginTop>1cm</MarginTop>" +
             "  <MarginRight>0.5cm</MarginRight>" +
             "  <MarginLeft>0.5cm</MarginLeft>" +
             "  <MarginBottom>1cm</MarginBottom>" +
             "</DeviceInfo>";


            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateScreen, out warnings);

            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }


        public static void PrintReportViewer(ReportViewer reportViewer1, string fileReport ,string sql,
            string dataSetName)
        {

            try
            {
                string filePath = Application.StartupPath + @"\Reports\" + fileReport + ".rdlc";
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found:" + filePath);
                }
                Database.Cmd = new SqlCommand(sql, Database.Con);
                Database.da = new SqlDataAdapter(Database.Cmd);
                Database.tbl = new DataTable();
                Database.da.Fill(Database.tbl);
                reportViewer1.LocalReport.ReportPath = filePath;
                ReportDataSource rds = new ReportDataSource(dataSetName, Database.tbl);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
        
    }
}
