using System;

public static class Squares
{
    public static int SquareOfSums(int max)
    {
        int sqsum = 0;
        for(int i =1;i<= max;i++){
            sqsum += i;
        }
        return sqsum * sqsum;
    }

    public static int SumOfSquares(int max)
    {
        int sumsq = 0;
        for(int i = 1; i <= max; i++){
            sumsq += i * i;
        }
        return sumsq;
    }

    public static int DifferenceOfSquares(int max)
    {
        return SquareOfSums(max) - SumOfSquares(max);
    }
}