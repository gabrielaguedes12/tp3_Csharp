using System;

namespace tp3_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa iniciado!");

            while (true)
            {
                Console.WriteLine("\nEscolha o exercício para testar (1 a 12) ou 0 para sair:");

                string? entrada = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Entrada inválida, tente novamente!");
                    continue;
                }

                int op;
                if (!int.TryParse(entrada, out op))
                {
                    Console.WriteLine("Digite apenas números!");
                    continue;
                }

                if (op == 0) break;

                switch (op)
                {
                    case 1: Exercicio1.Run(); break;
                    case 2: Exercicio2.Run(); break;
                    case 3: Exercicio3.Run(); break;
                    case 4: Exercicio4.Run(); break;
                    case 5: Exercicio5.Run(); break;
                    case 6: Exercicio6.Run(); break;
                    case 7: Exercicio7.Run(); break;
                    case 8: Exercicio8.Run(); break;
                    case 9: Exercicio9.Run(); break;
                    case 10: Exercicio10.Run(); break;
                    case 11: Exercicio11.Run(); break;
                    case 12: Exercicio12.Run(); break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            }

            Console.WriteLine(" Programa finalizado!");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}
