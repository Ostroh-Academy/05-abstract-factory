namespace _05_abstract_factory_keroNight;

public class AsphaltRoadFactory : RoadFactory
{
    public override Road CreateRoad(string name) => 
        new AsphaltRoad();
}