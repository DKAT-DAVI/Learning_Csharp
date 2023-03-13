using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Funcionário
    {
        public UInt64 Codigo { get; set; }
        public String Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Byte Idade { get; private set; }
        public Boolean Feminino { get; set; }
        public Boolean Ativo { get; set; }
        public Boolean Gerente { get; set; }

        public override string ToString()
        {
            return $"Teste";
        }
    }
}
