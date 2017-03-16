using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton.Singleton.InstanceVar.Foo();
            Singleton.Singleton.InstanceVar.Foo();
            Console.ReadKey();
        }
    }
}
