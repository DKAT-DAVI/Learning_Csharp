using System;

namespace Entidade
{
    public class PessoaFisica:Pessoa
    {
        public UInt64 Cpf { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome} \nCPF: {String.Format(@"{0:000 000 000-00}", Cpf)}";
        }
    }
}
