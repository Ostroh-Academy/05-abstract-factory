using AbstractFactory.Classes.Bikes;
using AbstractFactory.Classes.CarClasses;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Factory
{
    public class BMWTransportFactory : ITransportFactory
    {
        public Bike GetBike()
        {
            return new DefaultBike();
        }

        public Car GetCar()
        {
            return new DefaultCar();
        }
    }
}
