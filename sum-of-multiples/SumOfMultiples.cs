using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int To(IEnumerable<int> multiples, int max)
    {   
        List<int> numList = new List<int>();
        foreach (int num in multiples){
            for (int i = 0; i < max; i++)
            {
                if (i % num == 0 && !numList.Contains(i))
                    numList.Add(i);
            }
        }
        return numList.Aggregate((a ,b) => a + b);

        //for(int i=0;i<numList.Count;i++){
         //   result += numList[i];
       // }
        //return result;
    }
}