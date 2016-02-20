using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderPattern.Products
{
    public class Report
    {
        private string Intro { get; set; }
        private string PersonalInfo { get; set; }
        private string CurrentProgress { get; set;}
        private string Conclusion { get; set; }

        private List<string> FullReport { get; set; }

        public void AddIntro(string intro)
        {
            Intro = intro;
        }

        public void AddPersonalInfo (bool hasAccess, string personalInfo)
        {
            if (hasAccess)
            {
                PersonalInfo = personalInfo; 
            }
        }

        public void AddCurrentProgress (string currentProgress)
        {
            CurrentProgress = currentProgress;
        }
        
        public void AddConclusion(string conclusion)
        {
            Conclusion = conclusion;
        }

        public string BuildReport()
        {
            FullReport = new List<string>();
            if (Intro != null)
            {
                FullReport.Add(Intro);
            }
            if (PersonalInfo != null)
            {
                FullReport.Add(PersonalInfo);
            }
            if (CurrentProgress != null)
            {
                FullReport.Add(CurrentProgress);
            }
            if (Conclusion != null)
            {
                FullReport.Add(Conclusion);
            }
            return String.Join("/n", FullReport);  
        }
    }
}
