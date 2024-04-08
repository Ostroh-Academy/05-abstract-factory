namespace AbstractFactory.Entities.Interfaces;

public interface IDog : IAnimal
{
    void WagTail();
    void Fetch();
}