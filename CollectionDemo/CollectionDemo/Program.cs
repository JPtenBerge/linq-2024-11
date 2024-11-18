using System.Collections.Generic;

namespace CollectionDemo;

internal class Program
{
    static void Main(string[] args)
    {
        //var linky = new LinkedList<int>();
        
        //new List<int>()

        foreach (var item in GeefInts().)
        {
            Console.WriteLine($"item: {item}");
        }
    }

    static IEnumerable<int> GeefInts() // lazy evaluation
    {
        Console.WriteLine("eerste");
        yield return 4;
        Console.WriteLine("tweede");
        yield return 8;
        Console.WriteLine("derde");
        yield return 15;
        Console.WriteLine("vierde");

        if (4 > 2)
        {
            yield break;
        }

        yield return 16;
        Console.WriteLine("vijfde");
        yield return 23;
        Console.WriteLine("zesde");
        yield return 42;
    }
}
