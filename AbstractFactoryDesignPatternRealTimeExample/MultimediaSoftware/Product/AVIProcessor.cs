using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product
{
    public class AVIProcessor : IVideoProcessor
    {
        public void ProcessVideo(string file)
        {
            Console.WriteLine($"Processing AVI video file: {file}");
        }
    }
}
