using System;

public class Clock 
{
    private int hours;
    private int minutes;
    private string horas;
    private string minutos;

    public Clock(int hours)
    {
       this.hours = hours;
    }

    public Clock(int hours, int minutes)
    {
       this.hours = hours;
       this.minutes = minutes;
    }

    public Clock Add(int minutesToAdd)
    {
         this.minutes = this.minutes + minutesToAdd;
         Clock clock = new Clock(this.hours, this.minutes);
         return clock;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public void calculaHora(){

        if(this.hours <= 9){
            this.horas = "0" + hours.ToString();
        }
        else {
            this.horas = hours.ToString();
        }
        if(this.minutes > 0){
            if(this.minutes <= 9){
                this.minutos = "0" + this.minutes.ToString();
            }
            else {
                this.minutos = this.minutes.ToString();
            }
        }
        else {
                this.minutos = "00";
        }

    }

    public void ajustaHora(){
        if(this.hours > 24){
            this.hours = this.hours - 24;
        }
        if(this.minutes > 60){
            if(this.minutes % 60 == 0){
                int divisao = this.minutes / 60;
                this.hours = this.hours + divisao;
            }
            else {
                
            }        
        }
    }

    public override string ToString(){
        calculaHora();
        return this.horas + ":" + this.minutos;
    }
}