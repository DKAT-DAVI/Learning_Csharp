using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Objeto Quadrado.
            Quadrado quadrado = new Quadrado() {Lado = 4};
            //Exibindo.
            Console.WriteLine(quadrado);

            //Objeto Circulo.
            Circulo circulo = new Circulo() {Raio = 2};
            //Exibindo.
            Console.WriteLine(circulo);

            //Objeto Pentagono.
            Pentagono pentagono = new Pentagono() {Lado = 5};
            //Exibindo.
            Console.WriteLine(pentagono);

            //Objeto Hexágono.
            Hexagono hexagono = new Hexagono() {Lado = 6};
            //Exibindo.
            Console.WriteLine(hexagono);

            //Objeto Heptágono.
            Heptagono heptagono = new Heptagono() {Lado = 7};
            //Exibindo.
            Console.WriteLine(heptagono);

            //Objeto Octógono.
            Octogono octogono = new Octogono() {Lado = 8};
            //Exibindo.
            Console.WriteLine(octogono);
        }
    }
}
