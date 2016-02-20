using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderPattern.Builders
{
    class ReportBuilder : ABuilder
    {
        public override string BuildIntro()
        {
            return "";
        }
        public override string BuildConclusion()
        {
            return "";
        }
        public override string BuildBasicReport()
        {
            return "";
        }
        public override string BuildFullReportWithAccess()
        {
            return "";
        }
        public override string BuildFullReportWithoutAccess()
        {
            return "";
        }
    }
}
