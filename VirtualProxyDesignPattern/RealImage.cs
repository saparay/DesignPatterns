using System;
namespace VirtualProxyDesignPattern
{
    // The RealSubject contains some core business logic. 
    // Usually, RealSubjects are capable of doing some useful work which may be very slow or sensitive 
    // A Proxy can solve these issues without any changes to the RealSubject's code.
    public class RealImage : IImage
    {
        private string Filename { get; set; }
        public RealImage(string filename)
        {
            Filename = filename;
            LoadImageFromDisk();
        }
        public void LoadImageFromDisk()
        {
            Console.WriteLine("Loading Image : " + Filename);
        }
        public void DisplayImage()
        {
            Console.WriteLine("Displaying Image : " + Filename);
        }
    }
}