using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem5
{
    internal sealed class SchoolReport
    {
        // sealed prevents inheritance, so SchoolReport cannot be a parent for any other class.
        public string ReportTitle { get; set; }

        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }

        public void DisplayReportTitle()
        {
            Console.WriteLine($"Report Title: {ReportTitle}");
        }
    }
}
