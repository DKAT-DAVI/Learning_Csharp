using System;


namespace Calculadora
{
    public class Calculator
    {
        public Double ValorA { get; set; }
        public Double ValorB { get; set; }

        #region Operações
        public Double Somar()
        {
            return ValorA + ValorB;
        }

        public Double Subtrair()
        {
            return ValorA - ValorB;
        }

        public Double Multiplicar()
        {
            return ValorA * ValorB;
        }

        public Double Dividir()
        {
            return ValorA / ValorB;
        }
        #endregion
    }
}
