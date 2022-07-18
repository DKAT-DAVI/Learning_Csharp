using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Discente d1 = new Discente();
            Discente d2 = new Discente();
            Discente d3 = new Discente();
            
            d1.Nome = "ALfredo";
            d2.Nome = "Bernardo";
            d3.Nome = "Carlos";
            
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine();

            //Classe Math.
            //Usada para operações matemáticas.

            //Número PI.
            Console.WriteLine(Math.PI);
            //Valor absoluto.
            Console.WriteLine(Math.Abs(-5));
            //Logaritimo de 10.
            Console.WriteLine(Math.Log10(100));
            //Número máximo.
            Console.WriteLine(Math.Max(1, 99));
            //Número mínimo.
            Console.WriteLine(Math.Min(1, 99));
            //Pontência.
            Console.WriteLine(Math.Pow(2, 10));
            //Raiz quadrada.
            Console.WriteLine(Math.Sqrt(9));
            //Seno.
            Double angulo = Math.PI * 30 /180.0;
            Console.WriteLine(Math.Sin(angulo));
            //Seno e Cosseno.
            Console.WriteLine(Math.SinCos(angulo));


        }
    }
}
