using AbstractFactory.Entities.Interfaces;

namespace AbstractFactory.Entities;

public class DomesticAnimalFactory : IAnimalFactory
{
    public ICat CreateCat()
    {
        return new DomesticCat();
    }

    public IDog CreateDog()
    {
        return new DomesticDog();
    }
}