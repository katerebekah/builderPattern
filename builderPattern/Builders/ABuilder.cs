using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderPattern.Builders
{
    public abstract class ABuilder
    {
        public abstract void BuildIntro();
        public abstract void BuildConclusion();
        public abstract void BuildBasicReport();
        public abstract void BuildFullReport(bool hasAccessToPersonalInfo);
    }
}
