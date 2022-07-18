using System;
using System.Collections.Generic;

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

            Console.WriteLine();

            Discente d2 = new Discente("Kalel");
            Discente d3 = new Discente("Pedro");
            
            //List<T>
            /*Lista fortemente tipada de objetos que podem
            ser acessados por meio de um índice.*/
            
            //List<data type> nomeDaVariavel = new List<data type>();
            List<Discente> turmaB = new List<Discente>();

            //Métodos.
            //Inserção de dados.
            //A Lista permite repetição de dados.
            turmaB.Add(d1);
            turmaB.Add(d2);
            turmaB.Add(d3);
            turmaB.Add(d3);
            turmaB.Add(new Discente() {Nome = "Matheus"});

            //Busca de dados.
            bool contem = turmaB.Contains(d3);
            Console.WriteLine(contem);

            //Retorna índice do objeto especificado.
            int indice = turmaB.IndexOf(d3);
            Console.WriteLine(indice);

            //Remover dado.
            turmaB.Remove(d1);

            //Remover dado em posição especificada.
            turmaB.RemoveAt(1);

            //Inserir dado em posição especificada.
            turmaB.Insert(1, d3);

            //Ordenar lista.
            //turmaB.Sort();

            //Limpar lista.
            turmaB.Clear();

            foreach(Discente nome in turmaB)
            {
                Console.WriteLine($"Discente: {nome.Nome}");
            }
        }
    }
}
