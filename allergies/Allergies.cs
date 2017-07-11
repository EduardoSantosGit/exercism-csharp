using System;
using System.Collections.Generic;
using System.Linq;

public class Allergies
{   
    private int _mask;
    private readonly Dictionary<string,int> _allergies = new Dictionary<string,int>()              
            {{"eggs",1},{"peanuts",2},{"shellfish",4},{"strawberries",8},{"tomatoes",16},
            {"chocolate",32},{"pollen",64},{"cats",128}};
    public Allergies(int mask){
        _mask = mask;
    }

    public bool AllergicTo(string allergy)
    {   
        int av = _allergies[allergy];
        if ( ( _mask & av ) != 0 ) return true;
        return false;
    }

    public IList<string> List(){   
        
        var _results = new List<string>();

        foreach ( var al in _allergies) {
            if ( AllergicTo( al.Key ) ) {
                _results.Add( al.Key );
            }
        }
        return _results;
    }
}