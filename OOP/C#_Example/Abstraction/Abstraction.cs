using System;

// Abstract class representing a shape
abstract class Shape
{
    public abstract void Draw();  // Abstract method without implementation
}

// Interface representing a printable object
interface IPrintable
{
    void Print();
}

// Concrete class implementing the Shape abstract class and IPrintable interface
class Circle : Shape, IPrintable
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public void Print()
    {
        Console.WriteLine("Printing a circle");
    }
}

class Program
{
    static void Main()
    {
        Circle myCircle = new Circle();

        myCircle.Draw();  // Output: Drawing a circle
        myCircle.Print(); // Output: Printing a circle
    }
}