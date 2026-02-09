namespace RemoteProxyDesignPattern
{
    public class RealUserService : IUserService
    {
        public string GetUserName(int userId)
        {
            // In a real-world scenario, this might pull data from a database.
            return $"User_{userId}";
        }
    }
}