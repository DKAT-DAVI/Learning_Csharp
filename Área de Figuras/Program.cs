using System;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definindo objeto Quadrado.
            Quadrado lado = new Quadrado();

            //Inserindo valor para o lado do Quadrado.
            lado.lado = 7;
            Console.WriteLine($"Quadrado de lado: {lado.lado}");

            //Calculando ára do quadrado.
            Console.WriteLine($"Quadrado de área: {lado.CaulcularAreaQuadrado()}");

            Console.WriteLine();

            //Definindo objeto Circulo.
            Circulo raio = new Circulo();

            //Inserindo valor para o raio do circulo.
            raio.raio = 2;
            Console.WriteLine($"Círculo de raio: {raio.raio}");

            //Calculando a área do Circulo.
            Console.WriteLine($"Círculo de área: {raio.CalcularAreaCirculo().ToString("N2")}");
        }
    }
}
