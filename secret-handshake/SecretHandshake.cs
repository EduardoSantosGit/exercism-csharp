using System;
using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{
    private static readonly Dictionary<int, string> _secrets = new Dictionary<int, string>()
                   {{1,"wink"}, {10,"double blink"},{100,"close your eyes"}, {1000,"jump"}};
    private static List<string> _shakes = new List<string>();               
    private static string _numberBinary;
    public static string[] Commands(int commandValue)
    {   
        while (commandValue > 0)
        {
            var _rest = (commandValue % 2);
            _numberBinary = _numberBinary + _rest.ToString();
            commandValue = commandValue / 2;
        }
        _numberBinary = new string(_numberBinary.ToCharArray().Reverse().ToArray());
        foreach(var item in _secrets){
            if(Convert.ToInt32(_numberBinary) >= item.Key){
                _shakes.Add(item.Value);
            }
        }
        return _shakes.ToArray();
    }
}
