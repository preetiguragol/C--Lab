﻿using System;
class Program1
{
    static void Main()
    {
        Console.WriteLine("Calculator");
        int a,b,c,res;
        while(true)
        {
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Exit\n");
            Console.WriteLine("Enter your choice:");
            c = Convert.ToInt32(Console.ReadLine());
            switch(c){
                case 1: Console.WriteLine("Enter two numbers: ");
                a= Convert.ToInt32(Console.ReadLine());
                b= Convert.ToInt32(Console.ReadLine());
                res = a+b;
                Console.WriteLine($"Result:{res}");
                break;
                case 2: Console.WriteLine("Enter two numbers: ");
                a= Convert.ToInt32(Console.ReadLine());
                b= Convert.ToInt32(Console.ReadLine());
                res = a-b;
                Console.WriteLine($"Result:{res}");
                break;
                case 3: Console.WriteLine("Enter two numbers: ");
                a= Convert.ToInt32(Console.ReadLine());
                b= Convert.ToInt32(Console.ReadLine());
                res = a*b;
                Console.WriteLine($"Result:{res}");
                break;
                case 4: Console.WriteLine("Enter two numbers: ");
                a= Convert.ToInt32(Console.ReadLine());
                b= Convert.ToInt32(Console.ReadLine());
                res = a/b;
                Console.WriteLine($"Result:{res}");
                break;
                case 5: Environment.Exit(0);
                break;
                default:
                Console.WriteLine("Invalid choice");
                break;
            }
            
        }
    }
}