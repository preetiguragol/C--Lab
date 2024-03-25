using System;
class prog5
{
    static void Main()
    {   Console.WriteLine("Pascals Triangle");
        Console.WriteLine("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        int[,] pascals = new int[rows,rows];
        for(int i =0;i<rows;i++)
        {
            for (int j=0;j<=i;j++)
            {
                if(j==0||i==j)
                {
                    pascals[i,j]=1;
                }
                else
                {
                    pascals[i,j]=pascals[i-1,j-1]+pascals[i-1,j];
                }
            }
        }
        Console.WriteLine($"Pascals Triangle for {rows} rows");
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
