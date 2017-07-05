using System;


public class Clock
{
    private int _totalMinutes;

    public Clock(int hours)
    {
       _totalMinutes = hours * 60;
    }

    public Clock(int hours, int minutes)
    {
        _totalMinutes = (hours * 60) + minutes;
    }

    public Clock Add(int minutesToAdd)
    {
        return new Clock(0, _totalMinutes += minutesToAdd);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        var startTime = 1440 + (1440 * (minutesToSubtract / 60));

        return new Clock(startTime,  _totalMinutes -= minutesToSubtract);
    }
    
    public override string ToString()
    {   
        int hora = ((_totalMinutes % 1440) / 60);
        int minuto = (_totalMinutes % 60);
        string resposta = "";
        if(hora <= 9){
            resposta = "0" + hora.ToString();
        }
        else {
            resposta = hora.ToString();
        }
        if(minuto <= 9){
            resposta += ":0" + minuto.ToString();
        }
        else {
            resposta += ":" + minuto.ToString();
        }
        return resposta;
    }

    public override bool Equals(object obj)
    {
        return this.ToString() == obj.ToString();
    }
}