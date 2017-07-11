using System;
using System.Collections.Generic;
using System.Linq;
public static class Scrabble
{  
    public static int Score(string input)
    {   
        //refactor code
        if(input == null || input == "") return 0;
        
        Dictionary<int,List<char>> hashmap = new Dictionary<int, List<char>>()
        {
            {1, new List<char> {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'}},
            {2, new List<char> {'D','G'}},
            {3, new List<char> {'B', 'C', 'M', 'P'}},
            {4, new List<char> {'F', 'H', 'V', 'W', 'Y'}},
            {5, new List<char> {'K'}},
            {8, new List<char> {'J','X'}},
            {10, new List<char> {'Q','Z'}}
        };

        return hashmap.Sum(key => key.Key * input.ToUpper().Count(value => key.Value.Contains(value)));
    }
}