using System;

public class SpaceAge
{   
    private double segundos;
    public SpaceAge(long seconds)
    {
        segundos = seconds;
    }

    public double OnEarth()
    {
        return calculaTempo(segundos, 31557600, 1);
    }

    public double OnMercury()
    {
        return calculaTempo(segundos, 31557600, 0.2408467);
    }

    public double OnVenus()
    {
        return calculaTempo(segundos, 31557600, 0.61519726);
    }

    public double OnMars()
    {
        return calculaTempo(segundos, 31557600, 1.8808158);
    }

    public double OnJupiter()
    {
        return calculaTempo(segundos, 31557600, 11.862615);
    }

    public double OnSaturn()
    {
        return calculaTempo(segundos, 31557600, 29.447498);
    }

    public double OnUranus()
    {
        return calculaTempo(segundos, 31557600, 84.016846);
    }

    public double OnNeptune()
    {
        return calculaTempo(segundos, 31557600, 164.79132);
    }

    public double calculaTempo(double segundos, double era, double calc){
        return Math.Round(segundos / (era * calc), 2);
    }
}