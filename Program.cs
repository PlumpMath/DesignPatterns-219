using DesignPatterns.Factory;
using DesignPatterns.Iterator;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change this value to mimic the behaviour of the corresponding pattern. 
            int designPat = 3;
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
                case 3:
                    Console.WriteLine("Factory Pattern");
                    //val = 1 for rocket ship and 2 for space ship
                    int val = 2;
                    ShipFactory factoryObj = new ShipFactory();
                    Ship shipType = null;
                    shipType = factoryObj.MakeShip(val);
                    //To display the type of ship and it's speed
                    shipType.ShipStatus();
                    break;
                default:
                    break;

            }
            
            Console.ReadKey();
        }
    }
}
