using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using builderPattern.Products;

namespace builderPattern.Builders
{
    public class ReportBuilder : ABuilder
    {
        public Report report;

        public ReportBuilder(Report _report)
        {
            report = _report;
        }

        public override void BuildIntro()
        {
            report.AddIntro("REPORT: CLASS PROGRESS");
        }
        public override void BuildConclusion()
        {
            report.AddConclusion("END");
        }
        public void BuildPersonalInfo(bool hasAccess)
        {
            report.AddPersonalInfo(hasAccess, "Personal Info: \r\n Beginning Class \r\n Number of Students: 4 \r\n Student Names: Bob, Sheila, Harry, Susan");
        }
        public void BuildCurrentProgress()
        {
            report.AddCurrentProgress("Assignment 4 of 9 completed.");
        }


        public override void BuildBasicReport()
        {
            BuildIntro();
            BuildConclusion();
        }
        public override void BuildFullReport(bool hasAccessToPersonalInfo)
        {
            BuildIntro();
            BuildPersonalInfo(hasAccessToPersonalInfo);
            BuildCurrentProgress();
            BuildConclusion();
        }
    }
}
