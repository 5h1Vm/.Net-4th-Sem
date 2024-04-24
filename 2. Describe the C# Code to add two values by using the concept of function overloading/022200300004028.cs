using System;

public
class Vector
{
    public
        int X
    {
        get;
        set;
    }
    public
        int Y
    {
        get;
        set;
    }
    public
        Vector(int x, int y)
    {
        X = x;
        Y = y;
    }
    public
        static Vector operator +(Vector vector1, Vector vector2)
    {
        return new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(1, 2);
        Vector v2 = new Vector(3, 4);
        Vector sum = v1 + v2;
        Console.WriteLine($ "Result: ({sum.X}, {sum.Y})");
    }
}
