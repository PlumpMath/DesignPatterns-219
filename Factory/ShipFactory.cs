
namespace DesignPatterns.Factory
{
    class ShipFactory
    {
        Ship objfactory = null;
        
        //Make ship based on the value.
        public Ship MakeShip(int val)
        {
            switch (val)
            {
                case 1:
                    objfactory = new RocketShip("Rocket", 20.0);
                    break;
                case 2:
                    objfactory = new SpaceShip("Space", 40.0);
                    break;
                default:
                    break;
            }
            return objfactory;
        }

    }
}
