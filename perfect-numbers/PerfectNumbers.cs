using System;

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
        if(number <= 0){
            throw new ArgumentOutOfRangeException();
        }
        
        int acumulador = 0;
        for(int i=1;i<number;i++){
            if(number % i == 0){
                acumulador += i;
            }
        }

        Classification classification;

        if(acumulador == number){
            classification = Classification.Perfect;
        }
        else if (acumulador > number){
            classification = Classification.Abundant;
        }
        else {
            classification = Classification.Deficient;
        }
        return classification;
    }
}
