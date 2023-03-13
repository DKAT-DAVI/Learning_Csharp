using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroTelefones
{
    internal class Pessoa
    {
        public String Nome { get; set; }
        public List<Telefone> Telefones { get; set; }

        public Pessoa()
        { 
            Telefones = new List<Telefone>();
        }

        public Pessoa(String nome) : this()
        {
            Nome = nome;
        }

        public Pessoa(string nome, List<Telefone> telefones) : this(nome)
        {
            Telefones = telefones;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"->->-> {Nome} <-<-<- \n");

            foreach (Telefone tel in Telefones)
            {
                sb.AppendLine($"{tel}");
            }

            return sb.ToString();
        }
    }
}
