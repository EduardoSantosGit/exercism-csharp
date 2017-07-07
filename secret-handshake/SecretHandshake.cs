using System;
using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{
    private static List<string> _shakes = new List<string>();               
    public static string[] Commands(int commandValue)
    {   
        var response = new List<string>();
            var reverse = false;
            if (commandValue >= 16){
                reverse = true;
                commandValue -= 16;
            }
            if (commandValue >= 8){
                response.Add("jump");
                commandValue -= 8;
            }
            if (commandValue >= 4){
                response.Add("close your eyes");
                commandValue -= 4;
            }
            if (commandValue >= 2){
                response.Add("double blink");
                commandValue -= 2;
            }
            if (commandValue == 1){
                response.Add("wink");
            }
            if (reverse) {
                return response.ToArray();
            }    
            response.Reverse();
            return response.ToArray();
    }
}
