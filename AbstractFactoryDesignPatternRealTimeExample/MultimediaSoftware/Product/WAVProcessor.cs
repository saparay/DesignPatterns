using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product
{
    public class WAVProcessor : IAudioProcessor
    {
        public void ProcessAudio(string file)
        {
            Console.WriteLine($"Processing WAV audio file: {file}");
        }
    }
}
