namespace Laba5.Models;

public class Hospital
{
    private string Structure { get; set; }
    private int WardsAmount { get; set; }
    private int DepartmetsAmount { get; set; }

    public Hospital(string structure, int wardsAmount, int departmentsAmount)
    {
        Structure = structure;
        WardsAmount = wardsAmount;
        DepartmetsAmount = departmentsAmount;
    }

    public override string ToString()
    {
        return $"Hospital consists of {Structure} has {WardsAmount} wards and {DepartmetsAmount} departments.";
    }
}