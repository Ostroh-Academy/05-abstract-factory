namespace AbstractFactoryProject;

public class Program
{
    public static void Main(string[] args)
    {
        new Client().Main();
    }
}

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

public class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA() => new ConcreteProductA1();

    public IAbstractProductB CreateProductB() => new ConcreteProductB1();
}

public class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA() => new ConcreteProductA2();

    public IAbstractProductB CreateProductB() => new ConcreteProductB2();
}

public interface IAbstractProductA
{
    string UsefulFunctionA();
}

public class ConcreteProductA1 : IAbstractProductA
{
    public string UsefulFunctionA() => "The result of the product A1.";
}

public class ConcreteProductA2 : IAbstractProductA
{
    public string UsefulFunctionA() => "The result of the product A2.";
}

public interface IAbstractProductB
{
    string UsefulFunctionB();
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}

public class ConcreteProductB1 : IAbstractProductB
{
    public string UsefulFunctionB() => "The result of the product B1.";

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();
        return $"The result of the B1 collaborating with the ({result})";
    }
}

public class ConcreteProductB2 : IAbstractProductB
{
    public string UsefulFunctionB() => "The result of the product B2.";

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();
        return $"The result of the B2 collaborating with the ({result})";
    }
}

public class Client
{
    public void Main()
    {
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientMethod(new ConcreteFactory1());
        Console.WriteLine();

        Console.WriteLine("Client: Testing the same client code with the second factory type...");
        ClientMethod(new ConcreteFactory2());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();

        Console.WriteLine(productB.UsefulFunctionB());
        Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
}