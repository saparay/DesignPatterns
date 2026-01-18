using FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Factory
{
    public class SummaryReportGeneratorFactory : ReportGeneratorFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new SummaryReportGenerator();
        }
    }
}
