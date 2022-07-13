using System;

public class Ponto
{
    //Atributos que recebem os valores de X e Y.
    public Single X { get; set; }
    public Single Y { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
