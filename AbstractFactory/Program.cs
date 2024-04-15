using AbstractFactory.Entity;
using AbstractFactory.Entity.Interfaces;

namespace AbstractFactory;

public static class Program
{
    private static void Main()
    {
        IMatrixFactory matrix2DFactory = new Matrix2DFactory();
        var matrix2D = matrix2DFactory.CreateMatrix(3, 3);
        matrix2D.Fill(1, 2, 3, 4, 5, 6, 7, 8, 9);
        Console.WriteLine("\n2D matrix:");
        Console.WriteLine(matrix2D);
        
        IMatrixFactory matrix3DFactory = new Matrix3DFactory();
        var matrix3D = matrix3DFactory.CreateMatrix(2, 3, 2);
        matrix3D.Fill(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
        Console.WriteLine("\n3D matrix:");
        Console.WriteLine(matrix3D);

        var matrixToAdd = matrix2DFactory.CreateMatrix(3, 3);
        matrixToAdd.Fill(10, 2, 3, 4, 7, 6, -7, 8, -9);
        var resultMatrix = matrix2D.Add(matrixToAdd);

        Console.WriteLine("Result matrix after adding:");
        Console.WriteLine(resultMatrix);

        var matrixToMultiply = matrix2DFactory.CreateMatrix(3, 3);
        matrixToMultiply.Fill(10, -2, 1, 4, 3, 6, 7, -8, 2);
        resultMatrix = matrix2D.Multiply(matrixToMultiply);

        Console.WriteLine("\nResult matrix after multiplication:");
        Console.WriteLine(resultMatrix);

        resultMatrix = matrix2D.Transpose();
        Console.WriteLine("\nResult matrix after transposition:");
        Console.WriteLine(resultMatrix);
    }
}