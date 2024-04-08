using System.Text;
using AbstractFactory.Entity.Interfaces;

namespace AbstractFactory.Entity;

public class Matrix3D : IMatrix
{
    private readonly double[,,] _data;
    
    public int Rows  => _data.GetLength(0);
    public int Columns => _data.GetLength(1);
    private int Depth => _data.GetLength(2);

    public Matrix3D(int rows, int columns, int depth)
    {
        _data = new double[rows, columns, depth];
    }
    
    public void Fill(params int[] data)
    {
        if (data == null)
            throw new ArgumentNullException(nameof(data));

        if (data.Length != Rows * Columns * Depth)
            throw new ArgumentException("The length of the input array must match the number of elements in the matrix", nameof(data));

        var index = 0;
        for (var i = 0; i < Rows; i++)
        {
            for (var j = 0; j < Columns; j++)
            {
                for (var k = 0; k < Depth; k++)
                {
                    _data[i, j, k] = data[index];
                    index++;
                }
            }
        }
    }

    public IMatrix Add(IMatrix matrix)
    {
        if (matrix == null)
            throw new ArgumentNullException(nameof(matrix));

        if (matrix is not Matrix3D other)
            throw new ArgumentException("Matrix must be of type Matrix3D", nameof(matrix));

        if (Rows!= other.Rows || Columns!= other.Columns)
            throw new ArgumentException("Matrices must have the same dimensions", nameof(matrix));

        var result = new Matrix3D(Rows, Columns, 1);

        for (var i = 0; i < Rows; i++)
        {
            for (var j = 0; j < Columns; j++)
            {
                for (var k = 0; k < 1; k++)
                {
                    result._data[i, j, k] = _data[i, j, k] + other._data[i, j, k];
                }
            }
        }

        return result;
    }

    public IMatrix Multiply(IMatrix matrix)
    {
        if (matrix == null)
            throw new ArgumentNullException(nameof(matrix));

        if (matrix is not Matrix3D other)
            throw new ArgumentException("Matrix must be of type Matrix3D", nameof(matrix));

        if (Columns!= other.Rows)
            throw new ArgumentException("The number of columns in the first matrix must be equal to the number of rows in the second matrix", nameof(matrix));

        var result = new Matrix3D(Rows, other.Columns, 1);

        for (var i = 0; i < Rows; i++)
        {
            for (var j = 0; j < other.Columns; j++)
            {
                for (var k = 0; k < Columns; k++)
                {
                    result._data[i, j, 0] += _data[i, k, 0] * other._data[k, j, 0];
                }
            }
        }

        return result;
    }

    public IMatrix Transpose()
    {
        var result = new Matrix3D(Columns, Rows, 1);

        for (var i = 0; i < Rows; i++)
        {
            for (var j = 0; j < Columns; j++)
            {
                result._data[j, i, 0] = _data[i, j, 0];
            }
        }

        return result;
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        for (var k = 0; k < Depth; k++)
        {
            sb.AppendLine($"Depth {k + 1}:");
            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Columns; j++)
                {
                    sb.Append(_data[i, j, k]);
                    if (j < Columns - 1)
                    {
                        sb.Append("\t"); 
                    }
                }
                if (i < Rows - 1)
                {
                    sb.AppendLine(); 
                }
            }
            sb.AppendLine(); 
        }
        return sb.ToString();
    }

}