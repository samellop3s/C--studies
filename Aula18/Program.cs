using System;

namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            //nesta aula foi passado como funciona a matrix com 2 vetores ou mais

            int[,] n = new int[3, 6];


            /*
             n[0,0] = 10;
             n[0,1] = 20;
             n[0,2] = 20;
             n[0,3] = 20;
             n[0,4] = 20;
             n[0,5] = 20;

             n[1,0] = 30;
             n[1,1] = 40;
             n[1,2] = 40;
             n[1,3] = 40;
             n[1,4] = 40;
             n[1,5] = 40;

             n[2,0] = 50;
             n[2,1] = 60;
             n[2,2] = 60;
             n[2,3] = 60;
             n[2,4] = 60;
             n[2,5] = 60;
            */

            //outra forma de atribuir valores a matrix
            n[0, 0] = 10; n[0, 1] = 20; n[0, 2] = 20; n[0, 3] = 20; n[0, 4] = 20; n[0, 5] = 20;
            n[1, 0] = 30; n[1, 1] = 40; n[1, 2] = 40; n[1, 3] = 40; n[1, 4] = 40; n[1, 5] = 40;
            n[2, 0] = 50; n[2, 1] = 60; n[2, 2] = 60; n[2, 3] = 60; n[2, 4] = 60; n[2, 5] = 60;

            //acessando um valor da matrix
            Console.WriteLine(n[2, 3]);

        }
    }
}