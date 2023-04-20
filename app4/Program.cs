internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("height: ");
            var height = Console.ReadLine();

            Console.Write("width: ");
            var width = Console.ReadLine();

            if (height is not null && width is not null)
            {
                if (height.ToLower().Equals("q") || width.ToLower().Equals("q")) {
                    break;
                }

                try
                {
                    int h = Int32.Parse(height);
                    int w = Int32.Parse(width);
                    int a = h * w;

                    Console.WriteLine($"h={h}, w={w}, a={a}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        Console.WriteLine("bye, see you later");
    }
}