using System;
using System.Linq;

public class Matrix
{
    private string _input;

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
           return _input.Split('\n').Select(x => x.Split(' ').Count()).First();
        }
    }

    public int[] Row(int row)
    {
        return _input.Split('\n').Select(x => x.Split(' ')).Select(x => x)
                            .ElementAt(row).Select(x => Convert.ToInt32(x)).ToArray();
    }

    public int[] Col(int col)
    {
        return _input.Split('\n').Select(x => x.Split(' ')).Select(x => x)
                     .Select(x => x[col]).Select(x => Convert.ToInt32(x)).ToArray();
    }
}