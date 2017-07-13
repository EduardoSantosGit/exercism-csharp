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
             return _input.Replace(" ","").Split('\n').Count();
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
        /* 
        foreach(var i in teste2){
            Console.WriteLine("array " + i[0] + " " + i[1] + " " + i[2]);
        }


        var teste = _input.Split('\n').Select(x => x.Split(' ')).Select(x => x);
                          //.Skip(0).Select(x => x).SelectMany(x => x).Select(a => a - '0').ToArray();
        foreach(var i in teste.Skip(0)){
            var t = i.SelectMany(x => x).Select(a => a - '0').ToArray();
            //Console.WriteLine("array" + t[1]);
        }

       
       return _input.Replace(" ","").Split('\n').Select(x => x)
                    .ElementAt(_row).ToCharArray().Select(a => a - '0').ToArray();*/
                    
       return _input.Split('\n').Select(x => x.Split(' ')).Select(x => x)
                           .ElementAt(_row).Select(x => Convert.ToInt32(x)).ToArray();                 
    }   

    public int[] Col(int col)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}