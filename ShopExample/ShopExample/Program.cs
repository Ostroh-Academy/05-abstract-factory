using ShopExample.Factories;

namespace ShopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IShopFactory electronicFactory = new ElectronicShopFactory();
            ShopClient electronicClient = new ShopClient(electronicFactory);
            electronicClient.Run();

            IShopFactory clothingFactory = new ClothingShopFactory();
            ShopClient clothingClient = new ShopClient(clothingFactory);
            clothingClient.Run();
        }
    }
}
