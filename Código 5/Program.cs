using System;

namespace Program
{
    public class Program{
        public static void Main(string[] args)
        {
            //Objeto aluno.
            Aluno aluno = new Aluno();

            //Erro pois o atributo é readOnly.
            //aluno.Nome = "Davi";

            //Exibindo o Nome para o construtor padrão.
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Idade: {aluno.Idade}");

            Aluno aluno1 = new("Davi", 16);
            //Exibindo o Nome para o construtor sobrecarregado.
            Console.WriteLine($"Nome: {aluno1.Nome}");
            Console.WriteLine($"Idade: {aluno1.Idade}");
        }
    }
}
