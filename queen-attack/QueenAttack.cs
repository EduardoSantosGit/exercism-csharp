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

        Dictionary<int, int> tabuleiro = new Dictionary<int, int>();
        bool resposta = false;
        for(int i =0;i<=8;i++){
            for(int j=0;j<=8;j++){
                tabuleiro.Add(i,j);
            }
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