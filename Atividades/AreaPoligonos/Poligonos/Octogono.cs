using System;

public class Octogono
{
    public Single Lado { get; set; }

    public Double CalcularAreaOctogono()
    {
        return (2 * (1 + (Math.Sqrt(2))) * (Lado * Lado));
    }

    public override string ToString()
    {
        return $"Lado do Octógono: {String.Format(@"{0:0.00}", Lado)}\nÁrea do Octógono: {String.Format(@"{0:0.00}", CalcularAreaOctogono())}\n";
    }
}
