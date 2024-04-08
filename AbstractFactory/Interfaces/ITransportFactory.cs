
using AbstractFactory.Classes;
using AbstractFactory.Classes.Bikes;
using AbstractFactory.Classes.CarClasses;

namespace AbstractFactory.Interfaces
{
    public interface ITransportFactory
    {
        Bike GetBike();
        Car GetCar();
    }
}
