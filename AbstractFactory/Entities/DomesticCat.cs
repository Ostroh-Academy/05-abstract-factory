using AbstractFactory.Entities.Interfaces;

namespace AbstractFactory.Entities;

public class DomesticCat : ICat
{
    public void Speak()
    {
        Console.WriteLine("Meow");
    }

    public void Eat()
    {
        Console.WriteLine("Eating cat food");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping in a cozy bed");
    }

    public void Purr()
    {
        Console.WriteLine("Purring softly");
    }

    public void Scratch()
    {
        Console.WriteLine("Scratching a scratching post");
    }
}