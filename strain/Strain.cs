using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {   
        HashSet<T> hashResuslt = new HashSet<T>();
        foreach (var item in collection)
        {
           if(predicate(item)){
              hashResuslt.Add(item);
           }
        }
        return hashResuslt;
    }    


    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        HashSet<T> hashResuslt = new HashSet<T>();
        foreach (var item in collection)
        {
           if(!predicate(item)){
              hashResuslt.Add(item);
           }
        }
        return hashResuslt;
    }
}