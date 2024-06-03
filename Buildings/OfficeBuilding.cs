namespace Buildings
{
    public class OfficeBuilding : IBuilding
    {
        public string Name { get; }
        public string Location { get; }
        public double TotalArea { get; }
        public int Floors { get; }
        public int NumOffices { get; }
        public int ConferenceRooms { get; }

        public OfficeBuilding(string name, string location, double totalArea, int floors, int numOffices, int conferenceRooms)
        {
            Name = name;
            Location = location;
            TotalArea = totalArea;
            Floors = floors;
            NumOffices = numOffices;
            ConferenceRooms = conferenceRooms;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Building Name: {Name}");
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Total Area: {TotalArea} sqm");
            Console.WriteLine($"Number of Floors: {Floors}");
            Console.WriteLine($"Number of Offices: {NumOffices}");
            Console.WriteLine($"Number of Conference Rooms: {ConferenceRooms}");
        }
    }
}
