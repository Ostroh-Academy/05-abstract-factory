namespace Buildings
{
    public class ResidentialBuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string name, string location, double totalArea, int floors)
        {
            return new ResidentialBuilding(name, location, totalArea, floors, 100, 200); 
        }
    }
}
