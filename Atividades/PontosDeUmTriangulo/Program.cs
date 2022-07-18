using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*Declara-se 3 objetos do tipo ponto
        e insere-se os valores de X e Y*/
        Ponto p1 = new Ponto(){ X = 2, Y = 3 };

        Ponto p2 = new Ponto(){ X = 5, Y = 4 };

        Ponto p3 = new Ponto(){ X = 7, Y = 6 };

        //Declara-se um novo objeto do tipo Triângulo.
        Triangulo triangulo = new Triangulo();

        /*Usando os métodos insere-se cada
        um dos objetos em cada posição do triângulo.*/
        triangulo.SetPontoA(p1);
        triangulo.SetPontoB(p2);
        triangulo.SetPontoC(p3);

        Console.WriteLine(triangulo);
        
    }
}