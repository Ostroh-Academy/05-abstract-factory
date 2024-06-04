namespace ConsoleApp2;

public class AnalogClock : IAnalogClock
{
    public void DisplayTime()
    {
        Console.WriteLine(DateTime.Now.ToString("hh:mm:ss tt"));
    }
}