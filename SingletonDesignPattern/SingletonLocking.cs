using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public sealed class SingletonLocking
    {
        private static int Counter = 0;

        private static SingletonLocking Instance = null;

        private static readonly object Instancelock = new object();

        public static SingletonLocking GetInstance()
        {
            //locking
            //lock (Instancelock)
            //{
            //    if(Instance == null)
            //    {
            //        Instance = new SingletonLocking();
            //    }
            //}
            //return Instance;

            // double-checked locking 

            if(Instance == null)
            {
                lock (Instancelock)
                {
                    if (Instance == null)
                    {
                        Instance = new SingletonLocking();
                    }
                }
            }
            return Instance;
        }

        private SingletonLocking()
        {
            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
