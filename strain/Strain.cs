using System;
using System.Collections.Generic;
using System.Linq;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {   
        return collection.Where(x => predicate(x));
    }    


    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return collection.Where(x => !predicate(x));
    }
}