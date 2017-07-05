using System;
using System.Text;

public class Robot
{     
    private string resultado;
    private static Random random = new Random();

    public Robot(){
       this.Reset();
    }

    public string Name
    {
        get{
            return resultado;
        }
    }

    public void Reset()
    {   
        string old = this.resultado; 
        string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char ch1=characters[random.Next(characters.Length)];
        char ch2=characters[random.Next(characters.Length)];                
        int numeros = random.Next(100, 999);
        this.resultado = ch1.ToString() + ch2.ToString() + numeros.ToString();   
        if(resultado.Equals(old)){
            new Robot();
        }
    }
}