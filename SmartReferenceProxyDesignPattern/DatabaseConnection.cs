using System;
using System.Collections.Generic;
using System.Text;

namespace SmartReferenceProxyDesignPattern
{
    //DatabaseConnection (RealSubject)
    public class DatabaseConnection : IDatabaseConnection
    {
        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing query: {query}");
        }
    }
}
