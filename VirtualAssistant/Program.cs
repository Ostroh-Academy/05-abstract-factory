

using VirtualAssistant.Classes;
using VirtualAssistant.Interfaces;

class Program
{
    static void InteractWithAssistant(AssistantFactory factory)
    {
        IVirtualAssistant assistant = factory.CreateAssistant();
        Console.WriteLine(assistant.sayHi());
        Console.WriteLine(assistant.sayBye());
    }

    static void Main(string[] args)
    {
        EnglishAssistantFactory englishFactory = new EnglishAssistantFactory();
        FrenchAssistantFactory frenchFactory = new FrenchAssistantFactory();
        SpanishAssistantFactory spanishFactory = new SpanishAssistantFactory();

        Console.WriteLine("English Assistant:");
        InteractWithAssistant(englishFactory);

        Console.WriteLine();

        Console.WriteLine("French Assistant:");
        InteractWithAssistant(frenchFactory);

        Console.WriteLine();

        Console.WriteLine("Spanish Assistant:");
        InteractWithAssistant(spanishFactory);
    }
}