using System;

namespace tp3_Csharp
{
    public static class Exercicio2
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 2 ---");

            //objeto
            Ingresso2 i1 = new Ingresso2();

            //atributos
            //nome do show - necessário para reconhecer
            i1.nomeDoShow = "Terno Rei";

            //o valor é necessário em qualquer ingresso
            i1.preco = 25.00;

            //a quantidade deveria estar no banco de dados, porém é algo que pode ser bom para o comprador saber
            i1.quantDisponivel = 150;

            i1.exibirDados();
        }
    }

    //classe
    public class Ingresso2
    {
        public string nomeDoShow;
        public double preco;
        public int quantDisponivel;

        //metodo
        public void exibirDados()
        {
            Console.WriteLine($"Dados do seu ingresso: {nomeDoShow}, Valor: {preco}, Ficou entre os {quantDisponivel} sortudos!");
        }
    }
}
