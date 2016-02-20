using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using builderPattern.Builders;
using builderPattern.Products;

namespace builderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the report builder.");
            Console.WriteLine("What kind of report do you want? \r\n [1] - Basic Report \r\n [2] - Full Report Without Access To Personal Info \r\n [3] - Full Report With Access To Personal Info");
            var input = Console.ReadLine();
            int userChoice;
            var canParseToInt = int.TryParse(input, out userChoice);
            if (userChoice > 0 && userChoice < 4)
            {
                var report = new Report();
                var reportBuilder = new ReportBuilder(report);
                if (userChoice == 1)
                {
                    reportBuilder.BuildBasicReport();
                }
                else if (userChoice == 2)
                {
                    reportBuilder.BuildFullReport(false);
                }
                else if (userChoice == 3)
                {
                    reportBuilder.BuildFullReport(true);
                }
                Console.WriteLine(report.BuildReport());
            }
            else
                Console.WriteLine("This is not an accepted input. Goodbye.");
            Console.ReadKey();
        }
    }
}
