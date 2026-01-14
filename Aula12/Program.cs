using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, res;
            res = n1 = n2 = n3 = n4 = 0;

            Console.Write("Digite o valor de n1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de n2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de n3: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de n4: ");
            n4 = int.Parse(Console.ReadLine());

            res = (n1 + n2 + n3 + n4);
            if (res >= 60)
                Console.WriteLine($"A soma da notas deram o total de: {res} e o resultado é: Aprovado");
            else
                Console.WriteLine("Reprovado");
        }
    }
}