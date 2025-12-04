using System;

namespace tp3_Csharp
{
    public static class Exercicio8
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 8 ---");

            Matricula8 m1 = new Matricula8();

            m1.nomeDoAluno = "Maria Alice";
            m1.curso = "Ciência da Computação";
            m1.numeroMatricula = 10122003;
            m1.situacao = "Ativa";
            m1.dataInicial = "10/12/2003";

            m1.ExibirInformacoes();

            // Trancar e exibir
            Console.WriteLine("\nTrancando matrícula...");
            m1.Trancar();
            m1.ExibirInformacoes();

            // Reativar e exibir
            Console.WriteLine("\nReativando matrícula...");
            m1.Reativar();
            m1.ExibirInformacoes();
        }
    }

    public class Matricula8
    {
        public string nomeDoAluno;
        public string curso;
        public int numeroMatricula;
        public string situacao;
        public string dataInicial;

        public void Trancar()
        {
            situacao = "Trancada";
        }

        public void Reativar()
        {
            situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("\n--- Informações da Matrícula ---");
            Console.WriteLine($"Aluno: {nomeDoAluno}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Número da Matrícula: {numeroMatricula}");
            Console.WriteLine($"Situação: {situacao}");
            Console.WriteLine($"Data Inicial: {dataInicial}");
        }
    }
}
