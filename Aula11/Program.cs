using System;

namespace AUla11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão de tipos (typecast)
            //serve para converter um tipo de dado em outro tipo de dado caso a situação não seja uma conversao implicita.
            float n1 = 10.5f;
            short vShort = (short)n1; //convertendo float para short
            Console.WriteLine("Valor de n1: " + vShort);
            //esse tipo de conversão serve para converter tipos maiores em tipos menores,
            //porém pode haver perda de informação, como no exemplo acima, onde o valor decimal foi perdido.

        }
    }
}