using System;

namespace Program 
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Arranjos.
            //Definir o tipo de dado, nome da variável e fazer a atribuição.

            //Definição de 5 inteiros com valores padrão 0.
            int[] arr1 = new int[5];

            //Definição com atribuição de valores.
            //Inteiros.
            int[] arr2 = new int[] { 1, 2, 3, 5, 7 };
            //Booleanos.
            bool[] arr3 = new bool[]
                { false, false, true, false, false };
            //Strings.
            string[] arr4 = new string[]
                { "vermelho", "verde", "azul" };

            //Definição com objetos.
            /*Declaração da variável tipo Discente
            com 3 valores*/
            Discente[] turmaA = new Discente[3];

            /*Declarando o novo objeto define
            as propriedades e atribui ele para a posição 
            desejada no arranjo.*/
            Discente d1 = new Discente();
            d1.Nome = "Davi";
            turmaA[0] = d1;

            /*Através do construtor sobrecarregado já
            insere-se o objeto na posição desejada.*/
            turmaA[1] = new Discente("Kalel");

            /*Através do construtor padrão inserindo os
            parâmetros e atribuindo na posição desejada.*/
            turmaA[2] = new Discente() {Nome = "Pedro"};

            //For 
            //Usa-se o Length para definir o final do for.
            for(var i = 0; i < turmaA.Length; i++)
            {
                Console.WriteLine($"Discente {i}: {turmaA[i].Nome}");
            }

            Console.WriteLine();

            //Foreach
            //Para cada inteiro em números.
            foreach(Discente discente in turmaA) 
            {
                Console.WriteLine($"Discente: {discente.Nome}");
            }
        }
    }
}
