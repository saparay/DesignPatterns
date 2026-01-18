using FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Factory;
using FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternRealTimeExample.ReportGenerators
{
    public class AnalyticsService
    {
        public void CreateReport(ReportGeneratorFactory factory, string data)
        {
            IReportGenerator reportGenerator = factory.CreateReportGenerator();
            reportGenerator.GenerateReport(data);
        }
    }
}
