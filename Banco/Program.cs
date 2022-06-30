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
            //Utilizando o construtor sobrecarregado que recebe o Int32 numero e Decimal saldo
            ContaBancaria conta1 = new ContaBancaria(55, 1000m);

            //Número da conta.
            Console.WriteLine($"Número da conta: {conta1.Numero}");
            //Senha sugerida.
            /*Método SugerirSenha que recebe como parâmetro o tamanho para a senha.*/
            Console.WriteLine($"Senha sugerida: {conta1.SugerirSenha(12)}");
            //Senha da conta.
            conta1.Senha = "012345678912345";
            //Saldo da conta.
            Console.WriteLine($"Saldo inicial: R${conta1.Saldo.ToString("0.00")}");

            Console.WriteLine();

            //Verificação da senha através do método IsSenhaValida.
            //Testando senha errado.
            Console.WriteLine($"Verificação de senha: {conta1.IsSenhaValida("40028922")}");
            //Testando senha certa.
            Console.WriteLine($"Verificação de senha: {conta1.IsSenhaValida("012345678912")}");

            //Expecificando o valor para limite de saque.
            conta1.Limite = 1000m;

            Console.WriteLine();

            //Usando o método depositar.
            //Depósito no valor de 1000 reais.
            conta1.Valor = 1000m;
            conta1.Depositar(conta1.Valor);
            //Exibindo valor do depósito.
            Console.WriteLine($"Depósito: R${conta1.Valor.ToString("0.00")}");
            //Exibindo saldo após depósito.
            Console.WriteLine($"Saldo atual: R${conta1.Saldo.ToString("0.00")}");

            Console.WriteLine();

            //Usando o método sacar.
            //Saque no valor de 500 reais.
            conta1.Valor = 500m;
            conta1.Sacar(conta1.Valor);
            //Exibindo valor do saque;
            Console.WriteLine($"Saque: R${conta1.Valor.ToString("0.00")}");
            //Exibindo saldo após o saque.
            Console.WriteLine($"Saldo atual: R${conta1.Saldo.ToString("0.00")}");

            Console.WriteLine();

            conta1.Valor = 1500m;
            conta1.Sacar(conta1.Valor);
            Console.WriteLine($"Saque: R${conta1.Valor.ToString("0.00")}");
            Console.WriteLine($"Saldo: R${conta1.Saldo.ToString("0.00")}");

            Console.WriteLine();

            //Testando disparo de throw
            conta1.Valor = 1100m;
            Console.WriteLine($"Saque: R${conta1.Valor.ToString("0.00")}");
            try {
                conta1.Sacar(conta1.Valor);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"Saldo: R${conta1.Saldo.ToString("0.00")}");
        }
    }
}
