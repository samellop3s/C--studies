using System;

class Program
{
    static int Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        for (var n = 0; n < args.Length; n++)
        {
            Console.WriteLine("arg[{0}] = {1}", n, args[n]);
        }

        // Chamando a função de soma
        CalculateSum();

        return 0;
    }

    static void CalculateSum()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var sum = 0;

        for (var n = 0; n < numbers.Length; n++)
        {
            sum += numbers[n];
        }

        Console.WriteLine(sum);
    }
}