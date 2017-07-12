using System;
using System.Text;

public class Robot
{     
    private string _result;
    private static Random random = new Random();

    public Robot(){
       this.Reset();
    }

    public string Name
    {
        get{
            return _result;
        }
    }

    public void Reset()
    {   
        var old = this._result; 
        var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var ch1=characters[random.Next(characters.Length)];
        var ch2=characters[random.Next(characters.Length)];                
        var numbers = random.Next(100, 999);
        this._result = ch1.ToString() + ch2.ToString() + numbers.ToString();   
        if(_result.Equals(old)){
            new Robot();
        }
    }
}