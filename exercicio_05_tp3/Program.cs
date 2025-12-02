using System;

namespace tp3_Csharp
{
    public static class Exercicio5
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 5 ---");

            //objeto usando construtor vazio
            Ingresso5 i1 = new Ingresso5();

            //definindo valores via setters
            i1.SetNomeDoShow("Terno Rei");
            i1.SetPreco(30.00);
            i1.SetQuantidadeDisponivel(120);

            //exibindo usando getters
            Console.WriteLine("\nInformações usando Getters:");
            Console.WriteLine($"Show: {i1.GetNomeDoShow()}");
            Console.WriteLine($"Preço: {i1.GetPreco()}");
            Console.WriteLine($"Quantidade disponível: {i1.GetQuantidadeDisponivel()}");

            //mudando valores novamente
            i1.SetPreco(40.00);
            i1.SetQuantidadeDisponivel(80);

            Console.WriteLine("\nApós alterações:");
            Console.WriteLine($"Show: {i1.GetNomeDoShow()}");
            Console.WriteLine($"Preço: {i1.GetPreco()}");
            Console.WriteLine($"Quantidade disponível: {i1.GetQuantidadeDisponivel()}");
        }
    }

    public class Ingresso5
    {
        public string nomeDoShow;
        public double preco;
        public int quantDisponivel;

        //getters
        public string GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public double GetPreco()
        {
            return preco;
        }

        public int GetQuantidadeDisponivel()
        {
            return quantDisponivel;
        }

        //setters
        public void SetNomeDoShow(string novoNome)
        {
            nomeDoShow = novoNome;
        }

        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void SetQuantidadeDisponivel(int novaQtd)
        {
            quantDisponivel = novaQtd;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nShow: {nomeDoShow}");
            Console.WriteLine($"Preço: R${preco}");
            Console.WriteLine($"Quantidade disponível: {quantDisponivel}");
        }
    }
}
