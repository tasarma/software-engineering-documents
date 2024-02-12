using System;

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Program
{
    static void Main()
    {
        Shape myShape = new Shape();
        Circle myCircle = new Circle();
        Square mySquare = new Square();

        myShape.Draw();   // Output: Drawing a shape
        myCircle.Draw();  // Output: Drawing a circle
        mySquare.Draw();  // Output: Drawing a square
    }
}