using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product
{
    public class MP3Processor : IAudioProcessor
    {
        public void ProcessAudio(string file)
        {
            Console.WriteLine($"Processing MP3 audio file: {file}");
        }
    }
}
