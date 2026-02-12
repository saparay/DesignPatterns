using System;
using System.Collections.Generic;
using System.Text;

namespace CacheProxyDesignPattern
{
    public class DatabaseProfilePictureService : IProfilePictureService
    {
        public byte[] GetProfilePicture(int userId)
        {
            Console.WriteLine($"Fetching profile picture for user {userId} from database...");
            byte[] barray = new byte[1000];
            return barray;
        }
    }
}
