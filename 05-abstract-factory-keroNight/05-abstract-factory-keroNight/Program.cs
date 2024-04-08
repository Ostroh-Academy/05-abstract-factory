using _05_abstract_factory_keroNight;

while (true)
{
    RoadFactory factory;

    Console.WriteLine("Select road conditions:");
    Console.WriteLine("1. Urban");
    Console.WriteLine("2. Rural");
    Console.WriteLine("3. Harsh");
    Console.WriteLine("0. Exit");
    Console.Write("Enter choice: ");
    var choice = int.Parse(Console.ReadLine());

    if (choice == 0)
        break;

    factory = choice switch
    {
        1 => new AsphaltRoadFactory(),
        2 => new GravelRoadFactory(),
        3 => new AsphaltRoadFactory(),
        _ => new GravelRoadFactory()
    };

    var road = factory.CreateRoad("Main Road");
    road.Build();
}