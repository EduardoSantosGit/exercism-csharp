using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string resposta = "";

        if (number % 3 == 0){
            resposta += "Pling"; 
        }
        if (number % 5 == 0){
            resposta += "Plang";
        }
        if (number % 7 == 0){
            resposta += "Plong";
        }
            
        if (resposta == "")
            resposta = number.ToString();
            
        return resposta;
    }
}