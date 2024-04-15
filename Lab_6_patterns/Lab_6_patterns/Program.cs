using Lab_6_patterns;
using Lab_6_patterns.Factory;

FurnitureFactory modernFactory = new ModernFurnitureFactory();
Menu modernClient = new Menu(modernFactory);
modernClient.SitOnChair();
modernClient.LieOnSofa();

FurnitureFactory victorianFactory = new VictorianFurnitureFactory();
Menu victorianClient = new Menu(victorianFactory);
victorianClient.SitOnChair();
victorianClient.LieOnSofa();

Console.ReadLine();