using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Product
{
    public class TabularReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Tabular Report with data: {data}");
            // Actual logic to generate a tabular report...
        }
    }
}
