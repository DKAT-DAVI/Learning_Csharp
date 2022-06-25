using System;

namespace Program
{
    class Program
    {
        public static void Main (string[] args)
        {
            //Definição de um novo objeto do tipo Aluno.
            Aluno aluno = new Aluno();
            Aluno aluno2 = new Aluno();
            Aluno2 aluno3 = new Aluno2();
            Aluno2 aluno4 = new Aluno2();

            //Receber o nomeAluno.
            aluno.SetNome("Davi Kalel");
            aluno2.SetNome("Pedro Isaque");
            aluno3.Nome = ("Davi Kalel");
            aluno4.Nome = ("Pedro Isaque");

            //Devolver o NomeAluno inserido.
            Console.WriteLine($"Nome do aluno: {aluno.GetNome()}");
            Console.WriteLine($"Nome do aluno2: {aluno2.GetNome()}");
            Console.WriteLine($"Nome do aluno3: {aluno3.Nome}");
            Console.WriteLine($"Nome do aluno4: {aluno4.Nome}");

            //Numbers Float
            
            //Single ou float -> não é preciso.
            Console.WriteLine(".7f = {0:F5}", .7f);
            Console.WriteLine(".7f = {0:F35}", .7f);
            
            //Double_-> não é preciso, mais preciso que float.
            Console.WriteLine(".7d = {0:F35}", .7);

            //Decimal -> absolutamente preciso, consome mais memória e processamento.
            Console.WriteLine(".7m = {0:F35}", .7m);

            //Não preciso.
            Console.WriteLine("84.05d - 84.04d = {0:F35}", 84.05 - 84.04);
        }
    }
}
