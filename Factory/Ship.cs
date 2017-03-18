using System;

namespace DesignPatterns.Factory
{
   abstract class Ship
    {
        private string firstName;
        private double speed;

        //Property to access the members of the class ship.

        public string Name
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public void ShipStatus()
        {
            Console.WriteLine("Ship name {0}, Speed {1}", Name, Speed);
        }
        
    }
}
