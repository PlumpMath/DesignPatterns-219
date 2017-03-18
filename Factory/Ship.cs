using System;

namespace DesignPatterns.Factory
{
   abstract class Ship
    {
        private string firstName;
        private double speed;

        //Property to access the members of the class ship.
        public Ship(string firstName, double speed)
        {
            this.firstName = firstName;
            this.speed = speed;
        }
        public string Name
        {
            get
            {
                return firstName;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
        }

        public void ShipStatus()
        {
            Console.WriteLine("Ship name {0}, Speed {1}", Name, Speed);
        }
        
    }
}
