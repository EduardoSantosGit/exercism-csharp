using System;

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
        if(white.Row == black.Row){
            if(white.Column == black.Column){
                throw new ArgumentException();
            }
        }
        return false;
    }
}