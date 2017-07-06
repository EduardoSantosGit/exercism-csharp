using System;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        List<int> numeros = new List<int>();
        List<int> primos = new List<int>();

        for(var i = 2; i <= limit; i++){
            numeros.Add(i);
        }
        foreach(int item in numeros){
            bool primo = true;
            foreach(var e in primos)
            {
                if(item % e == 0)
                {
                    primo = false;
                }
            }
            if(primo){
                primos.Add(item);
            }    
        }
        return primos.ToArray();
    }
}