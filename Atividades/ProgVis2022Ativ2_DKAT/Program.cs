using System;

namespace Program{
    class Program {
        public static void Main(string[] args) {
            //Invocação de todos os métodos de resolução das questões.
            ProcessarQuestao1();
            ProcessarQuestao2();
            ProcessarQuestao3();
            ProcessarQuestao4();
            ProcessarQuestao5();
        }
        
        //Método para exibição de cabeçalho da questão.
        private static void Cabecalho(int numeroDaQuestao) {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"|      Resposta da Questão {numeroDaQuestao}      |");
            Console.WriteLine("-----------------------------------\n");
        }

        //Métodos para a resolução das questões.
        private static void ProcessarQuestao1() {
            Cabecalho(1);
            Paciente paciente = new Paciente();
            paciente.Nome = "Beatriz Yana";
            paciente.Cns = 227683387130006;
            Console.WriteLine(paciente);
        }
        private static void ProcessarQuestao2() {
            Cabecalho(2);
            Eletrodomestico eletrodomestico = new Eletrodomestico();
            eletrodomestico.Codigo = 851796157395;
            eletrodomestico.Nome = "Refrigerador";
            eletrodomestico.Preco = 3253.12M;
            Console.WriteLine(eletrodomestico);
        }
        private static void ProcessarQuestao3() {
            Cabecalho(3);
            Circulo circulo = new Circulo() {Raio = 2.0};
            Console.WriteLine(circulo);

            Quadrado quadrado = new Quadrado() {Lado = 2.0};
            Console.WriteLine(quadrado);

            Retangulo retangulo = new Retangulo();
            retangulo.LadoA = 2.0;
            retangulo.LadoB = 3.0;
            Console.WriteLine(retangulo);

            Losango losango = new Losango();
            losango.DiagonalA = 2.0;
            losango.DiagonalB = 3.0;
            Console.WriteLine(losango);

        }
        private static void ProcessarQuestao4() {
            Cabecalho(4);
            Soma soma = new Soma();
            soma.ValorA = 2.5;
            soma.ValorB = -3.0;
            Console.WriteLine(soma);

            Subtracao subtracao = new Subtracao();
            subtracao.ValorA = 2.5;
            subtracao.ValorB = -3.0;
            Console.WriteLine(subtracao);

            Multiplicacao multiplicacao = new Multiplicacao();
            multiplicacao.ValorA = 2.5;
            multiplicacao.ValorB = -3.0;
            Console.WriteLine(multiplicacao);

            Divisao divisao = new Divisao();
            divisao.ValorA = 2.5;
            divisao.ValorB = -3.0;
            Console.WriteLine(divisao);
            
        }
        private static void ProcessarQuestao5() {
            Cabecalho(5);
            Usuario luis = new Usuario();
            luis.Nome = "Luis Guisso";
            luis.Email = "luis.guisso@ifnmg.edu.br";
            //luis.Nascimento recebe um novo objeto do tipo DateTime.
            luis.Nascimento = new DateTime(1982, 01, 01);

            Credencial cLuis = new Credencial();
            cLuis.Identificacao = "luis.guisso";
            cLuis.Senha = "asdf123";
            cLuis.Ativo = true;

            //Ligação entre os objetos.
            luis.credencial = cLuis;
            cLuis.usuario = luis;

            //Exibir os dados.
            Console.WriteLine(luis);

            //Teste de autenticação de senha.
            Console.WriteLine($"Senha correta? {(cLuis.Autenticar("asdf123") ? "Sim":"Não")}");
            Console.WriteLine($"Senha correta? {(cLuis.Autenticar("asdf12") ? "Sim":"Não")}");

        }
    }
}