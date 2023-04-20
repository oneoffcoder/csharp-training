internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("youssef is awesome!");

        // variables
        short aShort = 1;
        byte aByte = 8;
        int a = 22;
        string s = "youssef";
        float w = 155.5f;
        double d = 188.8d;
        bool b = false;

        Console.WriteLine($"a={a}, s={s}, w={w}, b={b}, d={d}, aShort={aShort}, aByte={aByte}");

        // declaration
        int x;
        int y;

        // assignment
        x = 22;
        y = 33;

        Console.WriteLine($"x={x}, y={y}");
    }
}