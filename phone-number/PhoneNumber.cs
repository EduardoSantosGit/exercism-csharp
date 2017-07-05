using System;

public class PhoneNumber
{   
    private string phoneNumber;

    public PhoneNumber(string phoneNumber)
    {
       this.phoneNumber = phoneNumber;
    }

    public string Number
    {
        get
        {   
            string numero = retiraNaoNumerico(phoneNumber);
            if(numero.Length > 10 && numero.StartsWith("1")){
                numero = numero.Substring(1,10);
            }
            if(numero.Length > 10 && !numero.StartsWith("1")){
                numero = "0000000000";
            }
            if(numero.Length < 10){
                numero = "0000000000";
            }
            return numero;
        }
    }

    public string AreaCode
    {
        get
        {   
            string numero = retiraNaoNumerico(phoneNumber);
            if(numero.Length == 10){
                numero = numero.Substring(0,3);
            }
            return numero;
        }
    }

    public override string ToString()
    {   
        string numero = retiraNaoNumerico(phoneNumber);
        if(numero.Length == 10){
            numero = "(" + numero.Substring(0,3) + ") " + numero.Substring(3,3) + "-" + numero.Substring(6,4);
        }
        return numero;
    }

    public string retiraNaoNumerico(string numero){
        return numero.Replace("(","").Replace(")","").Replace(" ", "").Replace(".","").Replace("-","");
    }
}