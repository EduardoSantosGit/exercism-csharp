using System;
using System.Linq;

public class Matrix
{
    private string _input;
    private string[] _arrayCube;
    private int[] _rows;
    private int _row;
    public Matrix(string input)
    {
        _input = input;
    }

    public int Rows
    {
        get
        {
            return _input.Replace(" ", "").Split('\n').Count();
        }
    }

    public int Cols
    {
        get
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }

    public int[] Row(int row)
    {
        _row = row;
        return _input.Split('\n').Select(x => x.Split(' ')).Select(x => x)
                            .ElementAt(_row).Select(x => Convert.ToInt32(x)).ToArray();
    }

    public int[] Col(int col)
    {
        return _input.Split('\n').Select(x => x.Split(' ')).Select(x => x)
                     .Select(x => x[_row]).Select(x => Convert.ToInt32(x)).ToArray();
    }
}