using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class Credencial
    {
        public String User { get; set; }
        public String Senha { get; set; }

        public Boolean AutenticarUser(string user, string senha)
        {
            return User == user && Senha == senha;
        }
    }
}
