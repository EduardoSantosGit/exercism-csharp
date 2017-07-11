using System;

public static class Pangram{
    public static bool IsPangram(string input)
    {  
       input = formataInput(input);
       var letter = "abcdefghijklmnopqrstuvwxyz";
       var answer = false;
       var accumulator = 0;
       for(var i=0;i<letter.Length;i++){
          if(input.Contains(letter[i].ToString())){
                accumulator += 1;
            }
       }
       if(accumulator > 25){
            answer = true;
       } 
       return answer;
    }

    public static string formataInput(string input){
       var accents = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
       var noAccents = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc"; 
       for (var i = 0; i < accents.Length; i++){
        input = input.Replace(accents[i].ToString(), noAccents[i].ToString());
       }
       return input.Trim().Replace(".","").Replace("\"","").Replace("_","").Replace("/","").Replace(" ","").ToLower();
    }
}
