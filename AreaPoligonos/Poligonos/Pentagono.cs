using System;

public class Pentagono
{
    public Single Lado { get; set; }

    public Double CalcularAreaPentagono(){
        return (5 * (Lado * Lado)) / (4 * (Math.Sqrt(5-2*(Math.Sqrt(5)))));
    }

    public override string ToString()
    {
        return $"Lado do Pentágono: {String.Format(@"{0:0.00}", Lado)}\nÁrea do Pentágono: {String.Format(@"{0:0.00}", CalcularAreaPentagono())}\n";
    }
}
