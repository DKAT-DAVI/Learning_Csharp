using System;

//Classe que calcula a área de um retângulo através dos lados.
public class Retangulo
{
    //Atributo LadoA.
    public Double LadoA { get; set; }

    //Atributo LadoB
    public Double LadoB { get; set; }

    //Método calcularArea.
    //Calcular a área do quadrado.
    public Double CalcularArea() 
    {
        return LadoA * LadoB;
    }

    //Formatação para exibição.
    public override string ToString()
    {
        return $"Objeto: Retângulo\nToString();\nLado A = {LadoA.ToString("0.00")}\nLado B = {LadoA.ToString("0.00")}\nÁrea = {CalcularArea().ToString("0.00")}\n";
    }

}
