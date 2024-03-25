using System;
class ArmstrongNumber
{
    static int CountDigits(int num)
    {
        int count = 0;
        while(num>0)
        {
            num/=10;
            count++;
        }
        return count;
    }
    static bool isArmstrong(int num)
    {
        int originalNum = num;
        int numDigits = CountDigits(num);
        int sum =0;
        while(num>0)
        {
            int digits = num%10;
            sum+=(int)Math.Pow(digits,numDigits);
            num/=10;
        }
        return sum == originalNum;
    }
    static void Main()
    {
        Console.WriteLine("Aramstrong Number between 0 and 1000");
        for(int i =0;i<=1000;i++)
        {
            if(isArmstrong(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}