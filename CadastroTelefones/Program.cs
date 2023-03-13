using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroTelefones
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //TipoTelefone tipo1 = new TipoTelefone("Celular");
            //Telefone t1 = new Telefone("999970947", tipo1);
            //Telefone t2 = new Telefone("999647831", tipo1);

            //Pessoa pessoa = new Pessoa("DKAT");
            //pessoa.Telefones.Add(t1);
            //pessoa.Telefones.Add(t2);

            //Console.WriteLine($"{pessoa}");

        }
    }
}

