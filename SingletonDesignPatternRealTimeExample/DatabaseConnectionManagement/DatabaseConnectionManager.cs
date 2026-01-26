using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPatternRealTimeExample.DatabaseConnectionManagement
{
    public class DatabaseConnectionManager
    {
        private static readonly DatabaseConnectionManager _instance = new DatabaseConnectionManager();

        private SqlConnection _connection;
        
        private DatabaseConnectionManager()
        {
            _connection = new SqlConnection("Server=.;Database=EmployeeDB;Integrated Security=True;TrustServerCertificate=True;");
        }

        public static DatabaseConnectionManager Instance
        {
            get { return _instance; } 
        }

        public void OpenConnection()
        {
            if(_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();            
            }
        }

        public void CloseConnection()
        {
            if(_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
        public SqlConnection GetSqlConnection()
        {
            return _connection;
        }
    }
}
