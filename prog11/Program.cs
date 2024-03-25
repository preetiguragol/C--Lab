﻿using System;

abstract class Shape
{
    public abstract double CalArea();
    public abstract double CalcPerimeter();

}
class Circle:Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double CalArea()
    {
        double area = Math.PI*radius*radius;
        return area;
    } 
    public override double CalcPerimeter()
    {
        double perimeter = 2*Math.PI*radius;
        return perimeter;
    }    
}


class Triangle:Shape
{
    private double s1,s2,s3;
    public Triangle(double s1,double s2,double s3)
    {
        this.s1 = s1;
        this.s2=s2;
        this.s3=s3;
    }
    public override double CalArea()
    {   double s = (s1+s2+s3)/2;
        double area = Math.Sqrt(s*(s-s1)*(s-s2)*(s-s3));
        return area;
    } 
    public override double CalcPerimeter()
    {
        double perimeter = s1+s2+s3;
        return perimeter;
    }    
}
class prog11
{
    static void Main()
    {
        double radius,s1,s2,s3;
        Console.WriteLine("Enter radius: ");
        radius = Convert.ToDouble(Console.ReadLine());
        Circle c = new Circle(radius);

        Console.WriteLine("Enter sides: ");
        s1 = Convert.ToDouble(Console.ReadLine());
        s2 = Convert.ToDouble(Console.ReadLine());
        s3 = Convert.ToDouble(Console.ReadLine());
        Triangle t = new Triangle(s1,s2,s3);
        Console.WriteLine($"\nCircle: \nArea = {c.CalArea()} \nPerimeter: {c.CalcPerimeter()} \nTraingle: \nArea: {t.CalArea()} \nPerimeter: {t.CalcPerimeter()}");

    }
}