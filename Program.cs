namespace AbstractFactoryProject;

// Системи майнінгу (GPU, ASIC, CPU, FPGA): Створити систему
// для вибору обладнання для майнінгу криптовалют залежно
// від алгоритму майнінгу, що максимізує прибутковість.

public class Program
{
    public static void Main(string[] args)
    {
        new Client().Main();
    }
}

public interface IMining
{
    void Mine();
}

public class GPUMining : IMining
{
    public void Mine() => Console.WriteLine("Mining with GPU!");
}

public class ASICMining : IMining
{
    public void Mine() => Console.WriteLine("Mining with ASIC!");
}

public class CPUMining : IMining
{
    public void Mine() => Console.WriteLine("Mining with CPU!");
}

public class FPGAMining : IMining
{
    public void Mine() => Console.WriteLine("Mining with FPGA!");
}

public interface IMiningFactory
{
    IMining CreateMining();
}

public class GPUMiningFactory : IMiningFactory
{
    public IMining CreateMining() => new GPUMining();
}

public class ASICMiningFactory : IMiningFactory
{
    public IMining CreateMining() => new ASICMining();
}

public class CPUMiningFactory : IMiningFactory
{
    public IMining CreateMining() => new CPUMining();
}

public class FPGAMiningFactory : IMiningFactory
{
    public IMining CreateMining() => new FPGAMining();
}

public class Client
{
    public void Main()
    {
        var factories = new List<IMiningFactory>()
        {
            new GPUMiningFactory(),
            new ASICMiningFactory(),
            new CPUMiningFactory(),
            new FPGAMiningFactory()
        };

        foreach (var item in factories)
        {
            Console.WriteLine($"Client: Testing client code with the {item.GetType().Name} factory type...");
            ClientMethod(item);
            Console.WriteLine();
        }
    }

    private void ClientMethod(IMiningFactory factory)
    {
        var f = factory.CreateMining();
        f.Mine();
    }
}