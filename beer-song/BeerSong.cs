using System;

public static class BeerSong
{   
    public static string Verse(int number)
    {   
        string verso = "";
        if(number > 0){
            verso = montaPrimeiraLinha(number) + "\n" + montaSegundaLinha(number) + "\n";
        }
        else {
            return "No more bottles of beer on the wall, no more bottles of beer.\n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall.\n";
        }
        return verso;
    }

    public static string Verses(int begin, int end)
    {   
        string frase = "";
        int contador = begin - end;
        for(int i=0;i<=contador;i++){
            if(begin-i != 0){
                if(i == 0){
                    frase += montaPrimeiraLinha(begin - i) + "\n" + montaSegundaLinha(begin - i) + "\n";
                }
                else {
                    frase += "\n" + montaPrimeiraLinha(begin - i) + "\n" + montaSegundaLinha(begin - i) + "\n";
                }
            }
            else {
                frase += "\n" + "No more bottles of beer on the wall, no more bottles of beer.\n" +
                            "Go to the store and buy some more, 99 bottles of beer on the wall.\n";
            }
        }
        return frase;
    }

    public static string montaPrimeiraLinha(int num){
        string linha = "00 bottles of beer on the wall, 00 bottles of beer.";
        if(num > 1){
            linha = linha.Replace("00",num.ToString());
        }
        else {
            linha = linha.Replace("00",num.ToString()).Replace("bottles","bottle");
        }
        return linha;
    }

    public static string montaSegundaLinha(int num){
       
       string linha = "Take one down and pass it around, 00 bottles of beer on the wall.";
       int aux = num-1;

       if(num == 1){
            linha = "Take it down and pass it around, no more bottles of beer on the wall.";
            return linha;
       }

       if(aux > 1){
          linha = linha.Replace("00",aux.ToString());     
       }
       else if (aux == 1){
          linha = linha.Replace("00",aux.ToString()).Replace("bottles","bottle"); 
       }
       else {
          linha = linha.Replace("00","no").Replace("bottles","bottle");
       }
       return linha;
    }



}