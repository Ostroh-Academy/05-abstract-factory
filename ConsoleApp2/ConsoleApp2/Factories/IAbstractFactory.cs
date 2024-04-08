using ConsoleApp2.ProductA;
using ConsoleApp2.ProductB;

namespace ConsoleApp2.Factories;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}