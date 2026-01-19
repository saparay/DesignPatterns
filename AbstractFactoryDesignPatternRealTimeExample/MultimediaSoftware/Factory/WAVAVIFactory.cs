using AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Factory
{
    public class WAVAVIFactory : IMediaFactory
    {
        public IAudioProcessor CreateAudioProcessor() => new WAVProcessor();
        public IVideoProcessor CreateVideoProcessor() => new AVIProcessor();
    }
}
