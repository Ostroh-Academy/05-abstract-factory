using AbstractFactory.Entity.Interfaces;

namespace AbstractFactory.Entity;

public class Matrix3DFactory : IMatrixFactory
{
    public IMatrix CreateMatrix(params int[] dimensions)
    {
        if (dimensions.Length != 3)
            throw new ArgumentException("To create Matrix3D, dimensions for a three-dimensional matrix are needed.");

        return new Matrix3D(dimensions[0], dimensions[1], dimensions[2]); 
    }
}