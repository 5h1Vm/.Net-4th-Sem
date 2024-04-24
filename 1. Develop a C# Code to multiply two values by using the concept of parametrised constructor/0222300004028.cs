using System;

public class Multiplication
{
    int result;

    public Multiplication(int num1, int num2)
    {
        result = num1 * num2;
    }

    public void Display()
    {
        Console.WriteLine("The result of multiplication is: {0}", result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = int.Parse(Console.ReadLine());

        Multiplication multiplication = new Multiplication(a, b);

        multiplication.Display();
    }
}
