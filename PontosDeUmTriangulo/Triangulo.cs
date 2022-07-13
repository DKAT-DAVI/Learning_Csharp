using System;

public class Triangulo
{
    /*Propriedade pontos recebe um arranjo 
    do tipo Ponto com 3 valores.*/
    public Ponto[] pontos = new Ponto[3];

    //Cada método insere um valor em cada um dos 3 pontos.
    public void SetPontoA(Ponto pontoA){
        pontos[0] = pontoA;
    }
    public void SetPontoB(Ponto pontoB){
        pontos[1] = pontoB;
    }
    public void SetPontoC(Ponto pontoC){
        pontos[2] = pontoC;
    }

    public override string ToString()
    {
        return $"Ponto A: {pontos[0]}\nPonto B: {pontos[1]}\nPonto C: {pontos[2]}";
    }

}
