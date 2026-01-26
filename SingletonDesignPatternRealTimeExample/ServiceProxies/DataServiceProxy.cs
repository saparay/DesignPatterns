using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPatternRealTimeExample.ServiceProxies
{
    public class DataServiceProxy : IDataService
    {
        private static readonly Lazy<DataServiceProxy> _instance = new Lazy<DataServiceProxy>(() => new DataServiceProxy());


        private DataServiceProxy()
        {

        }
        public string GetData()
        {
            return "Data from remote service";
        }

        public static DataServiceProxy Instance => _instance.Value;
    }
}
