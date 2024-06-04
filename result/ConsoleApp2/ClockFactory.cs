namespace ConsoleApp2;

public sealed class ClockFactory : IClockFactory
{
    public IDigitalClock CreateDigitalClock()
    {
        return new DigitalClock();
    }

    public IAnalogClock CreateAnalogClock()
    {
        return new AnalogClock();
    }
}