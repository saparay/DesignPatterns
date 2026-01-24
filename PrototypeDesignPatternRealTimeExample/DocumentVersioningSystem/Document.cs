using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPatternRealTimeExample.DocumentVersioningSystem
{
    public class Document : IDocumentPrototype
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IDocumentPrototype Clone()
        {
            return new Document
            {
                Title = this.Title,
                Content = this.Content
            };
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}\nContent:{Content}\n");
        }
    }
}
