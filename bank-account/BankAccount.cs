using System;

public class BankAccount
{
    private State _state;
    private float _value;
    public void Open()
    {
      _state = State.OPEN;
    }

    public void Close()
    {
      _state = State.CLOSE;
    }

    public float Balance
    {
        get
        {
           if(_state == State.OPEN){
              return _value;  
           }
           else {
              throw new InvalidOperationException(); 
           }
        }
    }

    public void UpdateBalance(float change)
    {
        lock(this)
        _value += change;
    }

    enum State
        {
        OPEN,
        CLOSE
    };
}
