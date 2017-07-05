using System;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        List<bool> primos = new List<bool>();
        List<int> result = new List<int>();

        for(int i=0;i<=limit;i++){
            primos.Add(true);
        }
         
        for(int p = 2; p*p <=limit; p++)
        {
            if(primos[p] == true)
            {
                for(int i = p*2; i <= limit; i += p)
                    primos.Add(false);
            }
        }
        for(int i = 2; i <= limit; i++)
        {
            if(primos[i] == true)
               result.Add(i);
        }

        return result.ToArray();
    }
}