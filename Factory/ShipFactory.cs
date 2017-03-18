
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
                    objfactory = new RocketShip();
                    break;
                case 2:
                    objfactory = new SpaceShip();
                    break;
                default:
                    break;
            }
            return objfactory;
        }

    }
}
