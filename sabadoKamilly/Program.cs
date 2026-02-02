using System;
using System.Threading.Tasks.Dataflow;

namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Vetores na ordem correta: ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Vetores ao contrario: ");
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i] + " ");
            }

            string[] frutas = {"Banana", "Pera", "UVa", "Laranja", "Tomate"};

            bool encontrou = false;

            Console.WriteLine("Nesta cesta tem a Banana?");

            foreach(string fruta in frutas)
            {
                if(fruta == "Banana")
                {
                    encontrou = true;
                }
            }
            if (encontrou)
            {
                Console.WriteLine("OBAAAA, vc encontrou a banana!!!!");
            }
            else
            {
                Console.WriteLine("Poxa, vc n encontrou a banana");
            }
        }
    }
}