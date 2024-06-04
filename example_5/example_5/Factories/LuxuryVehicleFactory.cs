using System;
namespace example_5
{
    public class LuxuryVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new SportsCar();
        }

        public IMotorcycle CreateMotorcycle()
        {
            return new SportBike();
        }
    }
}

