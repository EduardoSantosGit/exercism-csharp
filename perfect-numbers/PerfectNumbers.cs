using System;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        /* 
        int acumulador = 0;
        for(int i=1;i<number;i++){
            if(number % i == 0){
                acumulador += i;
            }
        }*/

        var accumulator = Enumerable.Range(1, number - 1).Where(x => number % x == 0).Sum();

        Classification classification = Classification.Deficient;

        if (accumulator == number)
        {
            classification = Classification.Perfect;
        }
        else if (accumulator > number)
        {
            classification = Classification.Abundant;
        }
        return classification;
    }
}
