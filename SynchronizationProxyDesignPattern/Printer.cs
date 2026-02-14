using System;
using System.Collections.Generic;
using System.Text;

namespace SynchronizationProxyDesignPattern
{
    public class Printer
    {
        public void PrintDocument(string document)
        {
            Console.WriteLine($"Printing: {document}");
            Thread.Sleep(1000);
            Console.WriteLine($"Finished Printing: {document}");
        }
    }
}
