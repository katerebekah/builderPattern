using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builderPattern.Products
{
    public interface IReport
    {
        void AddIntro(string intro);
        void AddConclusion(string conclusion);
        void AddCurrentProgress(string currentProgress);
        void AddPersonalInfo(bool hasAccess, string personalInfo);
        string BuildReport();
    }
}
