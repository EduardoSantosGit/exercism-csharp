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
        decimal lado1 = side1 + side2;
        decimal lado2 = side1 + side3;
        decimal lado3 = side2 + side3;
        
        if(valid <= 0){
            throw new TriangleException();
        }
        if(lado1 > side3 && lado2 > side2 && lado3 > side1){
            if(side1 == side2 && side1 == side3){
                return TriangleKind.Equilateral;
            }
            else if(side1 != side2 && side1 != side3 && side2 != side3){
                return TriangleKind.Scalene;
            }
            else {
                return TriangleKind.Isosceles;
            }    
        } 
            else {
                throw new TriangleException();  
            }
        throw new TriangleException();
    }
}

public class TriangleException : Exception { }