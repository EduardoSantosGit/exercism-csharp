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
            var contador = 0;
            for(int i=0;i<_input.Length;i++){
                if(_input[i] == '\''){
                    contador += 1;
                }
            }
            return contador +1;   
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
        _arrayCube = _input.Split('\n');
        for(int i=0;i<_arrayCube.Length;i++){
            if(Int32.Parse(_arrayCube[i]) == row){
                _rows = new int [] {Int32.Parse(_arrayCube[i])};
            }
        }
        Console.WriteLine(_rows);
        return _rows;
    }   

    public int[] Col(int col)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}