using System;

namespace Program
{
    class Program
    {
        public static void Main (string[] args)
        {
            //Definição de um novo objeto do tipo Aluno.
            Aluno aluno = new Aluno();

            //Receber o nomeAluno.
            aluno.SetNome("Davi Kalel");

            //Devolver o NomeAluno inserido.
            Console.WriteLine($"Nome do aluno: {aluno.GetNome()}");

            Aluno aluno2 = new Aluno();
            aluno2.SetNome("Pedro Isaque");
            Console.WriteLine($"Nome do aluno: {aluno2.GetNome()}");
        }
    }
}
