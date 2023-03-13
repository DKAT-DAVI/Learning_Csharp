using System;

namespace ControleAcesso
{
    public class Credencial
    {
        public String Usuario { get; set; }
        public String Senha { get; set; }
        public Boolean Ativo { get; set; }

        public Boolean Autenticar(String usuario, String senha)
        {
            return Usuario == usuario || Senha == senha;
        }
    }
}
