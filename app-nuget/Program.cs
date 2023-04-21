using Microsoft.ML.Probabilistic.Models;
using Microsoft.ML.Probabilistic.Algorithms;

internal class Program
{
    private static void Main(string[] args)
    {
        Variable<bool> firstCoin = Variable.Bernoulli(0.5).Named("firstCoin");
        Variable<bool> secondCoin = Variable.Bernoulli(0.5).Named("secondCoin");
        Variable<bool> bothHeads = (firstCoin & secondCoin).Named("bothHeads");

        InferenceEngine engine = new InferenceEngine();

        if (engine.Algorithm is VariationalMessagePassing)
        {
            Console.WriteLine("This example does not run with Variational Message Passing");
            return;
        }

        Console.WriteLine($"dist over first coin: {engine.Infer(firstCoin)}");
        Console.WriteLine($"dist over first coin: {engine.Infer(secondCoin)}");
        Console.WriteLine($"both coins head: {engine.Infer(bothHeads)}");

        bothHeads.ObservedValue = false;
        
        Console.WriteLine($"dist over first coin: {engine.Infer(firstCoin)}");
        Console.WriteLine($"dist over first coin: {engine.Infer(secondCoin)}");
        Console.WriteLine($"both coins head: {engine.Infer(bothHeads)}");
    }
}