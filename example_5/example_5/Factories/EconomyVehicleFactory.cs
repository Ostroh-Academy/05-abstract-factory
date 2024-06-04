using System;
namespace example_5
{
    public class EconomyVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new Sedan();
        }

        public IMotorcycle CreateMotorcycle()
        {
            return new Cruiser();
        }
    }
}

