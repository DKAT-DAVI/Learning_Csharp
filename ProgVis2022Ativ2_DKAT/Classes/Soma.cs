using System;

//Classe que faz uma soma de dois números
public class Soma
{
    //Atributos
    /*Atributo ValorA:
    Recebe o valor do primeiro número
    para efetuar a soma.*/
    public Double ValorA { get; set;}  

    /*Atributo ValorB:
    Recebe o valor do segundo número
    para efetuar a soma.*/
    public Double ValorB { get; set;}   

    /*Método Operar:
    Opera a soma retornando o resultado
    de ValorA + ValorB.*/
    public Double Operar()
    {
        return ValorA + ValorB;
    }

    /*Formatação da exibição, usando o
    método ToString.*/
    public override string ToString()
    {
        return $"Objeto: Soma\nToString();\nValor A = {ValorA.ToString("0.0")}\nValor B = {ValorB.ToString("0.0")}\nSoma = {Operar()}\n";
    }

}
