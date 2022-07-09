using System;

public class Quadrado
{
    //Definindo lado.
    public Single Lado { get; set; }

    //Definindo método CaulcularAreaQuadrado.
    public Single CalcularAreaQuadrado(){
        return Lado * Lado;
    }

    //Formatação.
    public override string ToString()
    {
        return $"Lado do Quadrado: {String.Format(@"{0:0.00}", Lado)}\nÁrea do Quadrado: {String.Format(@"{0:0.00}", CalcularAreaQuadrado())}\n";
    }
}
