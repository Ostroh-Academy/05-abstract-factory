namespace AbstractFactory.Entity.Interfaces;

public interface IMatrix 
{
    int Rows { get; }
    int Columns { get; }

    IMatrix Add(IMatrix matrix);
    IMatrix Multiply(IMatrix matrix);
    IMatrix Transpose();
    
    void Fill(params int[] data);
}