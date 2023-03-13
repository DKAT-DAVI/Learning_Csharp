using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroTelefones
{
    internal class Telefone
    {
        public String Numero { get; set; }
        public TipoTelefone Tipo { get; set; }

        public Telefone() {}

        public Telefone(string numero, TipoTelefone tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return Numero + "[" + Tipo + "]";
        }
    }
}
