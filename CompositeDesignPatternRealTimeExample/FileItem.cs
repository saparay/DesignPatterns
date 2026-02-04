using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPatternRealTimeExample
{
    public class FileItem : FileSystemItem
    {
        public long FileBytes { get; }

        public FileItem(string name, long fileBytes) : base(name) 
        {
            this.FileBytes = fileBytes;
        }
        public override decimal GetSizeinKB()
        {
            return decimal.Divide(this.FileBytes, 1024);
        }
    }
}
