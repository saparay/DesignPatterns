using System;
using System.Collections.Generic;
using System.Text;

namespace CacheProxyDesignPattern
{
    public class CachedProfilePictureService : IProfilePictureService
    {
        private readonly IProfilePictureService _profilePictureService;
        private readonly Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>();

        public CachedProfilePictureService(IProfilePictureService service)
        {
            _profilePictureService = service;
        }

        public byte[] GetProfilePicture(int userId)
        {
            if(_cache.ContainsKey(userId))
            {
                Console.WriteLine($"Returning cached profile picture for user {userId}.");
                return _cache[userId];
            }
            var picture = _profilePictureService.GetProfilePicture(userId);
            _cache[userId] = picture;
            return picture;
        }
    }
}
