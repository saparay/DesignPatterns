using System;
using System.Collections.Generic;
using System.Text;

namespace SynchronizationProxyDesignPattern
{
    public class PrinterProxy
    {
        private readonly Printer _printer = new Printer();
        private readonly object _lock = new object();

        public void Print(string document)
        {
            lock (_lock){
                _printer.PrintDocument(document);
            }
        }
    }
}
