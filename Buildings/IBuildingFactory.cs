namespace Buildings
{
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string name, string location, double totalArea, int floors);
    }
}
