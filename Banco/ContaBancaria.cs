using System;

namespace Banco
{
    public class ContaBancaria
    {
        //Atributos.
        //Atributo Numero da conta.
        public Int32 Numero { get; set; }
        
        //Atributo Saldo da conta.
        public Decimal Saldo { get; set; }
        
        //Atributo Limite.
        public Decimal Limite { get; set; }
        
        //Propriedade privada que guarda a _senha.
        private String _senha;
        //Atributo Senha.
        //Com get e set personalizados.
        public String Senha { 
            //Retorna a senha.
            /*get {
                return _senha;

            }*/
            //Pode-se usar uma "seta" no lugar de {} para o get e set
            get => _senha;
            set {
                //Senha vai para a variável value.
                //Usando o método Substring() para receber apenas o tamanho máximo para a senha.
                //O método Substring define o tamanho máximo para uma String.
                //Utilização do operador ternário.
                _senha = value.Substring(
                    0,
                    //Se o comprimento da senha for menor do que 12, senha fica do tamanho que está, senão apenas os 12 primeiros caracteres.
                    value.Length < 12 ? value.Length : 12);
            } 
        }
        
        //Atributo Gerador.
        public Random Gerador { get; }

        //Atributo Valor.
        //Recebe um valor para deposito ou saque.
        public Decimal Valor { get; set; } 
        
        //Métodos.
        //Método Depositar.
        //Insere ao saldo o valor passado como parâmetro.
        public Decimal Depositar(Decimal valor){
            return Saldo += valor;
        }
        
        //Método Sacar.
        //Retira do saldo o valor passado como parâmetro.
        public Decimal Sacar(Decimal valor){

            //Verificando se o valor a ser sacado é maior que o limite de saque.
            if (Saldo - valor < -(Limite))
            {
                throw new Exception("SAQUE NÃO PERMITIDO, VALOR MÁXIMO FOI EXCEDIDO!");
            }
                return Saldo -= valor;
        }

        //Método sugerirSenha.
        //Sugere uma senha randomizada.
        public String SugerirSenha(Byte comprimeto){
            return "TESTE";
        }

        //Método isSenhaValida.
        //Verifica se a senha está correta.
        public Boolean IsSenhaValida(String senhaDigitada){
            return true;
        }

        //Contrutor padrão sem retornar nada.
        public ContaBancaria()
        {
            /*Número padrão da conta.
            Numero = 12345;
            //Saldo inicial da conta.
            Saldo = 0;*/
        }

        //Construtor sobrecarregado.
        public ContaBancaria(Int32 numero, Decimal saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
    }
}