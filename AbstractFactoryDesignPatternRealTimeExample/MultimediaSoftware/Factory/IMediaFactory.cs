using AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Factory
{
    public interface IMediaFactory
    {
        IAudioProcessor CreateAudioProcessor();
        IVideoProcessor CreateVideoProcessor();
    }
}
