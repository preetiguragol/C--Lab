using System;
class prog3
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine();
        if(s.Length == 0)
        {
            Console.WriteLine("Empty String");
        }
        else
        {
            for(int i =0;i<s.Length;i++)
            {
                for(int j= 0;j<=s.Length-i;j++)
                {
                    Console.WriteLine(s.Substring(i,j));
                }
            }
        }
    }
}
