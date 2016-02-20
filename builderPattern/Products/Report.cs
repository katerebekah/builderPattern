using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderPattern.Products
{
    class Report
    {
        private string Intro
        {
            get { return "Welcome to the report."; }
        }
        private string PersonalInfo
        {
            get { return "Personal Info: /n Beginning Class /n Number of Students: 4 /n Student Names: Bob, Sheila, Harry, Susan"}
        }
        private string CurrentProgress
        {
            get { return "Assignment 4 of 9 completed."; }
        }
        private string FuturePlans
        {
            get { return "This class plans to finish assignments and build a rocket ship."; }
        }
        private string Conclusion {
            get { return "This is the end of the report. Goodbye."; }
        }

        public string GetIntro()
        {
            return Intro;
        }

        public string GetPersonalInfo (bool hasAccess)
        {
            if (hasAccess)
            {
                return PersonalInfo; 
            }
            return "";
        }

        public string GetCurrentProgress ()
        {
            return CurrentProgress;
        }

        public string GetFuturePlans()
        {
            return FuturePlans;
        }

        public string GetConclusion()
        {
            return Conclusion;
        }
    }
}
