using System;
class Program
{
    static void Main()
    {
        try {
            int numerator = 10;
            int denominator = 0;
            int result = numerator/denominator;
            Console.WriteLine($"Result of division: {result}");
        }
        catch(DivideByZeroException ex) 
        {
            Console.WriteLine($"Exception Caught: {ex.Message}");
        }
        try{
            int[] numbers = {1,2,3,4,5};
            int index = 10;
            int value = numbers[index];
            Console.WriteLine($"Value at {index}: {value}");

        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Exception Caught: {ex.Message}");
        }
    }
}