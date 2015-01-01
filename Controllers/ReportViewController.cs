using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RDLCandMVC.Controllers
{
    public class ReportViewController : Controller
    {
        private static readonly SomeReportData[] FakeDatabaseData = new[]
            {
                new SomeReportData { Count = 123, Name = "Foo", SomeDate = DateTime.Now },
                new SomeReportData { Count = 234, Name = "Bar", SomeDate = DateTime.Now },
                new SomeReportData { Count = 345, Name = "Baz", SomeDate = DateTime.Now },
            };

        public ActionResult GenerateReport()
        {
            // Nothing to show yet
            ViewBag.ShowIFrame = false;
            return View();
        }

        [HttpPost]
        public ActionResult GenerateReport(string param1, int param2)
        {
            // Obviously you apply the parameters as predicates and hit the real database
            Session["ReportData"] = FakeDatabaseData;
            ViewBag.ShowIFrame = true;
            return View();
        }
    }

    public class SomeReportData
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public DateTime SomeDate { get; set; }
    }
}
