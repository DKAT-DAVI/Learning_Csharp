using System;
using System.Text;

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
                /*Usando o método Substring() para
                receber apenas o tamanho máximo para a senha.*/
                //O método Substring define o tamanho máximo para uma String.
                //Utilização do operador ternário.
                _senha = value.Substring(
                    0,
                    /*Se o comprimento da senha for menor 
                    do que 12, senha fica do tamanho que
                    está, senão apenas os 12 primeiros caracteres.*/
                    value.Length < 12 ? value.Length : 12);
            } 
        }
        
        //Atributo privado _gerador.
        private Random _gerador;
        
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

            /*Verificando se o valor a ser sacado
            é maior que o limite de saque.*/
            if (Saldo - valor < -(Limite))
            {
                throw new Exception("SAQUE NÃO PERMITIDO, VALOR MÁXIMO FOI EXCEDIDO!");
            }
                return Saldo -= valor;
        }

        //Método sugerirSenha.
        //Sugere uma senha randomizada.
        /*StringBuilder é um tipo mutável de strings.
        A cada vez que uma nova string é adicionada,
        ele quebra em char e armazena uma a um
        em um char interno.*/
        /*Método Next gera números aleatórios
        no intervalo definido.*/
        public String SugerirSenha(Byte comprimento){
            StringBuilder senhaAleatoria
                = new StringBuilder(comprimento);
            
            /*For que adiciona caracteres aleatórios
            na StringBuilder definida como senhaAleatoria,
            através do método Next com um intervalo de valores
            definidos usando a tabela ASCII. Gera um número
            aleatório que é armazenado em uma variável codigo,
            que depois é convertido para char(ToChar) e adicionado
            com o método Append na var senhaAleatória.*/
            //Para a variável i = 0, for menor que o comprimento da senha.
            for (var i = 0; i < comprimento; i++) {
                Int32 codigo = _gerador.Next(33, 126);
                senhaAleatoria.Append(Convert.ToChar(codigo));
            }
            
            /*Retorna a variável senhaAleatoria convertido
            para string de acordo com a tabela ASCII.*/ 
            return senhaAleatoria.ToString();
        }

        //Método IsSenhaValida.
        //Verifica se a senha está correta.
        /*Retorna a comparação da senha digitada
        com a _senha da conta e retorna um boleano.*/
        public Boolean IsSenhaValida(String senhaDigitada){
            return senhaDigitada == _senha;
        }

        //Contrutor padrão sem retornar nada.
        public ContaBancaria()
        {
            /*Número padrão da conta.
            Numero = 12345;
            //Saldo inicial da conta.
            Saldo = 0;*/
            //_gerador recebe um novo objeto do tipo Random.
            _gerador = new Random();
        }

        //Construtor sobrecarregado.
        /*Quando for preciso invocar um outro construtor
         coloca-se o : this() na frente do construtor.*/
        public ContaBancaria(Int32 numero, Decimal saldo) : this()
        {
            Numero = numero;
            Saldo = saldo;
            /*Objeto que inicia um novo objeto random.
            _gerador = new Random();*/
        }
    }
}