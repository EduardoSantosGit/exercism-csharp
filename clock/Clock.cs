using System;

public class Clock 
{   
    private readonly TimeSpan _timeSpanOneDay = TimeSpan.FromTicks(TimeSpan.TicksPerDay);
    private TimeSpan _time;
    private int _hora;
    private int _minuto;
    public Clock(int hours)
    {
       _time = new TimeSpan(hours, 0, 0);
       _hora = hours;
    }

    public Clock(int hours, int minutes)
    {
      _time = new TimeSpan(hours, minutes, 0);
      _hora = hours;
      _minuto = minutes;
    }

    public Clock Add(int minutesToAdd)
    {   
        Clock clock = new Clock(_hora,_minuto + minutesToAdd);
        return clock;
    }

    public Clock Subtract(int minutesToSubtract)
    {   
        Clock clock = new Clock(_hora,_minuto - minutesToSubtract);
        return clock;
    }

    public override string ToString(){
       return _time.ToString(@"hh\:mm");
    }

}






















/* 

    public void calculaHora(){

        if(this._hours <= 9){
            this.horas = "0" + _hours.ToString();
        }
        else {
            this.horas = _hours.ToString();
        }
        if(_minutes > 0){
            if(_minutes <= 9){
                this.minutos = "0" + _minutes.ToString();
            }
            else {
                this.minutos = _minutes.ToString();
            }
        }
        else {
                this.minutos = "00";
        }
        if(this.horas == "24"){
            this.horas = "00";
        }
    }

    public void ajustaHora(){
         int divisao = 0;
         int restante = 0; 
        if(_minutes > 59){
            divisao = _minutes / 60;
            for(int i=1;i<divisao+1;i++){
                restante = _minutes - (60 * i);
            }
            if(divisao > 24){
                int diasMais = divisao / 24;
                int horasRestantes = 0;
                for(int i=1;i<diasMais;i++){
                    horasRestantes = divisao - (24 * i);
                }
                this._hours = this._hours + horasRestantes;
                _minutes = restante;
            }
            else {
                this._hours = this._hours + divisao;
                _minutes = restante;
            }
        }
        if(this._hours > 24){
            this._hours = this._hours - 24;
        }
    }

    public override string ToString(){
        ajustaHora();
        calculaHora();
        return this.horas + ":" + this.minutos;
    }
}*/