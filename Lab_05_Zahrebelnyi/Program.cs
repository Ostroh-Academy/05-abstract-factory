using System;
using Lab_05_Zahrebelnyi;

public class App
{
    private IUIFactory _factory;

    public App(IUIFactory factory)
    {
        _factory = factory;
    }

    public void CreateButton()
    {
        Console.WriteLine("Enter button width:");
        string buttonWidth = Console.ReadLine();

        Console.WriteLine("Enter button height:");
        string buttonHeight = Console.ReadLine();

        Console.WriteLine("Enter button font:");
        string buttonFont = Console.ReadLine();

        Console.WriteLine("Enter button text:");
        string buttonText = Console.ReadLine();

        _factory.CreateButton(buttonWidth, buttonHeight, buttonFont, buttonText);
    }

    public void CreateTextField()
    {
        Console.WriteLine("Enter text field width:");
        string textFieldWidth = Console.ReadLine();

        Console.WriteLine("Enter text field height:");
        string textFieldHeight = Console.ReadLine();

        Console.WriteLine("Enter text field font:");
        string textFieldFont = Console.ReadLine();

        _factory.CreateTextField(textFieldWidth, textFieldHeight, textFieldFont);
    }

    public static void Main()
    {
        var darkElementFactory = new App(new DarkUIFactory());
        var lightElementFactory = new App(new LightUIFactory());

        Console.WriteLine("Select theme:");
        Console.WriteLine("1. Dark");
        Console.WriteLine("2. Light");
        int theme = int.Parse(Console.ReadLine());

        Console.WriteLine("Select element:");
        Console.WriteLine("1. Button");
        Console.WriteLine("2. Text Field");
        int item = int.Parse(Console.ReadLine());

        switch (theme)
        {
            case 1:
                switch (item)
                {
                    case 1:
                        darkElementFactory.CreateButton();
                        break;
                    case 2:
                        darkElementFactory.CreateTextField();
                        break;
                }
                break;
            case 2:
                switch (item)
                {
                    case 1:
                        lightElementFactory.CreateButton();
                        break;
                    case 2:
                        lightElementFactory.CreateTextField();
                        break;
                }
                break;
        }
    }
}