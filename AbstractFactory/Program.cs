using AbstractFactory.Entities;
using AbstractFactory.Entities.Interfaces;

namespace AbstractFactory;

public static class Program
{
    private static void Main()
    {
        IAnimalFactory domesticFactory = new DomesticAnimalFactory();
        
        var domesticCat = domesticFactory.CreateCat();
        domesticCat.Speak(); 
        domesticCat.Eat();   
        domesticCat.Sleep(); 
        domesticCat.Purr();  
        domesticCat.Scratch(); 
        
        var domesticDog = domesticFactory.CreateDog();
        domesticDog.Speak(); 
        domesticDog.Eat();   
        domesticDog.Sleep(); 
        domesticDog.WagTail(); 
        domesticDog.Fetch();  
        
        
        IAnimalFactory wildFactory = new WildAnimalFactory();
        
        var wildCat = wildFactory.CreateCat();
        wildCat.Speak(); 
        wildCat.Eat();   
        wildCat.Sleep(); 
        wildCat.Purr();  
        wildCat.Scratch();
        
        var wildDog = wildFactory.CreateDog();
        wildDog.Speak();  
        wildDog.Eat();   
        wildDog.Sleep(); 
        wildDog.WagTail(); 
        wildDog.Fetch();  

        Console.ReadLine();
    }
}