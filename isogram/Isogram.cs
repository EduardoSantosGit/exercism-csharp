using System;

public static class Isogram
{   
    public static bool IsIsogram(string word)
    {   
        if(word.Length == 0) return true;
        
        int contador = 0;
        word = word.Replace("-","").Replace(" ","");
        for(int i=0;i<word.Length;i++){
            for(int j=0;j<word.Length;j++){
                if(word[i] == word[j]){
                    contador += 1;
                }
            }
        }
        if(contador > 1){
            return true;
        }
        return false;
    }
}
