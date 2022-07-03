using System;

/*Classe que faz uma Divisao 
entr dois números.*/
public class Divisao
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
    dividir os dois valores.*/
    public Double Operar()
    {
        return ValorA / ValorB;
    }

    //Formatação para exibição.
    public override String ToString()
    {
        return $"Objeto: Divisão\nToString();\nValor A = {ValorA.ToString("0.0")}\nValor B = {ValorB.ToString("0.0")}\nDivisão = {Operar().ToString("0.0000000")}\n";
    }
}
