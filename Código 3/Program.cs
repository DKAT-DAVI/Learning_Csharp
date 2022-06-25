using System;

namespace Program
{
    internal class Program
    {
        public static void Main (string[] args)
        {
            //Definindo objeto aluno.
            Aluno aluno1 = new Aluno();

            //Iserindo nome para aluno.
            aluno1.nome = "Davi";

            //Inserindo idade para aluno.
            aluno1.idade = 16;

            //Inserindo resultado de aprovação do aluno.
            aluno1.aprovado = true;

            //Exibindo nome e idade do aluno.
            Console.WriteLine($"Nome do aluno: {aluno1.nome}");
            Console.WriteLine($"Idade do aluno: {aluno1.idade}");
            Console.WriteLine($"Aprovado: {aluno1.aprovado}");

            Console.WriteLine();

            //Declarando ponto
            Ponto ponto = new Ponto();
            
            //Inserindo valores X e Y no ponto
            ponto.x = 25;
            ponto.y = 15;

            //Exibindo os valores dos pontos X e Y 
            System.Console.WriteLine($"Ponto X: {ponto.x}\nPonto Y: {ponto.y}");
        }
    }
}