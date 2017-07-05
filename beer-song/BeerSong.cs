using System;

public static class BeerSong
{
    public static string Verse(int number)
    {
        string primeiroVerso = "00 bottles of beer on the wall, 00 bottles of beer.";
        string segundoVerso = "Take one down and pass it around, 00 bottles of beer on the wall.";
        string terceiroVerso = "No more bottles of beer on the wall, no more bottles of beer.";
        string quartoVerso = "Go to the store and buy some more, 99 bottles of beer on the wall.";

        primeiroVerso = primeiroVerso.Replace("00",number.ToString())
        + "\n" + segundoVerso.Replace("00",(number-1).ToString()) + "\n";
        
        return primeiroVerso;
    }

    public static string Verses(int begin, int end)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}