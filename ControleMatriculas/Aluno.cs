using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMatriculas
{
    internal class Aluno
    {
        public String Nome { get; set; }

        public Aluno() {}

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
