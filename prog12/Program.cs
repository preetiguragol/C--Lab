using System;
public interface Resizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}
public class Rectangle : Resizable
{
    private int width;
    private int height;
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    public void ResizeWidth(int width)
    {
        this.width = width;
    }
    public void ResizeHeight(int height)
    {
        this.height = height;
    }
    public void Display()
    {
        Console.WriteLine($"Rectangle Width: {width}, Height: {height}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(10, 20);
        Console.WriteLine("Initial state of the rectangle:");
        rectangle.Display();
        rectangle.ResizeWidth(15);
        rectangle.ResizeHeight(25);
        Console.WriteLine("\nState of the rectangle after resizing:");
        rectangle.Display();
        Console.ReadLine();
    }
}
