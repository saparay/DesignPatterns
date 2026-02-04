using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPatternRealTimeExample
{
    public abstract class FileSystemItem
    {
        public string Name { get; }

        public FileSystemItem(string name)
        {
            this.Name = name;
        }

        public abstract decimal GetSizeinKB();
    }
}
