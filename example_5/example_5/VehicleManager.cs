using System;
namespace example_5
{
    public class VehicleManager
    {
        private readonly ICar _car;
        private readonly IMotorcycle _motorcycle;

        public VehicleManager(IVehicleFactory factory)
        {
            _car = factory.CreateCar();
            _motorcycle = factory.CreateMotorcycle();
        }

        public void TestDrive()
        {
            _car.Drive();
            _motorcycle.Ride();
        }
    }

}

