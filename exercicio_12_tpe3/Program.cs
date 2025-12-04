namespace tp3_Csharp
{
    public static class Exercicio12
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Exercício 12 ---");

            Circulo11 circulo = new Circulo11();
            circulo.Raio = 3.0;

            Esfera11 esfera = new Esfera11();
            esfera.Raio = 5.0;

            Console.WriteLine($"Área do círculo (raio 3.0): {circulo.CalcularArea()}");
            Console.WriteLine($"Volume da esfera (raio 5.0): {esfera.CalcularVolume()}");
        }
    }
}
