using DesignPatterns.Iterator;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change this value to mimic the behaviour of the corresponding pattern. 
            int designPat = 2;
            switch (designPat)
            {
                case 1:
                    Console.WriteLine("Singleton Pattern");
                    Singleton.Singleton.InstanceVar.Foo();
                    Singleton.Singleton.InstanceVar.Foo();
                    break;
                case 2:
                    Console.WriteLine("Iterator Pattern");
                    Person[] pArr = new Person[3]
                    {
                        new Person("John", "Doe"),
                        new Person("Will", "Smith"),
                        new Person("Wild", "Cats"),
                    };
                    People pList = new People(pArr);
                    foreach (Person p in pList)
                    {
                        Console.WriteLine("{0} {1}", p.FName, p.lName);
                    }
                    break;
                default:
                    break;

            }
            
            Console.ReadKey();
        }
    }
}
