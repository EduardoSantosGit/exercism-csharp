using System;

public static class BinarySearch
{
    public static int Search(int[] input, int target){
        int retorno = 0;
        if(input.Length > 0){
            if(input.Length % 2 == 0){
                
            }
            else {
                if(input.Length > 2){

                }
                else {
                    for(int i=0;i<input.Length;i++){
                        if(input[i] == target){
                            retorno = i;
                        }
                    }
                }
            }
        }
        else {
            retorno = -1;
        }
        return retorno;
    }
}