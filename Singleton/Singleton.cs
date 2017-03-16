using System;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
         
        private static Singleton instanceVar = null;
        private static readonly object padlock = new object();

        Singleton()
        {   
        }

        public static Singleton InstanceVar
        {
            get
            {
                //threadsafe implementation of Singleton Pattern.
                lock (padlock)
                {
                    //Create an instance only if the instance variable is null.
                    if (instanceVar == null)
                        Console.WriteLine("Creating a new instance");
                        instanceVar = new Singleton();
                    
                    return instanceVar;
                }
            }
        }

        //Test method
        internal void Foo()
        {
            Console.WriteLine("Inside foo method");
        }


    }
}
