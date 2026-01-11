using System;

namespace TestAulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double lucro, valor;
            string produto;


            Console.WriteLine("---LK IMPORTADORA---");

            Console.Write("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do produto: ");
            produto = Console.ReadLine();
            Console.Write("Digite o valor de compra: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Digite o lucro desejado (em decimal): ");
            lucro = double.Parse(Console.ReadLine());
            double valorVenda = valor + (valor * lucro);


            Console.WriteLine("\n--- NOTA FISCAL ---");
            Console.WriteLine("Código do produto.......:{0,15}", codigo);
            Console.WriteLine("Nome do produto.........:{0,15}", produto);
            Console.WriteLine("Valor de compra.........:{0,15:c}", valor);
            Console.WriteLine("Quantidade comprada.....:{0,15}", quantidade);
            Console.WriteLine("Lucro desejado..........:{0,15:p}", lucro);
            Console.WriteLine("Valor de venda..........:{0,15:c}", valorVenda);
            Console.WriteLine("Total da compra.........:{0,15:c}", valorVenda * quantidade);
            Console.WriteLine("-------------------");


        }
    }
}