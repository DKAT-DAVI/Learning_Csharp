using System;
using Entidade;

namespace HelloCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pf1 = new Pessoa();
            pf1.Nome = "Davi";
            Console.WriteLine(pf1);

            Console.WriteLine();

            PessoaFisica p2 = new PessoaFisica();
            p2.Nome = "Pedro";
            p2.Cpf = 18023948638;
            Console.WriteLine(p2);


            Console.WriteLine();

            PessoaJuridica pj1 = new PessoaJuridica();
            pj1.Nome = "Matheus";
            pj1.Cnpj = 88667567000145;
            Console.WriteLine(pj1);

            Console.ReadKey();
        }
    }
}
