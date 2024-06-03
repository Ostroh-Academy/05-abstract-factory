using Buildings;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuildingFactory residentialFactory = new ResidentialBuildingFactory();
            IBuilding resBuilding = residentialFactory.CreateBuilding("Sunny Apartments", "Kyiv", 5000, 10);
            resBuilding.DisplayInfo();

            IBuildingFactory officeFactory = new OfficeBuildingFactory();
            IBuilding officeBuilding = officeFactory.CreateBuilding("Tech Tower", "Lviv", 8000, 15);
            officeBuilding.DisplayInfo();

            IBuildingFactory commercialFactory = new CommercialBuildingFactory();
            IBuilding commBuilding = commercialFactory.CreateBuilding("Mall of Dreams", "Odessa", 10000, 5);
            commBuilding.DisplayInfo();
        }
    }
}
