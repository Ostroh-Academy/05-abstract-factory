using ConsoleApp2;

var factory = new ClockFactory();

var digitalClock = factory.CreateDigitalClock();
var analogClock = factory.CreateAnalogClock();

// Відображення часу
Console.WriteLine("Digital Clock:");
digitalClock.DisplayTime();

Console.WriteLine("\nAnalog Clock:");
analogClock.DisplayTime();