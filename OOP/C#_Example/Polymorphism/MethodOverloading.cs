using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public string Add(string a, string b)
    {
        return a + b;
    }
}
/* Operation
 * Multiplication : Operation
 * 
 * Operation operation = new Multiplication();
 * 
 * 
 
 */

class Program
{
    static void Main()
    {
        Calculator myCalculator = new Calculator();

        int sum1 = myCalculator.Add(2, 3);
        double sum2 = myCalculator.Add(2.5, 3.7);
        string concatStrings = myCalculator.Add("Hello", " World");

        Console.WriteLine(sum1);            // Output: 5
        Console.WriteLine(sum2);            // Output: 6.2
        Console.WriteLine(concatStrings);  // Output: Hello World
    }
}