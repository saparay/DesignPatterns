using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Product
{
    public class SummaryReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Summary Report with data: {data}");
            // Actual logic to generate a summary report...
        }
    }
}
