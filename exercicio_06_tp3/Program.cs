using System;

namespace tp3_Csharp
{
    public static class Exercicio6
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 6 ---");

            //objeto usando construtor que já exige os valores iniciais
            Ingresso6 i1 = new Ingresso6("Terno Rei", 45.00, 20);

            i1.ExibirInformacoes();
        }
    }

    public class Ingresso6
    {
        public string nomeDoShow;
        public double preco;
        public int quantDisponivel;

        //construtor
        //obrigando quem cria o ingresso a já informar tudo
        public Ingresso6(string nomeDoShow, double preco, int quantDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantDisponivel = quantDisponivel;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nShow: {nomeDoShow}");
            Console.WriteLine($"Preço: R${preco}");
            Console.WriteLine($"Quantidade disponível: {quantDisponivel}");
        }
    }
}
