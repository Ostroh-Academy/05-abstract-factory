namespace AbstractFactory.Entities.Interfaces;

public interface IAnimalFactory
{
    ICat CreateCat();
    IDog CreateDog();
}