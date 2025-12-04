using System;

namespace tp3_Csharp
{
    public static class Exercicio9
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 9 ---");
            Console.WriteLine("Testando a classe Matricula8...\n");

            Matricula8 m = new Matricula8();

            m.nomeDoAluno = "Maria Alice";
            m.curso = "Ciência da Computação";
            m.numeroMatricula = 10122003;
            m.situacao = "Ativa";
            m.dataInicial = "10/12/2003";

            Console.WriteLine("Estado inicial da matrícula:");
            m.ExibirInformacoes();

            Console.WriteLine("\nTrancando a matrícula...");
            m.Trancar();
            m.ExibirInformacoes();

            Console.WriteLine("\nReativando a matrícula...");
            m.Reativar();
            m.ExibirInformacoes();
        }
    }
}
