using AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Factory;
using AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPatternRealTimeExample.MultimediaSoftware
{
    public class MediaApplication
    {
        private readonly IAudioProcessor _audioProcessor;
        private readonly IVideoProcessor _videoProcessor;

        public MediaApplication(IMediaFactory factory)
        {
            _audioProcessor = factory.CreateAudioProcessor();
            _videoProcessor = factory.CreateVideoProcessor();
        }

        public void Run(string audioFile, string videoFile)
        {
            _audioProcessor.ProcessAudio(audioFile);
            _videoProcessor.ProcessVideo(videoFile);
        }
    }
}
