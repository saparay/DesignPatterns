using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatternRealTimeExamples.CloudStorageSystem
{
    public interface IStorageProvider
    {
        void SaveFile(string fileName, byte[] fileData);
        byte[] RetrieveFile(string fileName);
    }
}
