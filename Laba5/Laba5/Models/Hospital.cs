namespace Laba5.Models;

public class Hospital
{
    private string _structure;
    private int _wardsAmount;
    private int _departmetsAmount;

    public Hospital(string structure, int wardsAmount, int departmentsAmount)
    {
        _structure = structure;
        _wardsAmount = wardsAmount;
        _departmetsAmount = departmentsAmount;
    }

    public override string ToString()
    {
        return $"Hospital consists of {_structure} has {_wardsAmount} wards and {_departmetsAmount} departments.";
    }
}