using System;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine(); serve para fazer a leitura dos valores do teclado

            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + "! Seja bem-vindo(a) ao C#.");

            int number1, number2, soma;

            //int.parce() converte uma string em um número inteiro.

            Console.Write("Digite o primeiro número: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            number2 = int.Parse(Console.ReadLine());
            soma = number1 + number2;
            Console.WriteLine("A soma dos números é: " + soma);
        }
    }
}