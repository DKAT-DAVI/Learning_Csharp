//Adicionando o pacote System
using System;

namespace Program
{
    //Nome da classe, delimitado por chaves
    internal class Program{
        //Public Método Main, estático, executa o que está dentro
        public static void Main (string[] args)
        {
            //Declarar Variáveis
            //int a, b, c;
            int a = 10, b = 20, c;
            float x = 10, y = 20; 
            //Atribuir valor para variável
            /*a = 10;
            b = 50;*/
            c = a + b;

            /*Método para imprimir valores
            Impressão simples*/
            Console.WriteLine("Hello Wolrd!!");
            //Impressão com concatenação
            Console.WriteLine("A vale " + a);
            //Impressão alternativa
            Console.WriteLine($"B vale {b}");
            Console.WriteLine($"A soma de {a} + {b} vale {c}");
            Console.WriteLine($"A subtração de {a} - {b} vale {a - b}");
            Console.WriteLine($"A multiplicação de {a} * {b} vale {a * b}");
            Console.WriteLine($"A divisão de {x} / {y} vale {x / y}");
            
        }
    }
}
