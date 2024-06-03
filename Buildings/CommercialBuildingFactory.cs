namespace Buildings
{
    public class CommercialBuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string name, string location, double totalArea, int floors)
        {
            return new CommercialBuilding(name, location, totalArea, floors, 200, 3000); 
        }
    }
}
