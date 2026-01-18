using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatternRealTimeExamples.LoggingSystem
{
    public class FileLogger : ILogger
    {
        private string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            File.AppendAllText(_filePath, "File: " + message + Environment.NewLine);
        }
    }
}
