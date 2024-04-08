using ConsoleApp2.ProductA;

namespace ConsoleApp2.ProductB;

public interface IAbstractProductB
{
    string UsefulFunctionB();
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}