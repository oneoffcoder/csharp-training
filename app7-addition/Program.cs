internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Addition Table Application");

        while (true) {
            Console.Write("num: ");
            var query = Console.ReadLine();

            if (query is not null) {
                if (query.ToLower().Equals("q")) {
                    break;
                }
                
                var num = Int32.Parse(query);

                for (int i = 0; i <= 12; i++) {
                    Console.WriteLine($"{i} + {num} = {i + num}");
                }

                Console.WriteLine(new String('-', 15));
            }
        }

        Console.WriteLine("Thanks for using me!");
    }
}