using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Usuario
    {
        public String User { get; set; }

        public String Senha { get; set; }
        public Boolean Administrador { get; set; }
        public Boolean IsValido(String user, String senha)
        {
            return User == user && Senha == senha;
        }
    }
}
