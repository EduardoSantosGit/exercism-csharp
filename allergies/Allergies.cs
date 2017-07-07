using System;
using System.Collections.Generic;

public class Allergies
{   
    private int _mask;
    private readonly Dictionary<int,string> _allergies = new Dictionary<int,string>()
                     {{1, "eggs"},{2,"peanuts"},{4,"shellfish"},{8,"strawberries"},{16,"tomatoes"},
                     {32,"chocolate"},{64,"pollen"},{128,"cats"}};
    public Allergies(int mask){
        _mask = mask;
    }

    public bool AllergicTo(string allergy)
    {
        if(_mask < 1){
            return false;
        }

        bool _control = false;
        foreach(var item in _allergies){
            if(allergy == item.Value){
                if(_mask >= item.Key){
                    _mask = _mask - item.Key;
                    _control = true;
                }  
            }
        }
        return _control;
    }

    public IList<string> List()
    {
        var _lstAllergies = new List<string>();
        foreach(var item in _allergies){
            if(_mask > 0){
                if(_mask >= item.Key){
                    _lstAllergies.Add(item.Value);
                    _mask = _mask - item.Key;
                }
            }
        }
        return _lstAllergies;
    }
}