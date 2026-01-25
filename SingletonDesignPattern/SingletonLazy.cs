using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public sealed class SingletonLazy
    {
        private static int Counter = 0;

        private static readonly Lazy<SingletonLazy> instance = new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy() {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        public static SingletonLazy GetInstance()
        {
            return instance.Value;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
