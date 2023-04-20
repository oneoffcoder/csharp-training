internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("height: ");
        var height = Console.ReadLine();

        Console.Write("width: ");
        var width = Console.ReadLine();

        if (height is not null && width is not null) {
            try {
                int h = Int32.Parse(height);
                int w = Int32.Parse(width);
                int a = h * w;

                Console.WriteLine($"h={h}, w={w}, a={a}");
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}