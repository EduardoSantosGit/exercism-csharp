using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Translate(string codon)
    {   

        List<string> result = new List<string>();
 
        Dictionary<string,string> hashProtein = new Dictionary<string,string>();
        hashProtein.Add("AUG","Methionine");
        hashProtein.Add("UUU","Phenylalanine");
        hashProtein.Add("UUC","Phenylalanine");
        hashProtein.Add("UUA","Leucine");
        hashProtein.Add("UUG","Leucine");
        hashProtein.Add("UCU","Serine");
        hashProtein.Add("UCC","Serine");
        hashProtein.Add("UCA","Serine");
        hashProtein.Add("UCG","Serine");
        hashProtein.Add("UAU","Tyrosine");
        hashProtein.Add("UAC","Tyrosine");
        hashProtein.Add("UGU","Cysteine");
        hashProtein.Add("UGC","Cysteine");
        hashProtein.Add("UGG","Tryptophan");
        hashProtein.Add("UAA","STOP");
        hashProtein.Add("UAG","STOP");
        hashProtein.Add("UGA","STOP");

        int tamanho = (codon.Length / 3);
        bool auxilio = false;

        for(int i=0;i<tamanho;i++){
            if(auxilio == false){
                foreach(var item in hashProtein){
                if(item.Key == codon.Substring(i*3,3)){
                    if(item.Value.Equals("STOP")){
                       auxilio = true;
                    } else {
                        result.Add(item.Value);
                    } 
                }
            }
            }
        }

        if(result.Count == 0){
            throw new Exception();
        }

        return result.ToArray();
    }
}