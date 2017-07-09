using System;

public static class Bob
{   public static string Response(string statement)
    {
        if(verificaQuestoesSimbolos(statement)){
            return "Sure.";
        }
        else if (statement.Trim().Equals("")){
            return "Fine. Be that way!";
        }
        else if (!verificaLetraMinuscula(statement)){
            return "Whoa, chill out!";
        }
        else {
            return "Whatever.";
        }
    }

    public static bool verificaLetraMinuscula(this string value)
    {   
        int qtd = 0;

        for (int i = 0; i < value.Length; i++)
        {
            if(char.IsLetter(value[i])){
                qtd = qtd + 1;
            }
        }
        if(qtd > 0){
            for (int i = 0; i < value.Length; i++)
            {
                if(char.IsLower(value[i])){
                    return true;
                }
            }
        } else {
            return true;
        }
        return false;
    }

    public static bool verificaQuestoesSimbolos(this string value){
        int qtdLetras = 0;
        int qtdSimbolos = 0;
        int qtdLetrasMais = 0;        
        value = value.Trim();
        for (int i = 0; i < value.Length; i++){
            {
                if(char.IsLower(value[i])){
                    qtdLetras = qtdLetras + 1;
                }
                if(!char.IsLetter(value[i])){
                    qtdSimbolos = qtdSimbolos + 1;
                }
                if(char.IsUpper(value[i])){
                    qtdLetrasMais = qtdLetrasMais + 1;
                }
            }
        }
        if(qtdLetras > 0){
            if(value.EndsWith("?")){
                return true;
            }
        }
        else if(qtdSimbolos > 0 && qtdLetras > 0){
            if(value.EndsWith("?")){
                return true;
            }
        }
        else if (qtdSimbolos > 0 && qtdLetras == 0 && qtdLetrasMais == 0){
             if(value.EndsWith("?")){
                return true;
            }
        }

        return false;
    }
}