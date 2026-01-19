using AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Factory
{
    public class MP3MP4Factory : IMediaFactory
    {
        public IAudioProcessor CreateAudioProcessor() => new MP3Processor();
        public IVideoProcessor CreateVideoProcessor() => new MP4Processor();
    }
}
