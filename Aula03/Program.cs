/*
Comentários explicativos do código:

- using System; : Importa o namespace System, que contém classes essenciais como Console para entrada e saída de dados.
- class Program : Define a classe principal do programa, onde o código é executado.
- static void Main() : Método de entrada do programa. É o ponto de partida da execução em aplicações C#.
*/

using System;
    class Program
    {
        static void Main()
        {
            byte n1 = 10;
            short n2 = 30000;
            int num = 100;
            char letra = 'S';
            float valor = 10.5f;
        
            Console.WriteLine("O valor da variavel n1 é: " + n1);
            Console.WriteLine("O valor da variavel n2 é: " + n2);
            Console.WriteLine("O valor da variavel letra é: " + letra);
            Console.WriteLine("O valor da variavel valor é: " + valor); 
            Console.WriteLine("O valor da variavel num é: ");

           /* int num1,num2,res;

            num1 = 24;
            num2 = 568;
            res = num1 * num2;

            Console.WriteLine("a soma do " + num1 + " com o " + num2 + " é igual a: " + res);*/


            double val1, val2, number, total;

            val1 = 200;
            val2 = 526;
            

            total = val1 / val2;
            Console.WriteLine("A divisão e soma do valor entre n1 e n2 é: " + total);



            string nome, sobrenome, loc, idade;

            nome = "Samuel ";
            sobrenome = "Ferreira";
            loc = "Uniao de vila nova";
            idade = "21 ";

            Console.WriteLine("me chamo " + nome + sobrenome + " moro no bairro " + loc + " e tenho " + idade + "prazer em conhecer vc");
        }
    }