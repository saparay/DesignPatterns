namespace SmartReferenceProxyDesignPattern
{
    //Client Code
    //Testing Smart Reference Proxy Design Pattern
    public class Program
    {
        public static void Main()
        {
            IDatabaseConnection connection = new DatabaseConnectionProxy();
            connection.ExecuteQuery("SELECT * FROM users");
            Console.ReadKey();
        }
    }
}
