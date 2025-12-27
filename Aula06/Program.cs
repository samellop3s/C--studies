using System; 

class Program
{
    static void Main(string[] args)
    {
        //WriteLine : Faz a impressao do resultado no console e faz a quebra de linha
        //Write : Faz a impressao do resultado no console sem quebra de linha
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Starting Aula 06...");

        //Fazendo a utilização dos indices.
        //Sabemos que a inicialização dos indices começa em 0.
        //dessa forma, utilizando eles ficara mais facil na organização dos dados.
        //Segue exemplo:
        int n1, n2, n3;

        n1 = 10;
        n2 = 20;
        n3 = 30;

        Console.WriteLine("n1={0}, n2={1}, n3={2}", n1, n2, n3);
    }
}