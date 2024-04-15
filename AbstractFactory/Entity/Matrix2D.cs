using System.Text;
using AbstractFactory.Entity.Interfaces;

namespace AbstractFactory.Entity;

public class Matrix2D : IMatrix
{
    private readonly double[,] _data;
    
    public int Rows => _data.GetLength(0);
    public int Columns =>_data.GetLength(1);

    public Matrix2D(int rows, int cols)
    {
        _data = new double[rows, cols];
    }

    public IMatrix Add(IMatrix matrix)
    {
        if (matrix == null)
            throw new ArgumentNullException(nameof(matrix));

        if (!(matrix is Matrix2D other))
            throw new ArgumentException("Matrix must be of type Matrix2D", nameof(matrix));

        if (Rows!= other.Rows || Columns!= other.Columns)
            throw new ArgumentException("Matrices must have the same dimensions", nameof(matrix));

        var result = new Matrix2D(Rows, Columns);

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                result._data[i, j] = _data[i, j] + other._data[i, j];
            }
        }

        return result;
    }

    public IMatrix Multiply(IMatrix matrix)
    {
        if (matrix == null)
            throw new ArgumentNullException(nameof(matrix));

        if (!(matrix is Matrix2D other))
            throw new ArgumentException("Matrix must be of type Matrix2D", nameof(matrix));

        if (Columns!= other.Rows)
            throw new ArgumentException("The number of columns in the first matrix must be equal to the number of rows in the second matrix", nameof(matrix));

        var result = new Matrix2D(Rows, other.Columns);

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < other.Columns; j++)
            {
                for (int k = 0; k < Columns; k++)
                {
                    result._data[i, j] += _data[i, k] * other._data[k, j];
                }
            }
        }

        return result;
    }

    public IMatrix Transpose()
    {
        var result = new Matrix2D(Columns, Rows);

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                result._data[j, i] = _data[i, j];
            }
        }

        return result;
    }

    public void Fill(params int[] data)
    {
        if (data == null)
            throw new ArgumentNullException(nameof(data));

        if (data.Length != Rows * Columns)
            throw new ArgumentException("The length of the input array must match the number of elements in the matrix", nameof(data));

        var index = 0;
        for (var i = 0; i < Rows; i++)
        {
            for (var j = 0; j < Columns; j++)
            {
                _data[i, j] = data[index];
                index++;
            }
        }
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        for (var i = 0; i < Rows; i++)
        {
            for (var j = 0; j < Columns; j++)
            {
                sb.Append(_data[i, j]);
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
        return sb.ToString();
    }

}