using System;

namespace tp3_Csharp
{
    public static class Exercicio1
    {
        public static void Run()
        {
            //objeto
            Pessoa p1 = new Pessoa();

            //atributos
            p1.nome = "Maria Alice";
            p1.idade = 20;
            p1.altura = 1.70f;

            p1.exibirCaracteristicas();
        }
    }

    //classe
    public class Pessoa
    {
        public string nome;
        public int idade;
        public float altura;

        //metodo
        public void exibirCaracteristicas()
        {
            Console.WriteLine($"característica: {nome}, {idade} anos, {altura}m");
        }
    }
}