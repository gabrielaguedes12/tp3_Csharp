using System;

namespace tp3_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEscolha o exercício para testar (1 a 12) ou 0 para sair:");
                int op = int.Parse(Console.ReadLine());

                if (op == 0) break;

                switch (op)
                {
                    case 1: Exercicio1.Run(); break;
                    case 2: Exercicio2.Run(); break;

                    // Depois você vai adicionar os outros cases aqui!
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            }
        }
    }
}
