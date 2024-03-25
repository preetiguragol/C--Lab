using System;
class prog5
{
    static void Main()
    {   Console.WriteLine("Floyds Triangle");
        Console.WriteLine("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        int[,] pascals = new int[rows,rows];
        int c =1;
        for(int i =0;i<rows;i++)
        {
            for (int j=0;j<=i;j++)
            {
                pascals[i,j]= c++;
            }
        }
        Console.WriteLine($"Floyds Triangle for {rows} rows");
            for( int i=0;i<rows;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write(pascals[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

    }
