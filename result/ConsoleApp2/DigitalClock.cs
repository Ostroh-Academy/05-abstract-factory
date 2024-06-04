namespace ConsoleApp2;

public class DigitalClock : IDigitalClock
{
    public void DisplayTime()
    {
        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    }
}