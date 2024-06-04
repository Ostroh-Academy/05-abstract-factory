using System;
namespace example_5
{
    public interface IVehicleFactory
    {
        ICar CreateCar();
        IMotorcycle CreateMotorcycle();
    }
}

