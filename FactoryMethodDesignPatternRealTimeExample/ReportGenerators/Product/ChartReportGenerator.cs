using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Product
{
    public class ChartReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Chart Report with data: {data}");
            // Actual logic to generate a chart report...
        }
    }
}
