using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{   
    //code refactor
    public static Dictionary<string, string> _dictionary = new Dictionary<string, string>(){

        {"AUG" , "Methionine" },
        {"UUU" , "Phenylalanine" },{"UUC" , "Phenylalanine" },
        {"UUA","Leucine" },{"UUG" , "Leucine"},
        {"UCU" , "Serine"},{"UCC" ,"Serine" },{"UCA" ,"Serine" },{"UCG" ,"Serine" },
        {"UAU", "Tyrosine"},{"UAC" ,"Tyrosine"},
        {"UGU","Cysteine" },{"UGC" ,"Cysteine" },
        {"UGG","Tryptophan" },
        {"UAA", "Stop" },{"UAG" ,"Stop" },{"UGA", "Stop" }
    };

    public static string UnityCodon = "AAA";
    public static string[] Translate(string codon)
    {   
        List<string> proteins = new List<string>();

        for (int i = 0; i < codon.Length; i += 3){
            var molecule = string.Concat(codon[i], codon[i + 1], codon[i + 2]);
            if (!_dictionary.ContainsKey(molecule))
            {
                throw new Exception();
            }
            var protein = _dictionary[molecule];
            if (protein == "Stop" || protein == "Stop" || protein == "Stop")
            {
                break;
            }
            proteins.Add(protein);
        }
        return proteins.ToArray();
    }
}