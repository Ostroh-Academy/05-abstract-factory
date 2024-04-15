using System;

abstract class Furniture
{
    public abstract void Display();
}

class ModernChair : Furniture
{
    public override void Display()
    {
        Console.WriteLine("Modern Chair");
    }
}

class ModernSofa : Furniture
{
    public override void Display()
    {
        Console.WriteLine("Modern Sofa");
    }
}

class ClassicChair : Furniture
{
    public override void Display()
    {
        Console.WriteLine("Classic Chair");
    }
}

class ClassicSofa : Furniture
{
    public override void Display()
    {
        Console.WriteLine("Classic Sofa");
    }
}

abstract class InteriorFactory
{
    public abstract Furniture CreateChair();
    public abstract Furniture CreateSofa();
}

class ModernInteriorFactory : InteriorFactory
{
    public override Furniture CreateChair()
    {
        return new ModernChair();
    }

    public override Furniture CreateSofa()
    {
        return new ModernSofa();
    }
}

class ClassicInteriorFactory : InteriorFactory
{
    public override Furniture CreateChair()
    {
        return new ClassicChair();
    }

    public override Furniture CreateSofa()
    {
        return new ClassicSofa();
    }
}

class Client
{
    private InteriorFactory factory;

    public Client(InteriorFactory factory)
    {
        this.factory = factory;
    }

    public void DisplayFurniture()
    {
        Furniture chair = factory.CreateChair();
        Furniture sofa = factory.CreateSofa();

        chair.Display();
        sofa.Display();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Модерн
        InteriorFactory modernFactory = new ModernInteriorFactory();
        Client modernClient = new Client(modernFactory);
        modernClient.DisplayFurniture();

        // Класика
        InteriorFactory classicFactory = new ClassicInteriorFactory();
        Client classicClient = new Client(classicFactory);
        classicClient.DisplayFurniture();
    }
}
