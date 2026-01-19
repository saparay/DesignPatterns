using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product
{
    public interface IVideoProcessor
    {
        void ProcessVideo(string file);
    }
}
