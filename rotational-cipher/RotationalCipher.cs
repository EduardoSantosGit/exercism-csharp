using System;
using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {   
        var numbers = "1234567890";
        var word = "";
        for(int x = 0; x < text.Length; x++){
            if(text[x] == ' '){
                word += " ";
            }
            else {
                if(numbers.Contains(text[x])){
                    word += text[x];
                }
                else {
                    char letterPosition = (char)(text[x] + shiftKey);
                    if (letterPosition > 'z')
                        word += (char)(text[x] - (26-shiftKey));
                    else
                        word += (char)(text[x] + shiftKey);
                    }
                }
                
            }
            
        return word;
    }
}