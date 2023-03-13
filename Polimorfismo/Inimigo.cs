using System;

namespace Polimorfismo
{
    public class Inimigo : Personagem
    {
        public override String Agir()
        {
            return $"Sou o {Nome}. ";
        }

        public override string Interagir()
        {
            return $"Quero te matar!";
        }
    }
}
