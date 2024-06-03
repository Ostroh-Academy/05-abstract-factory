namespace Buildings
{
    public class CommercialBuilding : IBuilding
    {
        public string Name { get; }
        public string Location { get; }
        public double TotalArea { get; }
        public int Floors { get; }
        public int NumShops { get; }
        public double ParkingArea { get; }

        public CommercialBuilding(string name, string location, double totalArea, int floors, int numShops, double parkingArea)
        {
            Name = name;
            Location = location;
            TotalArea = totalArea;
            Floors = floors;
            NumShops = numShops;
            ParkingArea = parkingArea;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Building Name: {Name}");
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Total Area: {TotalArea} sqm");
            Console.WriteLine($"Number of Floors: {Floors}");
            Console.WriteLine($"Number of Shops: {NumShops}");
            Console.WriteLine($"Parking Area: {ParkingArea} sqm");
        }
    }
}
