namespace AbstractFactory.Entity.Interfaces;

public interface IMatrixFactory
{
    public abstract IMatrix CreateMatrix(params int[] dimensions);
}