namespace Buildings
{
    public class ResidentialBuilding : IBuilding
    {
        public string Name { get; }
        public string Location { get; }
        public double TotalArea { get; }
        public int Floors { get; }
        public int NumApartments { get; }
        public double PlaygroundArea { get; }

        public ResidentialBuilding(string name, string location, double totalArea, int floors, int numApartments, double playgroundArea)
        {
            Name = name;
            Location = location;
            TotalArea = totalArea;
            Floors = floors;
            NumApartments = numApartments;
            PlaygroundArea = playgroundArea;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Building Name: {Name}");
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Total Area: {TotalArea} sqm");
            Console.WriteLine($"Number of Floors: {Floors}");
            Console.WriteLine($"Number of Apartments: {NumApartments}");
            Console.WriteLine($"Playground Area: {PlaygroundArea} sqm");
        }
    }
}
