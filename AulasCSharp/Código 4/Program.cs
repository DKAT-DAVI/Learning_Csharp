using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)        
        {
            //Obejeto para exibir construtor padrão.
            Aluno aluno = new Aluno();
            Console.WriteLine($"Nome: {aluno.Nome}");

            //Objeto para exibir construtor sobrecarregado.
            //O objeto recebe uma string para o nome.
            Aluno aluno2 = new Aluno("Davi");
            Console.WriteLine($"Nome1: {aluno2.Nome}");
        }
    }
}
