using System;
using Banco;

namespace Program 
{
    class Program
    {
        public static void Main(string[] args) {
            
            //Título.
            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"           Banco          ");
            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=");

            //Definição do objeto conta bancária
            ContaBancaria conta = new ContaBancaria();
            ContaBancaria conta1 = new ContaBancaria(55, 1000);

            //Número padrão da conta.
            Console.WriteLine($"Número padrão: {conta.Numero}");
            //Saldo inicial da conta.
            Console.WriteLine($"Saldo incial: {conta.Saldo}");

            Console.WriteLine();

            //Número da conta.
            Console.WriteLine($"Número da conta: {conta1.Numero}");
            //Saldo da conta.
            Console.WriteLine($"Saldo inserido: {conta1.Saldo}");

            Console.WriteLine();

            //Usando o método depositar.
            //Depósito no valor de 1000 reais.
            conta1.Valor = 1000;
            conta1.Depositar(conta1.Valor);
            //Exibindo valor do depósito.
            Console.WriteLine($"Depósito: R${conta1.Valor}");
            //Exibindo saldo após depósito.
            Console.WriteLine($"Saldo atual: {conta1.Saldo}");

            Console.WriteLine();

            //Usando o método sacar.
            //Saque no valor de 500 reais.
            conta1.Valor = 500;
            conta1.Sacar(conta1.Valor);
            //Exibindo valor do saque;
            Console.WriteLine($"Saque: R${conta1.Valor}");
            //Exibindo saldo após o saque.
            Console.WriteLine($"Saldo atual: {conta1.Saldo}");

        }
    }
}
