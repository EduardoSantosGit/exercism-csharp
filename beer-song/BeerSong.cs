﻿using System;

public static class BeerSong
{   
    public static string Verse(int number)
    {
        return montaFrase(number);
    }

    public static string Verses(int begin, int end)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static string montaFrase(int num){
        string primeiroVerso = "00 bottles of beer on the wall, 00 bottles of beer.";
        string segundoVerso = "Take one down and pass it around, 00 bottles of beer on the wall.";
        string terceiroVerso = "No more bottles of beer on the wall, no more bottles of beer.";
        string quartoVerso = "Go to the store and buy some more, 99 bottles of beer on the wall.";

        int aux = num -1;

        if(num > 0){
            if(aux > 1){
                primeiroVerso = primeiroVerso.Replace("00",num.ToString())
                + "\n" + segundoVerso.Replace("00",aux.ToString()) + "\n";
            }
            else {
                primeiroVerso = primeiroVerso.Replace("00",num.ToString())
                + "\n" + segundoVerso.Replace("00",aux.ToString()).Replace("bottles","bottle") + "\n";
            }
        }
        return primeiroVerso;
    }
}