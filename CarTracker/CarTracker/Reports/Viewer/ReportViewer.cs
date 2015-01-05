using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTracker.Reports.Viewer
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            Design.XtraReport1 objReport = new Design.XtraReport1();
            CarTracker.Domain.ClsLocationDetails objDBDetails = new Domain.ClsLocationDetails();
            objReport.DataSource = objDBDetails.getDataFromDB().Tables[0];
            objReport.DataMember = "Table";

            documentViewer1.PrintingSystem = objReport.PrintingSystem;

            objReport.CreateDocument();
        }
    }
}
