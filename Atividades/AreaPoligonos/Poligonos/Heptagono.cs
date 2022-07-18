using System;

public class Heptagono
{
    public Single Lado { get; set; }

    public Double CalcularAreaHeptagono()
    {
        return (3.634 * (Lado * Lado));
    }

    public override string ToString()
    {
        return $"Lado do Heptágono: {String.Format(@"{0:0.00}", Lado)}\nÁrea do Heptágono: {String.Format(@"{0:0.00}", CalcularAreaHeptagono())}\n";
    }
}
