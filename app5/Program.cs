internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        while (true) {
            Console.Write("guess: ");
            var guess = Console.ReadLine();

            if (guess is not null) {
                if (guess.ToLower().Equals("q")) {
                    break;
                }

                var num = random.Next(0, 2);
                var g = Int32.Parse(guess);

                if (num == g) {
                    Console.WriteLine("correct!");
                } else {
                    Console.WriteLine($"incorrect! guess={guess}, number={num}");
                }
            }
        }

        Console.WriteLine("bye, please play again!");
    }
}