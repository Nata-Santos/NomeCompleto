using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nome;
            string sobrenome;
            string nomeCompleto;
            string nomeCatalogo;
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Veja seu nome de diferentes formas");
            Console.WriteLine("----------------------------------");
            Console.ResetColor();

            Console.Write("Digite seu primeiro nome:");
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome:");
            sobrenome = Console.ReadLine();

            nomeCompleto = $"{nome} {sobrenome}";
            nomeCatalogo = $"{sobrenome.ToUpper()}, {nome}.";

            Console.WriteLine();
            Console.WriteLine($"Nome Completo: {nomeCompleto}");
            Console.WriteLine($"Nome Catalogo: {nomeCatalogo}");

        }
    }
}
