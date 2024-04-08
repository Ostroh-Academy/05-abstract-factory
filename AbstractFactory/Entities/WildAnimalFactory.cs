using AbstractFactory.Entities.Interfaces;

namespace AbstractFactory.Entities;

public class WildAnimalFactory : IAnimalFactory
{
    public ICat CreateCat()
    {
        return new Lion();
    }

    public IDog CreateDog()
    {
        return new Wolf();
    }
}