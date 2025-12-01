using System;

namespace tp3_Csharp
{
    public static class Exercicio3
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 3 ---");
            //objeto
            Ingresso1 i1 = new Ingresso1();

            //atributos
            //nome do show- necessario para reconhecer 
            i1.nomeDoShow = "Terno Rei";
            //o valor é necessario em qualquer ingresso
            i1.preco = 25.00;
            //a quantidade deveria estar no banco de dados, porém é algo que pode ser bom para o comprador saber
            i1.quantDisponivel = 150;

            i1.ExibirDados();

            i1.AtualizarValor(35.00);
            i1.AtualizarQuantidade(80);

        }
    }
    //classe
    public class Ingresso1
    {
        public string nomeDoShow;
        public double preco;
        public int quantDisponivel;

        //metodo
        public void ExibirDados()
        {
            Console.WriteLine($"Dados do seu ingresso: {nomeDoShow}, Valor: {preco}, Ficou entre os {quantDisponivel} sortudos!");
        }

        public void AtualizarValor(double novoPreco)
        {
            preco = novoPreco;
            Console.WriteLine("Valor do segundo lote atualizado");
            ExibirDados();
        }
        public void AtualizarQuantidade(int novaQuantidade)
        {
            quantDisponivel = novaQuantidade;
            Console.WriteLine("Quantidade do segundo lote atualizado");
            ExibirDados();
        }
    }
}