using System;

// Абстрактний клас або інтерфейс для обладнання
public interface ISportsEquipment
{
    string GetName();
    string GetDescription();
    string GetEquipmentType();
    decimal GetPrice();
    void SetPrice(decimal price);
}

// Абстрактний клас або інтерфейс для фабрики
public interface ISportsEquipmentFactory
{
    ISportsEquipment CreateEquipment();
}

// Конкретний клас обладнання для футболу
public class Football : ISportsEquipment
{
    private decimal _price;

    public string GetName()
    {
        return "Футбольний м'яч";
    }

    public string GetDescription()
    {
        return "Цей м'яч призначений для гри у футбол.";
    }

    public string GetEquipmentType()
    {
        return "Футбольне обладнання";
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }
}

// Конкретна фабрика для футболу
public class FootballFactory : ISportsEquipmentFactory
{
    public ISportsEquipment CreateEquipment()
    {
        return new Football();
    }
}

// Конкретний клас обладнання для баскетболу
public class Basketball : ISportsEquipment
{
    private decimal _price;

    public string GetName()
    {
        return "Баскетбольний м'яч";
    }

    public string GetDescription()
    {
        return "Цей м'яч призначений для гри в баскетбол.";
    }

    public string GetEquipmentType()
    {
        return "Баскетбольне обладнання";
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }
}

// Конкретна фабрика для баскетболу
public class BasketballFactory : ISportsEquipmentFactory
{
    public ISportsEquipment CreateEquipment()
    {
        return new Basketball();
    }
}

// Конкретний клас обладнання для тенісу
public class Tennis : ISportsEquipment
{
    private decimal _price;

    public string GetName()
    {
        return "Тенісний м'яч";
    }

    public string GetDescription()
    {
        return "Цей м'яч призначений для гри в теніс.";
    }

    public string GetEquipmentType()
    {
        return "Тенісне обладнання";
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }
}

// Конкретна фабрика для тенісу
public class TennisFactory : ISportsEquipmentFactory
{
    public ISportsEquipment CreateEquipment()
    {
        return new Tennis();
    }
}

// Використання
public class Program
{
    public static void Main()
    {
        // Створення фабрики для футболу
        ISportsEquipmentFactory footballFactory = new FootballFactory();
        ISportsEquipment football = footballFactory.CreateEquipment();
        football.SetPrice(100); // Встановлення ціни 100
        Console.WriteLine(football.GetName()); // Виведе "Футбольний м'яч"
        Console.WriteLine(football.GetDescription()); // Виведе опис футбольного м'яча
        Console.WriteLine(football.GetEquipmentType()); // Виведе "Футбольне обладнання"
        Console.WriteLine(football.GetPrice()); // Виведе ціну 100

        // Створення фабрики для баскетболу
        ISportsEquipmentFactory basketballFactory = new BasketballFactory();
        ISportsEquipment basketball = basketballFactory.CreateEquipment();
        basketball.SetPrice(80); // Встановлення ціни 80
        Console.WriteLine(basketball.GetName()); // Виведе "Баскетбольний м'яч"
        Console.WriteLine(basketball.GetDescription()); // Виведе опис баскетбольного м'яча
        Console.WriteLine(basketball.GetEquipmentType()); // Виведе "Баскетбольне обладнання"
        Console.WriteLine(basketball.GetPrice()); // Виведе ціну 80

        // Створення фабрики для тенісу
        ISportsEquipmentFactory tennisFactory = new TennisFactory();
        ISportsEquipment tennis = tennisFactory.CreateEquipment();
        tennis.SetPrice(50); // Встановлення ціни 50
        Console.WriteLine(tennis.GetName()); // Виведе "Тенісний м'яч"
        Console.WriteLine(tennis.GetDescription()); // Виведе опис тенісного м'яча
        Console.WriteLine(tennis.GetEquipmentType()); // Виведе "Тенісне обладнання"
        Console.WriteLine(tennis.GetPrice()); // Виведе ціну 50
    }
}
