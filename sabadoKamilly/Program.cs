using System;

namespace sabadoKamilly
{
    class Program
    {
        enum DiasSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };
        static void Main(string[] args)
        {
            Console.Write("Em qual dia da semana você gostaria de agendar sua consulta? ");
            string entrada = Console.ReadLine();    
            DiasSemana diaConsulta = Enum.Parse<DiasSemana>(entrada);
            Console.WriteLine("Sua consulta foi agendada para: " + diaConsulta);
            }
    }
}