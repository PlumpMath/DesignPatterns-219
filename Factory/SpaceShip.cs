using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class SpaceShip : Ship
    {
        //Set the values for the ship by calling the base class constructor
        public SpaceShip(string Name, double speed) : base(Name, speed)
        {
        }
    }
}
