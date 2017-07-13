using System;
using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {  
        var word = "";
        for(int x = 0; x < text.Length; x++){
            char letterPosition = (char)(text[x] + shiftKey);
            if (letterPosition > 'z')
                word += (char)(text[x] - (26-shiftKey));
            else
                word += (char)(text[x] + shiftKey);
        }
        return word;
    }
}