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
            Circulo circulo = new Circulo();
            circulo.Raio = 2.0;
            Console.WriteLine(circulo);
        }
        private static void ProcessarQuestao4() {
            Cabecalho(4);
            Soma soma = new Soma();
            soma.ValorA = 2.5;
            soma.ValorB = -3.0;
            Console.WriteLine(soma);
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

            //Verificação da senha.
            Console.WriteLine($"Senha correta? {(cLuis.Autenticar("asdf123") ? "Sim":"Não")}");

        }
    }
}