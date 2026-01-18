using FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Factory
{
    public abstract class ReportGeneratorFactory
    {
        public abstract IReportGenerator CreateReportGenerator();
    }
}
