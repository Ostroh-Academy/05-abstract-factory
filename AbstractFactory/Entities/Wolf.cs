using AbstractFactory.Entities.Interfaces;

namespace AbstractFactory.Entities;

public class Wolf : IDog
{
    public void Speak()
    {
        Console.WriteLine("Howl");
    }

    public void Eat()
    {
        Console.WriteLine("Eating a raw meat");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping in a den");
    }

    public void WagTail()
    {
        Console.WriteLine("Wagging tail");
    }

    public void Fetch()
    {
        Console.WriteLine("Fetching a stick");
    }
}