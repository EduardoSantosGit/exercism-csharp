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
        
        for(int i =0;i<=7;i++){
            lstRow.Add(i);
        }
        for(int i=0;i<=7;i++){
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
        
        int row = white.Row - black.Row;
        int column = white.Column - black.Column;

        if(row == column){
            resposta = true;
        }

        return resposta;
    }
}