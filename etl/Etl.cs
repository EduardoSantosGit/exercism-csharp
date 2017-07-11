using System;
using System.Collections.Generic;
using System.Linq;

public static class ETL
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> old)
    {

        //recode
        // Dictionary<string, int> hashResult = new Dictionary<string, int>();

        // foreach (var key in old)
        // {
        //     foreach (var res in key.Value)
        //     {
        //         hashResult.Add(res.ToLower(), key.Key);
        //     }
        // }

        return old.SelectMany(e => e.Value.Select(s => new { k = s.ToLowerInvariant(), v = e.Key }))
                  .ToDictionary(x => x.k, x => x.v);
    }
}