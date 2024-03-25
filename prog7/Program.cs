using System;
using System.IO;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter the source file path: ");
        string sourceFilePath = Console.ReadLine();
        Console.WriteLine("Enter the destination file path: ");
        string destinationFilePath= Console.ReadLine();

        try{
            string fileContents = File.ReadAllText(sourceFilePath);
            File.WriteAllText(destinationFilePath,fileContents);
            Console.WriteLine("File Contents successfully copied from `{0}` to `{1}`",
            sourceFilePath,destinationFilePath);
        }
        catch(Exception ex)
        {
            Console.WriteLine("An error occured: "+ex.Message);
        }
    }
}