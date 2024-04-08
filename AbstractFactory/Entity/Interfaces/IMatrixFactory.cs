namespace AbstractFactory.Entity.Interfaces;

public interface IMatrixFactory
{
    public IMatrix CreateMatrix(params int[] dimensions);
}