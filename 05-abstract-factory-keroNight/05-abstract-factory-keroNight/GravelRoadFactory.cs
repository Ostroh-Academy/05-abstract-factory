namespace _05_abstract_factory_keroNight;

public class GravelRoadFactory : RoadFactory
{
    public override Road CreateRoad(string name) => 
        new GravelRoad();
}