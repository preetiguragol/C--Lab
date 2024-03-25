﻿using System;
using System.Runtime.ExceptionServices;
class Complex
{
    private double real;
    private double img;
    public Complex(double real1,double img1)
    {
        this.real = real1;
        this.img = img1;
    }
    public static Complex operator +(Complex c1, Complex c2)
    {
        double realsum, imgsum;
        realsum = c1.real + c2.real;
        imgsum = c1.img+c2.img;
        return new Complex(realsum,imgsum);
    }
    public void display()
    {
        Console.WriteLine($"Result: {real}+{img}i");
    }

}
class prog9
{
    static void Main()
    {
        Console.WriteLine("Enter the first complex number.");
        double real1 = Convert.ToInt32(Console.ReadLine());
        double img1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second complex number.");
        double real2 = Convert.ToInt32(Console.ReadLine());
        double img2 = Convert.ToInt32(Console.ReadLine());

        Complex c1 = new Complex(real1,img1);
        Complex c2 = new Complex(real2,img2);
        Complex result = c1+c2;
        Console.WriteLine("First Complex Number: ");
        c1.display();
        Console.WriteLine("Second Complex Number: ");
        c2.display();
        Console.WriteLine("result Complex no:");
        result.display();

    }
}