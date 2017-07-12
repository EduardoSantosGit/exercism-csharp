﻿using System;
using System.Linq;

public static class Squares
{
    public static int SquareOfSums(int max)
    {  
        var sum = Enumerable.Range(1, max).Sum();
        return sum * sum;
        /*
        int sqsum = 0;
        for(int i =1;i<= max;i++){
            sqsum += i;
        }
        return sqsum * sqsum; */
    }

    public static int SumOfSquares(int max)
    {   
        return Enumerable.Range(1, max).Sum(x => x * x);
        
        /*int sumsq = 0;
        for(int i = 1; i <= max; i++){
            sumsq += i * i;
        }
        return sumsq;*/
    }

    public static int DifferenceOfSquares(int max)
    {
        return SquareOfSums(max) - SumOfSquares(max);
    }
}