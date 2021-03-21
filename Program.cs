using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(@"Digite seu primeiro nome: Renan

Digite seu sobrenome: Menezes

Nome completo: Renan Menezes

Nome de catálogo: Menezes, Renan");
            Console.WriteLine();
            Console.ResetColor();



        }
    }
}
