using System;
using System.Collections.Generic;
using System.Text;

namespace SmartReferenceProxyDesignPattern
{
    //DatabaseConnectionProxy (Proxy)
    public class DatabaseConnectionProxy : IDatabaseConnection
    {
        private DatabaseConnection _connection;
        private static List<DatabaseConnection> _availableConnections = new List<DatabaseConnection>
        {
            new DatabaseConnection(), new DatabaseConnection(), new DatabaseConnection()
        };

        public DatabaseConnectionProxy()
        {
            _connection = GetConnectionFromPool();
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine("Proxy: Checking connection health...");
            // Assume there's a method to check connection health, omitted for brevity.
            if (ConnectionIsHealthy())
            {
                _connection.ExecuteQuery(query);
                ReturnConnectionToPool(_connection);
            }
            else
            {
                Console.WriteLine("Proxy: Connection is unhealthy. Trying another one...");
                _connection = GetConnectionFromPool();
                _connection.ExecuteQuery(query);
                ReturnConnectionToPool(_connection);
            }
        }

        private DatabaseConnection GetConnectionFromPool()
        {
            // For simplicity, just get the first available connection.
            var connection = _availableConnections.FirstOrDefault();
            _availableConnections.Remove(connection);
            return connection;
        }

        private void ReturnConnectionToPool(DatabaseConnection connection)
        {
            _availableConnections.Add(connection);
        }

        private bool ConnectionIsHealthy()
        {
            // Logic to check connection health, omitted for brevity.
            return true;
        }
    }


}
