using System;

public class BankAccount
{
    private Estado estado;
    private float valor;
    public void Open()
    {
      estado = Estado.OPEN;
    }

    public void Close()
    {
      estado = Estado.CLOSE;
    }

    public float Balance
    {
        get
        {
           if(estado == Estado.OPEN){
              return valor;  
           }
           else {
              throw new InvalidOperationException(); 
           }
        }
    }

    public void UpdateBalance(float change)
    {
        lock(this)
        valor += change;
    }

    enum Estado
        {
        OPEN,
        CLOSE
    };
}
