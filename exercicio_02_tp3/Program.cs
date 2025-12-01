namespace exercicio_02_tp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine($"Dados do seu ingresso:  {nomeDoShow}," +
                    $"Valor:  {preco}," +
                    $"Ficou entre os  { quantDisponivel} sortudos");
                }
        }
}