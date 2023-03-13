using System;

namespace Entidade
{
    public class PessoaJuridica:Pessoa
    {
        public UInt64 Cnpj { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome} \nCNPJ: {String.Format(@"{0:00 000 000/0000-00}",Cnpj)}";
        }
    }
}

