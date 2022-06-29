using System;

namespace Banco
{
    public class ContaBancaria
    {
        //Atributo Numero da conta.
        public Int32 Numero { get; set; }
        
        //Atributo Saldo da conta.
        public Decimal Saldo { get; set; }
        
        //Atributo Limite.
        public Decimal Limite { get; set; }
        
        //Atributo Senha.
        public String Senha { get; set; }
        
        //Atributo Gerador.
        public Random Gerador { get; }

        //Atributo Valor.
        //Recebe um valor para deposito ou saque.
        public Decimal Valor { get; set; } 
        
        //Método Depositar.
        //Insere ao saldo o valor passado como parâmetro.
        public Decimal Depositar(Decimal valor){
            return Saldo += valor;
        }
        
        //Método Sacar.
        //Retira do saldo o valor passado como parâmetro.
        public Decimal Sacar(Decimal valor){
            return Saldo -= valor;
        }

        //Método sugerirSenha.
        //Sugere uma senha ramdomizada.
        public String sugerirSenha(Byte comprimeto){
            return "TESTE";
        }

        //Método isSenhaValida.
        //Verifica se a senha está correta.
        public Boolean isSenhaValida(String senhaDigitada){
            return true;
        }

        //Contrutor padrão.
        public ContaBancaria()
        {
            //Número padrão da conta.
            Numero = 12345;
            //Saldo inicial da conta.
            Saldo = 0;
        }

        //Construtor sobrecarregado.
        public ContaBancaria(Int32 numero, Decimal saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
    }
}