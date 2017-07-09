using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {  
       input = formataInput(input);
       string letras = "abcdefghijklmnopqrstuvwxyz";
       bool resposta = false;
       int acumulador = 0;
       for(int i=0;i<letras.Length;i++){
          if(input.Contains("" + letras[i])){
                acumulador += 1;
            }
       }
       if(acumulador > 25){
            resposta = true;
       } 
       return resposta;
    }

    public static string formataInput(string input){
       string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
       string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc"; 
       for (int i = 0; i < comAcentos.Length; i++){
        input = input.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
       }
       input = input.Trim().Replace(".","").Replace("\"","")
                    .Replace("_","").Replace("/","").Replace(" ","");
       input = input.ToLower();
       return input;
    }
}
