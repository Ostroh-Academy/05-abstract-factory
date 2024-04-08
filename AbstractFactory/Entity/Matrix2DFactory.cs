using AbstractFactory.Entity.Interfaces;

namespace AbstractFactory.Entity;

public class Matrix2DFactory : IMatrixFactory
{
    public IMatrix CreateMatrix(params int[] dimensions)
    {
        if (dimensions.Length != 2)
            throw new ArgumentException("To create Matrix2D, dimensions for a two-dimensional matrix are needed.");

        return new Matrix2D(dimensions[0], dimensions[1]); 
    }
}