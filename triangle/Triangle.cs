using System;

public enum TriangleKind
{
    Equilateral,
    Isosceles,
    Scalene
}

public static class Triangle
{
    public static TriangleKind Kind(decimal side1, decimal side2, decimal side3)
    {
        decimal valid = side1 * side2 * side3;
        decimal lados = side1 + side2;
        
        if(valid > 0){
            if(lados >= side3){
                if(side1 == side2 && side1 == side3){
                    return TriangleKind.Equilateral;
                }
                else if(side1 != side2 && side1 != side3 && side2 != side3){
                    return TriangleKind.Scalene;
                }
                else {
                    return TriangleKind.Isosceles;
                }
            } else {
                throw new TriangleException();
            }
        }
        else {
            throw new TriangleException();
        }
        
       
        throw new TriangleException();
    }
}

public class TriangleException : Exception { }