using System;

abstract class Table
{
    public abstract void Display();
}

abstract class Chair
{
    public abstract void Display();
}

abstract class FurnitureFactory
{
    public abstract Table CreateTable();
    public abstract Chair CreateChair();
}

class WoodenFurnitureFactory : FurnitureFactory
{
    public override Table CreateTable()
    {
        return new WoodenTable();
    }

    public override Chair CreateChair()
    {
        return new WoodenChair();
    }
}

class MetalFurnitureFactory : FurnitureFactory
{
    public override Table CreateTable()
    {
        return new MetalTable();
    }

    public override Chair CreateChair()
    {
        return new MetalChair();
    }
}

class WoodenTable : Table
{
    public override void Display()
    {
        Console.WriteLine("This is a wooden table.");
    }
}

class WoodenChair : Chair
{
    public override void Display()
    {
        Console.WriteLine("This is a wooden chair.");
    }
}

class MetalTable : Table
{
    public override void Display()
    {
        Console.WriteLine("This is a metal table.");
    }
}

class MetalChair : Chair
{
    public override void Display()
    {
        Console.WriteLine("This is a metal chair.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FurnitureFactory factory = new WoodenFurnitureFactory();

        Table table = factory.CreateTable();
        Chair chair = factory.CreateChair();

        table.Display(); // Output: This is a wooden table.
        chair.Display(); // Output: This is a wooden chair.
    }
}
