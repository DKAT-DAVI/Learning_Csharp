using System;

public class Hexagono
{
    public Single Lado { get; set; }

    public Double CalcularAreaHexagono()
    {
        return (3 * (Lado * Lado) * (Math.Sqrt(3))) / 2;
    }

    public override string ToString()
    {
        return $"Lado do Hexágono: {String.Format(@"{0:0.00}", Lado)}\nÁrea do Hexágono: {String.Format(@"{0:0.00}", CalcularAreaHexagono())}\n";
    }
}
