using System;

namespace tp3_Csharp
{
    public static class Exercicio7
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 7 ---");
            //objeto
            Matricula m1 = new Matricula();

            //atributos
            m1.nomeDoAluno = "Maria Alice";
            m1.curso = "Ciência da Computação";
            m1.numeroMatricula = 10122003;
            m1.situacao = "Ativa";
            m1.dataInicial = "10/12/2003";

            m1.ExibirCaracteristicas();
        }
    }

    //classe
    public class Matricula
    {
        public string nomeDoAluno;
        public string curso;
        public int numeroMatricula;
        public string situacao;
        public string dataInicial;

        //metodo
        public void ExibirCaracteristicas()
        {
            Console.WriteLine($"Característica da Matrícula: Nome do nomeDoAluno: { nomeDoAluno},Curso:  {curso}, Núm  da Matricula: { numeroMatricula},Situação: { situacao}, Data: { dataInicial}");
        }
    }
}
       