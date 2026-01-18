using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Product
{
    public interface IReportGenerator
    {
        void GenerateReport(string data);
    }
}
