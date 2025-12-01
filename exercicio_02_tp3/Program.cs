using System;
namespace tp3_Csharp
{
   public static class Exercicio2
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 2 ---");
            //objeto
            Ingresso i1 = new Ingresso();

            //atributos
            i1.nomeDoShow = "Terno Rei";
            i1.preco = 25.00;
            i1.quantDisponivel = 150;

            i1.exibirDados();
            
        }
    }
    //classe
    public class Ingresso
        {
            public string nomeDoShow;
            public double preco;
            public int quantDisponivel;

            public void exibirDados()
        {
            Console.WriteLine($"Dados do seu ingresso: {nomeDoShow}, Valor: {preco}, Ficou entre os {quantDisponivel} sortudos!");
        }
        }
}