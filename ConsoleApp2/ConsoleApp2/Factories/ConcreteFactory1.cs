using ConsoleApp2.ProductA;
using ConsoleApp2.ProductB;

namespace ConsoleApp2.Factories;

public class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}