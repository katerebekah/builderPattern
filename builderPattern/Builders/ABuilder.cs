using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderPattern.Builders
{
    abstract class ABuilder
    {
        public abstract string BuildIntro();
        public abstract string BuildConclusion();
        public abstract string BuildBasicReport();
        public abstract string BuildFullReportWithAccess();
        public abstract string BuildFullReportWithoutAccess();
    }
}
