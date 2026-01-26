// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using SingletonDesignPatternRealTimeExample.DatabaseConnectionManagement;
using SingletonDesignPatternRealTimeExample.ServiceProxies;

Console.WriteLine("#Service Proxies");

IDataService dataService = DataServiceProxy.Instance;

string data = dataService.GetData();

Console.WriteLine(data);


Console.WriteLine("Database Connection Management");


SqlCommand command = new SqlCommand("SELECT * FROM Employee", DatabaseConnectionManager.Instance.GetSqlConnection());



DatabaseConnectionManager.Instance.CloseConnection();