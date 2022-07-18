using System;
public class Circulo
{
    //Public get e set raio
    public Single Raio { get; set; }

    //Método CalcularAreaCirculo
    public Double CalcularAreaCirculo()
    {
        return 2* Math.PI * Raio;
    }

    //Formatação.
    public override string ToString()
    {
        return $"Raio do Círculo: {String.Format(@"{0:0.00}", Raio)}\nÁrea do Círculo: {String.Format(@"{0:0.00}", CalcularAreaCirculo())}\n";
    }
}
