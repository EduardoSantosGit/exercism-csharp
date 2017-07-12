using System;
using System.Collections.Generic;
using System.Linq;

public class DNA
{
    private string _sequence;
    public DNA(string sequence)
    {
        _sequence = sequence;
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
        if (_sequence.Where(x => x == nucleotide).Count() == 0 
             && !nucleotide.Equals('A') && !nucleotide.Equals('T')
             && !nucleotide.Equals('C') && !nucleotide.Equals('G'))
            throw new InvalidNucleotideException();

        return _sequence.Where(x => x == nucleotide).Count();

        /* 
        int resposta = 0;
        for(int i=0;i<sequencia.Length;i++){
            if(sequencia[i].Equals(nucleotide)){
                resposta += 1;
            }
        }*/
        /*if(answer == 0){
            if(!nucleotide.Equals('A') && !nucleotide.Equals('T')
            && !nucleotide.Equals('C') && !nucleotide.Equals('G')){
                throw new InvalidNucleotideException();
            } 
        }
        return answer;*/
    }
}

public class InvalidNucleotideException : Exception { }
