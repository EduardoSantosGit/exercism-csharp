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

         new TimeSpan();

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
        if(this.horas == "24"){
            this.horas = "00";
        }
    }

    public void ajustaHora(){
        if(this.minutes > 60){
            int divisao = this.minutes / 60;
            int restante = 0;
            for(int i=1;i<divisao+1;i++){
                restante = this.minutes - (60 * i);
            }
            if(divisao > 24){
                int diasMais = divisao / 24;
                int horasRestantes = 0;
                for(int i=1;i<diasMais;i++){
                    horasRestantes = divisao - (24 * i);
                }
                this.hours = this.hours + horasRestantes;
                this.minutes = restante;
            }
            else {
                this.hours = this.hours + divisao;
                this.minutes = restante;
            }
            
        }
        if(this.hours > 24){
            this.hours = this.hours - 24;
        }
    }

    public override string ToString(){
        ajustaHora();
        calculaHora();
        return this.horas + ":" + this.minutos;
    }
}