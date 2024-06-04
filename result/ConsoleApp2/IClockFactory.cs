namespace ConsoleApp2;

public interface IClockFactory
{
    IDigitalClock CreateDigitalClock();
    IAnalogClock CreateAnalogClock();
}