using System;

/*Classe que faz uma multiplicação 
entr dois números.*/
public class Multiplicacao
{
    //Atributo ValorA.
    /*Rebeo primeiro número para
    fazer a multiplicação.*/
    public Double ValorA { get; set; }

    //Atributo ValorB.
    /*Recebe o segundo número para
    fazer a multiplicação.*/
    public Double ValorB { get; set; }

    //Método operar.
    /*Faz a operação para 
    multiplicar os dois valores.*/
    public Double Operar()
    {
        return ValorA * ValorB;
    }

    //Formatação para exibição.
    public override String ToString()
    {
        return $"Objeto: Multiplicação\nToString();\nValor A = {ValorA.ToString("0.0")}\nValor B = {ValorB.ToString("0.0")}\nMultiplicação = {Operar().ToString("0.00")}\n";
    }
}
