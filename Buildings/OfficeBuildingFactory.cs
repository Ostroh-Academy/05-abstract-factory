namespace Buildings
{
    public class OfficeBuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string name, string location, double totalArea, int floors)
        {
            return new OfficeBuilding(name, location, totalArea, floors, 50, 10); 
        }
    }
}
