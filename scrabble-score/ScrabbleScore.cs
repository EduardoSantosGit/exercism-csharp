using System;
using System.Collections.Generic;
public static class Scrabble
{  
    public static int Score(string input)
    {
        Dictionary<int, List<char>> hashMap = new Dictionary<int, List<char>>();
        hashMap.Add(1, new List<char> {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'});
        hashMap.Add(2, new List<char> {'D','G'});
        hashMap.Add(3, new List<char> {'B', 'C', 'M', 'P'});
        hashMap.Add(4, new List<char> {'F', 'H', 'V', 'W', 'Y'});
        hashMap.Add(5, new List<char> {'K'});
        hashMap.Add(8, new List<char> {'J','X'});
        hashMap.Add(10, new List<char> {'Q','Z'});

        int contador = 0;

        if(input == null || input == ""){
            return contador;
        }

        input = input.ToUpper();
        for(int i=0;i<input.Length;i++){
           foreach(var item in hashMap){
               foreach(var letras in item.Value){
                   if(input[i] == letras){
                      contador += item.Key;
                   }
               }
           }
        }

        return contador;
    }
}