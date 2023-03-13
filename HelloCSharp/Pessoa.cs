using System;

namespace Entidade
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}";
        }
    }
}
