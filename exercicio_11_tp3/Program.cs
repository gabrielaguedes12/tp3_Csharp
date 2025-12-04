using System;

namespace tp3_Csharp
{
    public static class Exercicio11
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 11 ---");
            Console.WriteLine("Métodos de cálculo adicionados às classes Circulo e Esfera.");
        }
    }

    public class Circulo11
    {
        public double Raio;

        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
    }

    public class Esfera11
    {
        public double Raio;

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
        }
    }
}
