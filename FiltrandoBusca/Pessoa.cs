using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrandoBusca
{
    internal class Pessoa
    {
        public String Nome { get; set; }
        public UInt32 Matricula { get; set; }

        //public Pessoa()
        //{            
        //}

        //public Pessoa(String nome) : this()
        //{
        //    Nome = nome;
        //}

        public Pessoa(String nome, UInt32 matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override String ToString()
        {
            return $"{Nome} [ {Matricula} ]";
        }
    }
}
