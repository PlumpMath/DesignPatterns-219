using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class SpaceShip : Ship
    {
        //Set the values for the ship
        public SpaceShip()
        {
            Name = "Space";
            Speed = 40.0;
        }
    }
}
