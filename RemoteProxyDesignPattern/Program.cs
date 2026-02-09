using System;
namespace RemoteProxyDesignPattern
{
    // Testing Remote Proxy Design Pattern
    public class Program
    {
        public static void Main()
        {
            IUserService userService = new RemoteUserServiceProxy();
            string userName = userService.GetUserName(1);
            Console.WriteLine($"Received username: {userName}");
            Console.ReadKey();
        }
    }
}