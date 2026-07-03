using System;

namespace Aula27
{
    /*a passagem de valor no formato params, permite fazer a passagem de mais de um pparametro sem precisar indicar eles no metodo */
    class Program
    {
        static void Main()
        {
            Soma(10, 25, 36, 45);
        }
        static void Soma(params int[]n)
        {
            int res = 0;

            if(n.Length < 1)
            {
                Console.WriteLine("Não existem valores a serem somados");
            }else if(n.Length < 1)
            {
                Console.WriteLine($"Valores insuficientes para soma : {n}");
            }
            else
            {
                for(int i=0; i<n.Length; i++)
                {
                    res+=n[i];
                }
                Console.WriteLine($"A Soma dos valores é: {res}");
            }
        }
    }
}