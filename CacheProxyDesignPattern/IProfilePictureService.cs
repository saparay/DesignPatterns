using System;
using System.Collections.Generic;
using System.Text;

namespace CacheProxyDesignPattern
{
    public interface IProfilePictureService
    {
        byte[] GetProfilePicture(int userId);
    }
}
