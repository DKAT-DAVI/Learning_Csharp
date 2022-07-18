using System;

//Classe que calcula a área de um quadrado através do lado.
public class Quadrado
{
    //Atributo Lado.
    public Double Lado { get; set; }

    //Método calcularArea.
    //Calcular a área do quadrado.
    public Double CalcularArea() 
    {
        return Lado * Lado;
    }

    //Formatação para exibição.
    public override string ToString()
    {
        return $"Objeto: Quadrado\nToString();\nLado = {Lado.ToString("0.00")}\nÁrea = {CalcularArea().ToString("0.00")}\n";
    }

}
