namespace CacheProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProfilePictureService service = new CachedProfilePictureService(new DatabaseProfilePictureService());
            var pic1 = service.GetProfilePicture(1);
            var pic2 = service.GetProfilePicture(1);
            var pic3 = service.GetProfilePicture(3);
            Console.ReadKey();
        }
    }
}
