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
        private static void Cabeçalho(int numeroDaQuestao) {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"|      Resposta da Questão {numeroDaQuestao}      |");
            Console.WriteLine("-----------------------------------\n");
        }

        //Métodos para a resolução das questões.
        private static void ProcessarQuestao1() {
            
        }
        private static void ProcessarQuestao2() {
            
        }
        private static void ProcessarQuestao3() {
            
        }
        private static void ProcessarQuestao4() {
            Cabeçalho(4);
            Soma soma = new Soma();
            soma.ValorA = 2.5;
            soma.ValorB = -3.0;
            Console.WriteLine($"Objeto: Soma\nToString():\n{soma}");

        }
        private static void ProcessarQuestao5() {
            
        }
    }
}