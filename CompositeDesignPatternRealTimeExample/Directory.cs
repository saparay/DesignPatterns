using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPatternRealTimeExample
{
    public class Directory : FileSystemItem
    {
        private List<FileSystemItem> Childrens = new List<FileSystemItem>();

        public Directory(string name) : base(name) 
        {
            
        }

        public void AddComponent(FileSystemItem newNode)
        {
            this.Childrens.Add(newNode);
        }

        public void RemoveComponent(FileSystemItem removeNode)
        {
            this.Childrens.Remove(removeNode);
        }
        public override decimal GetSizeinKB()
        {
            return this.Childrens.Sum(x => x.GetSizeinKB());
        }
    }
}
