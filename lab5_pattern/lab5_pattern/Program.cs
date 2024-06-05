using System;

// Abstract Factory
abstract class CoolingSystemFactory
{
    public abstract Radiator CreateRadiator();
    public abstract Fan CreateFan();
}

// Concrete Factory for Air Cooling
class AirCoolingSystemFactory : CoolingSystemFactory
{
    public override Radiator CreateRadiator()
    {
        return new AirRadiator();
    }

    public override Fan CreateFan()
    {
        return new AirFan();
    }
}

// Concrete Factory for Water Cooling
class WaterCoolingSystemFactory : CoolingSystemFactory
{
    public override Radiator CreateRadiator()
    {
        return new WaterRadiator();
    }

    public override Fan CreateFan()
    {
        return new WaterPump();
    }
}

// Abstract Product Radiator
abstract class Radiator
{
    public abstract string Cool();
}

// Concrete Product for Air Radiator
class AirRadiator : Radiator
{
    public override string Cool()
    {
        return "Cooling with Air Radiator";
    }
}

// Concrete Product for Water Radiator
class WaterRadiator : Radiator
{
    public override string Cool()
    {
        return "Cooling with Water Radiator";
    }
}

// Abstract Product Fan
abstract class Fan
{
    public abstract string Spin();
}

// Concrete Product for Air Fan
class AirFan : Fan
{
    public override string Spin()
    {
        return "Spinning Air Fan";
    }
}

// Concrete Product for Water Pump
class WaterPump : Fan
{
    public override string Spin()
    {
        return "Pumping Water";
    }
}

// Client Code
class Program
{
    static void CreateCoolingSystem(CoolingSystemFactory factory)
    {
        Radiator radiator = factory.CreateRadiator();
        Fan fan = factory.CreateFan();

        Console.WriteLine(radiator.Cool());
        Console.WriteLine(fan.Spin());
    }

    static void Main()
    {
        // Using Air Cooling System
        CoolingSystemFactory airFactory = new AirCoolingSystemFactory();
        CreateCoolingSystem(airFactory);

        // Using Water Cooling System
        CoolingSystemFactory waterFactory = new WaterCoolingSystemFactory();
        CreateCoolingSystem(waterFactory);
    }
}
