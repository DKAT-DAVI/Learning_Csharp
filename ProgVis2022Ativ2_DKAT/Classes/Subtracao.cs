using System;

//Classe que faz uma subtração entre dois números.
public class Subtracao
{
    //Atributos
    /*Atributo ValorA:
    Recebe o valor do primeiro número
    para efetuar a subtração.*/
    public Double ValorA { get; set;}  

    /*Atributo ValorB:
    Recebe o valor do segundo número
    para efetuar a subtração.*/
    public Double ValorB { get; set;}   

    /*Método Operar:
    Opera a soma retornando o resultado
    de ValorA - ValorB.*/
    public Double Operar()
    {
        return ValorA - ValorB;
    }

    /*Formatação da exibição, usando o
    método ToString.*/
    public override string ToString()
    {
        return $"Objeto: Subtração\nToString();\nValor A = {ValorA.ToString("0.0")}\nValor B = {ValorB.ToString("0.0")}\nSubtração = {Operar()}\n";
    }

}
