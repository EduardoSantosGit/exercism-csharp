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
        if(bearing == Bearing.East){
            bearing = Bearing.South;
        }
        if(bearing == Bearing.South){
            bearing = Bearing.West;
        }
        if(bearing == Bearing.West){
            bearing = Bearing.North;
        }
    }

    public void TurnLeft()
    {
        if(bearing == Bearing.North){
            bearing = Bearing.West;
        }
        if(bearing == Bearing.East){
            bearing = Bearing.North;
        }
        if(bearing == Bearing.South){
            bearing = Bearing.East;
        }
        if(bearing == Bearing.West){
            bearing = Bearing.South;
        }
    }

    public void Advance()
    {
        x = x + coordinate.X;
        y = y + coordinate.Y;
    }

    public void Simulate(string instructions)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}