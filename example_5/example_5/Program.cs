using example_5;

class Program
{
    static void Main(string[] args)
    {
        IVehicleFactory economyFactory = new EconomyVehicleFactory();
        VehicleManager economyManager = new VehicleManager(economyFactory);
        economyManager.TestDrive();

        IVehicleFactory luxuryFactory = new LuxuryVehicleFactory();
        VehicleManager luxuryManager = new VehicleManager(luxuryFactory);
        luxuryManager.TestDrive();
    }
}
