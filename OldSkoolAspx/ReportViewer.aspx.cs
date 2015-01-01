using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

namespace RDLCandMVC.OldSkoolAspx
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var reportDataSource = new ReportDataSource
                {
                    // Must match the DataSource in the RDLC
                    Name = "SomeReportDataSet",
                    Value = Session["ReportData"]
                };
                ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
                ReportViewer1.DataBind();
            }
        }
    }
}