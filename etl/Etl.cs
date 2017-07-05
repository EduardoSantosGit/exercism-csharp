using System;
using System.Collections.Generic;

public static class ETL
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> old)
    {   
        //recode
        Dictionary<string,int> hashResult = new Dictionary<string,int>();

        foreach (var key in old){
             foreach(var res in key.Value){
                hashResult.Add(res.ToLower(), key.Key);
             }    
        }
        return hashResult;
        
        //antigo
        /*Dictionary<string,int> hashResult = new Dictionary<string,int>();
        List<string> letras = new List<string>();
        foreach (var key in old){
            letras.AddRange(key.Value);
            foreach(var res in letras){
                hashResult.Add(res.ToLower(), key.Key);
            }
            letras.Clear();
        }
        return hashResult;*/

    }
}