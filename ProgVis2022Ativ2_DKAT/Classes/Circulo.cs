using System;

//Classe que calcula a área de um círculo.
public class Circulo
{
    /*Atributo Raio:
    Recebe o valor do raio do círculo.*/
    public Double Raio { get; set; }

    /*Método CalcularArea:
    Calcular a área do círculo
    através da medida do raio.*/
    public Double CalcularArea()
    {
        //Fórmula da área de um círculo: pi*raio².
        return Math.PI * Math.Pow(Raio, Raio);
    }

    /*Formatação da exibição, usando o
    método ToString.*/
    public override string ToString(){
        return $"Raio = {Raio.ToString("0.00")}\nÁrea = {CalcularArea().ToString("0.000")}";
    }
}
