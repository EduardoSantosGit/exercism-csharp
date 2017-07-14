using System;
using System.Linq;

public static class LargestSeriesProduct{
    public static long GetLargestProduct(string digits, int span) 
    {   
        if(span > digits.Length) throw new ArgumentException();
        
        return Enumerable.Range(0,digits.Length - span + 1)
                            .Max(x => digits.Substring(x ,span))
                            .Select(x => (int)(x - '0'))
                            .Aggregate(1, (a,b) => a * b);                 
    }
}