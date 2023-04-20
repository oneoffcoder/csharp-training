internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        int b = 11;
        int c = a + b;
        int d = a - b;
        int e = a * b;
        int f = a / b;
        double g = a / (double)b;
        int h = a % b;


        Console.WriteLine($"{a} + {b} = {c}");
        Console.WriteLine($"{a} - {b} = {d}");
        Console.WriteLine($"{a} * {b} = {e}");
        Console.WriteLine($"{a} / {b} = {f}");
        Console.WriteLine($"{a} / {b} = {g}");
        Console.WriteLine($"{a} % {b} = {h}");
    }
}