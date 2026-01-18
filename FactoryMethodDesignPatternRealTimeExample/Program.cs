using FactoryMethodDesignPatternRealTimeExample.ReportGenerators;
using FactoryMethodDesignPatternRealTimeExample.ReportGenerators.Factory;

namespace FactoryMethodDesignPatternRealTimeExample
{
    public class Program
    {
        public static void Main()
        {
            var analyticsService = new AnalyticsService();
            // User wants a Chart report:
            analyticsService.CreateReport(new ChartReportGeneratorFactory(), "ChartData123");
            // User wants a Tabular report:
            analyticsService.CreateReport(new TabularReportGeneratorFactory(), "TabularData456");
            // User wants a Summary report:
            analyticsService.CreateReport(new SummaryReportGeneratorFactory(), "SummaryData789");
            Console.ReadKey();
        }
    }
}