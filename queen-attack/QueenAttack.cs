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
    public static bool CanAttack(Queen white, Queen black)
    {
        if (white == null || black == null)
            throw new ArgumentNullException();

        if (white.Row == black.Row
         && white.Column == black.Column)
            throw new ArgumentException();

        if (white.Row == black.Row 
         || white.Column == black.Column)
            return true;

        var row = white.Row - black.Row;
        var column = white.Column - black.Column;
        if (row < 0)
            row = row * -1;
        if (column < 0)
            column = column * -1;

        return (row == column);
    }
}