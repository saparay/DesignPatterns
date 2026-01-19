using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product
{
    public interface IAudioProcessor
    {
        void ProcessAudio(string file);
    }
}
