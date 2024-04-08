using AbstractFactory.Entities.Interfaces;

namespace AbstractFactory.Entities;

public class DomesticDog : IDog
{
    public void Speak()
    {
        Console.WriteLine("Woof");
    }

    public void Eat()
    {
        Console.WriteLine("Eating dog food");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping in a dog bed");
    }

    public void WagTail()
    {
        Console.WriteLine("Wagging tail");
    }

    public void Fetch()
    {
        Console.WriteLine("Fetching a ball");
    }
}