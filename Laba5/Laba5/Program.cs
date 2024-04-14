using Laba5.Factories;
using Laba5.Models;

IHospitalFactory fieldHospitalFactory = new FieldHospitalFactory();
Hospital fieldHospital = fieldHospitalFactory.CreateHospital();
Console.WriteLine(fieldHospital);

IHospitalFactory brickHospitalFactory = new BrickHospitalFactory();
Hospital brickHospital = brickHospitalFactory.CreateHospital();
Console.WriteLine(brickHospital);
