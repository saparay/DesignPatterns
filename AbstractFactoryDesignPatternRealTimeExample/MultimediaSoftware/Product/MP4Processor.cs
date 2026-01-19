using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product
{
    public class MP4Processor : IVideoProcessor
    {
        public void ProcessVideo(string file)
        {
            Console.WriteLine($"Processing MP4 video file: {file}");
        }
    }
}
