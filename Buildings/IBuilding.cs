namespace Buildings
{
    public interface IBuilding
    {
        string Name { get; }
        string Location { get; }
        double TotalArea { get; }
        int Floors { get; }
        void DisplayInfo();
    }
}
