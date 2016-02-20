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
            int.TryParse(input, out userChoice);
            var report = new Report();
            var reportBuilder = new ReportBuilder(report);
            switch (userChoice)
            {
                case 1:
                    reportBuilder.BuildBasicReport();
                    break;
                case 2:
                    reportBuilder.BuildFullReport(false);
                    break;
                case 3:
                    reportBuilder.BuildFullReport(true);
                    break;
                default:
                    Console.WriteLine("This is not an accepted input. Goodbye.");
                    break;
            }
            Console.WriteLine(report.BuildReport());
            
            Console.ReadKey();
        }
    }
}
