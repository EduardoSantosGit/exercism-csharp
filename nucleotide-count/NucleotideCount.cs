using System;
using System.Collections.Generic;

public class DNA
{   
    private string sequencia;
    public DNA(string sequence)
    {
        sequencia = sequence;
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            Dictionary<char, int> lstNucleotide = new Dictionary<char, int>();
            lstNucleotide.Add('A', Count('A'));
            lstNucleotide.Add('T', Count('T'));
            lstNucleotide.Add('C', Count('C'));
            lstNucleotide.Add('G', Count('G'));
            return lstNucleotide;
        }
    }

    public int Count(char nucleotide)
    {
        int resposta = 0;
        for(int i=0;i<sequencia.Length;i++){
            if(sequencia[i].Equals(nucleotide)){
                resposta += 1;
            }
        }
        if(resposta == 0){
            if(!nucleotide.Equals('A') && !nucleotide.Equals('T')
            && !nucleotide.Equals('C') && !nucleotide.Equals('G')){
                throw new InvalidNucleotideException();
            } 
        }
        return resposta;
    }
}

public class InvalidNucleotideException : Exception { }
