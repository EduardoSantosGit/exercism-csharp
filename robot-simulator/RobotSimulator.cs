using System;

public enum Bearing
{
    North,
    East,
    South,
    West
}

public struct Coordinate
{
    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; }
    public int Y { get; }
}

public class RobotSimulator
{   
    private Bearing bearing;
    private Coordinate coordinate;
    private int x;
    private int y;

    public RobotSimulator(Bearing bearing, Coordinate coordinate)
    {
        this.bearing = bearing;
        this.coordinate = coordinate;
        x = coordinate.X;
        y = coordinate.Y;
    }

    public Bearing Bearing
    {
        get
        {
            return this.bearing;
        }
    }

    public Coordinate Coordinate
    {
        get
        {
            return new Coordinate(x,y);
        }
    }

    public void TurnRight()
    {
        if(this.bearing == Bearing.North){
            this.bearing = Bearing.East;
        }
        else if(this.bearing == Bearing.East){
            this.bearing = Bearing.South;
        }
        else if(this.bearing == Bearing.South){
            this.bearing = Bearing.West;
        }
        else if(this.bearing == Bearing.West){
            this.bearing = Bearing.North;
        }
    }

    public void TurnLeft()
    {
        if(this.bearing == Bearing.North){
            this.bearing = Bearing.West;
        }
        else if(this.bearing == Bearing.East){
            this.bearing = Bearing.North;
        }
        else if(this.bearing == Bearing.South){
           this.bearing = Bearing.East;
        }
        else if(this.bearing == Bearing.West){
            this.bearing = Bearing.South;
        }
    }

    public void Advance()
    {   
        if(this.bearing == Bearing.North || this.bearing == Bearing.South){
            y = y + 1;
        }
        else if (this.bearing == Bearing.West || this.bearing == Bearing.East){
           x = x + 1;
        }
    }

    public void Simulate(string instructions)
    {   
        for(int i=0;i<instructions.Length;i++){
            if(instructions[i] == 'L'){
                TurnLeft();
            }
            else if (instructions[i] == 'R'){
                TurnRight();
            }
            else if (instructions[i] == 'A'){
                Advance();
            }
        }
    }
}