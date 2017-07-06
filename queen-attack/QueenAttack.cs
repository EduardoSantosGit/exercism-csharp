using System;
using System.Collections.Generic;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class Queens
{
    public static bool CanAttack(Queen white, Queen black){

        List<int> lstRow = new List<int>();
        List<int> lstColumn = new List<int>();

        bool resposta = false;
        
        for(int i =1;i<=8;i++){
            lstRow.Add(i);
        }
        for(int i=1;i<=8;i++){
            lstColumn.Add(i);
        }

        if(white.Row == black.Row){
            resposta = true;        
        }
        if(white.Column == black.Column){
            resposta = true;
        }

        if(white.Row == black.Row){
            if(white.Column == black.Column){
                throw new ArgumentException();
            }
        }

        return resposta;
    }
}