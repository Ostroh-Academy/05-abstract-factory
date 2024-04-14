using Laba5.Models;

namespace Laba5.Factories;

public class BrickHospitalFactory : IHospitalFactory
{
    public Hospital CreateHospital()
    {
        return new Hospital("Brick buildings", 10, 8);
    }
}
