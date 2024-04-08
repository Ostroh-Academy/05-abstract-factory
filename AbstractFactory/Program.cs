using AbstractFactory.Classes;
using AbstractFactory.Classes.Factory;
using AbstractFactory.Interfaces;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
ITransportFactory BMWfactory = new BMWTransportFactory();
Car car = BMWfactory.GetCar();
Bike bike = BMWfactory.GetBike();
Console.WriteLine(" я маю  на  BMW factory  {0} і {1} ",car.Name,bike.Name);


ITransportFactory Teslafactory = new TeslaTransportFactory();
Car electricCar = Teslafactory.GetCar();
Bike electricBike = Teslafactory.GetBike();
Console.WriteLine(" я маю  на Tesla factory  {0} і {1} ", electricCar.Name, electricBike.Name);