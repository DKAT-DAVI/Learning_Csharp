using System;
public class Circulo
{
    //Public get e set raio
    public Single raio { get; set; }

    //Método CalcularAreaCirculo
    public Double CalcularAreaCirculo()
    {
        return 2* Math.PI * raio;
    }
}
