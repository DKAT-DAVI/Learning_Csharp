using System;

/*Classe que calcula área de um 
losango através das suas diagonais.*/
public class Losango
{
    //Atributo DiaginalA.
    public Double DiagonalA { get; set; }

    //Atributo DiagonalB.
    public Double DiagonalB { get; set; }

    //Método CalcularArea.
    //Calcula a área do losango.
    public Double CalcularArea()
    {
        return (DiagonalA * DiagonalB) / 2;
    }

    //Formatação para a exibição.
    public override string ToString()
    {
        return $"Objeto: Losango\nToString();\nDiagonal A = {DiagonalA.ToString("0.00")}\nDiagonal B = {DiagonalB.ToString("0.00")}\nÁrea = {CalcularArea().ToString("0.00")}\n";
    }

}
