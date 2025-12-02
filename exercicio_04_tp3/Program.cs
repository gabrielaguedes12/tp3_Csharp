using System;

namespace tp3_Csharp
{
    public static class Exercicio4
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 4 ---");

            //objeto
            Ingresso4 ingresso = new Ingresso4();

            //atributos iniciais
            ingresso.nomeDoShow = "Terno Rei";
            ingresso.preco = 25.00;
            ingresso.quantDisponivel = 150;

            //alterações
            ingresso.AlterarPreco(40.00);
            ingresso.AlterarQuantidade(90);

            //exibir informações atualizadas
            ingresso.ExibirInformacoes();
        }
    }

    public class Ingresso4
    {
        public string nomeDoShow;
        public double preco;
        public int quantDisponivel;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nShow: {nomeDoShow}");
            Console.WriteLine($"Preço: R${preco}");
            Console.WriteLine($"Quantidade disponível: {quantDisponivel}");
        }

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
            Console.WriteLine("Preço alterado");
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantDisponivel = novaQuantidade;
            Console.WriteLine("Quantidade alterada");
        }
    }
}
