using System;

namespace tp3_Csharp
{
    public static class Exercicio10
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 10 ---");
            Console.WriteLine("Classes Circulo e Esfera definidas com atributo Raio.");
        }
    }

    public class Circulo
    {
        public double Raio;

        // O raio é fundamental porque é a medida usada
        // para todos os cálculos do círculo (área e perímetro).
    }

    public class Esfera
    {
        public double Raio;

        // O raio é essencial porque define todo o volume e área
        // superficial da esfera.
    }
}
