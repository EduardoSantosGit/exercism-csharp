using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        ulong resposta = 1;
        for(int i=1;i<n;i++){
            resposta *= 2;
        }
        return resposta;
    }

    public static ulong Total()
    {       
         ulong valor = 1;
         ulong resposta = 1;
         for(int i=0;i<64;i++){
            valor *= 2;
            resposta += valor;
         }
         return resposta;
    }
}