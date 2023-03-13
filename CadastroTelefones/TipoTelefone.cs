using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroTelefones
{
    internal class TipoTelefone
    {
        public String Tipo { get; set; }

        public TipoTelefone(){}

        public TipoTelefone(String tipo)
        {
            Tipo = tipo;
        }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
