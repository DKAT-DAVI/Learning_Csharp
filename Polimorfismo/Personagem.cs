using System;

namespace Polimorfismo
{
    public class Personagem
    {
        public String Nome { get; set; }

        public virtual String Agir()
        {
            return $"Meu nome é {Nome} e eu sou o Personagem. ";
        }

        public virtual String Interagir()
        {
            return $"Estou disponível para jogar.";
        }

    }
}
