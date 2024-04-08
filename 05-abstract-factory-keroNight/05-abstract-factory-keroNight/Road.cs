namespace _05_abstract_factory_keroNight;

public abstract class Road
{
    protected RoadMaterialType Material { get; set; }

    public void Build() => 
        Console.WriteLine($"Будуємо дорогу з матеріалу '{Material}'.");
}

