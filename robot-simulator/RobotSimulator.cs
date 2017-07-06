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
            return bearing;
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
        if(bearing == Bearing.North){
            bearing = Bearing.East;
        }
        else if(bearing == Bearing.East){
            bearing = Bearing.South;
        }
        else if(bearing == Bearing.South){
            bearing = Bearing.West;
        }
        else if(bearing == Bearing.West){
            bearing = Bearing.North;
        }
    }

    public void TurnLeft()
    {
        if(bearing == Bearing.North){
            bearing = Bearing.West;
        }
        else if(bearing == Bearing.East){
            bearing = Bearing.North;
        }
        else if(bearing == Bearing.South){
            bearing = Bearing.East;
        }
        else if(bearing == Bearing.West){
            bearing = Bearing.South;
        }
    }

    public void Advance()
    {
        x = x + 1;
        y = y + 1;
    }

    public void Simulate(string instructions)
    {   
        string teste = instructions.Replace("AA","A");
        for(int i=0;i<teste.Length;i++){
            if(teste[i].Equals("L")){
                TurnLeft();
            }
            else if (teste[i].Equals("R")){
                TurnRight();
            }
            else if (teste[i].Equals("A")){
                Advance();
            }
        }
    }
}