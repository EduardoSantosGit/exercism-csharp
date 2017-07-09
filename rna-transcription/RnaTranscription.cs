using System;

public static class Complement
{
    public static string OfDna(string nucleotide)
    {
        String resposta = "";  
        
        for(int i =0;i<nucleotide.Length;i++){

            if(nucleotide[i].Equals('G')){
                resposta += "C";
            } 
            else if (nucleotide[i].Equals('C')){
                resposta += "G";
            }
            else if (nucleotide[i].Equals('T')){
                resposta += "A";
            }
            else if (nucleotide[i].Equals('A')){
                resposta += "U"; 
            }
            else {
                resposta += "U"; 
            }

        }
        return resposta;

    }
}