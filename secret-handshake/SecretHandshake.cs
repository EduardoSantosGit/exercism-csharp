using System;
using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{
    private static List<string> _shakes = new List<string>();               
    public static string[] Commands(int commandValue)
    {   
        var _shakes = new List<string>();
            var reverse = false;
            if (commandValue >= 16){
                reverse = true;
                commandValue -= 16;
            }
            if (commandValue >= 8){
                _shakes.Add("jump");
                commandValue -= 8;
            }
            if (commandValue >= 4){
                _shakes.Add("close your eyes");
                commandValue -= 4;
            }
            if (commandValue >= 2){
                _shakes.Add("double blink");
                commandValue -= 2;
            }
            if (commandValue == 1){
                _shakes.Add("wink");
            }
            if (reverse) {
                return _shakes.ToArray();
            }    
            _shakes.Reverse();
            return _shakes.ToArray();
    }
}
