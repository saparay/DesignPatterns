using System;
namespace RemoteProxyDesignPattern
{
    public interface IUserService
    {
        string GetUserName(int userId);
    }
}