using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Relacionamentos
            //Estabelecem conexões entre objetos.

            //Associação é uma conexão entre classes.
            //Ligação é uma conexão entre objetos.
            /*Multiplicidade indica a quantidade de 
            objetos de uma ponta que se liga a um único objeto da outra ponta.*/

            //Um-Para-Um Unidirecional.

            Discente d1 = new Discente();
            d1.Nome = "Davi";
            /*d1.FonePrincipal = new Telefone()
                { Ddd = 38, Numero = 999999999};*/

            Telefone t = new Telefone();
            t.Ddd = 38;
            t.Numero = 40028922;

            //Um-Para-Um Unidirecional.

            //Relações.
            d1.FonePrincipal = t;
            t.Discente = d1;
            
            Console.WriteLine(d1);
            Console.WriteLine();
            Console.WriteLine(t.Discente);
        }
    }
}
