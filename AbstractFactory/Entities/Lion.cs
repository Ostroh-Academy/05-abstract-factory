using AbstractFactory.Entities.Interfaces;

namespace AbstractFactory.Entities;

public class Lion : ICat
{
    public void Speak()
    {
        Console.WriteLine("Roar");
    }

    public void Eat()
    {
        Console.WriteLine("Eating a large meal");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping in the sun");
    }

    public void Purr()
    {
        Console.WriteLine("Purring loudly");
    }

    public void Scratch()
    {
        Console.WriteLine("Scratching a tree");
    }
}