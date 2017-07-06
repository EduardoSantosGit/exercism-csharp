using System;

public static class BinarySearch
{
    public static int Search(int[] input, int target){
        int retorno = 0;
        int meio = 0;
        int cont = 0;
        if(input.Length > 0){
            if(input.Length > 2/*input.Length % 2 == 0*/){
                meio = input.Length / 2;
                if(input[meio] == target){
                    retorno = meio;
                    cont += 1;
                }
                else {
                    if(target > input[meio]){
                        for(int i=meio;i<input.Length;i++){
                            if(input[i] == target){
                                retorno = i;
                                cont += 1;
                            } 
                        }
                    }
                    else {
                        for(int i=0;i<meio;i++){
                            if(input[i] == target){
                                retorno = i;
                                cont += 1;
                            }
                        }
                    }
                }
            }
            else {
                    for(int i=0;i<input.Length;i++){
                        if(input[i] == target){
                            retorno = i;
                            cont += 1;
                        }
                        else {
                            retorno = -1;
                        }
                    }
            }
        }
        else {
            retorno = -1;
        }
        if(cont == 0){
            retorno = -1;
        }

        return retorno;
    }
}