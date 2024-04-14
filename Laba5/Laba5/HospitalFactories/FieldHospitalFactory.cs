using Laba5.Models;

namespace Laba5.Factories;

public class FieldHospitalFactory : IHospitalFactory
{
    public Hospital CreateHospital()
    {
        return new Hospital("Tents", 2, 2);
    }
}
