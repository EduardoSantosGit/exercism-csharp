using System;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        List<int> lista = new List<int>();

        for(int i = 2;i<=limit;i++){
            lista.Add(i);
        }

        for(int i=1;i<lista.Count;i++){
            if(lista[i] % i == 0){
                lista.Remove(i);
            }
        }
        return lista.ToArray();
    }
}