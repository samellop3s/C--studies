using System;

namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] number = new int [10];

            for(int i = 0; i<number.Length; i++)
            {
                number[i]=i;
            }

            for(int i=0; i<number.Length; i++)
            {
                Console.WriteLine("Valor de num na pos{0}: {1}",i,number[i]);
            }
        }
    }
}