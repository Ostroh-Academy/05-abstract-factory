namespace Buildings
{
    public class Building
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double TotalArea { get; set; }
        public int Floors { get; set; }

        public Building(string name, string location, double totalArea, int floors)
        {
            Name = name;
            Location = location;
            TotalArea = totalArea;
            Floors = floors;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Building Name: {Name}");
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Total Area: {TotalArea} sqm");
            Console.WriteLine($"Number of Floors: {Floors}");
        }
    }
}
