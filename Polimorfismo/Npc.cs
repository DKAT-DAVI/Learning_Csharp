using System;

namespace Polimorfismo
{
    public class Npc : Personagem
    {
        public override String Agir()
        {
            return $"Sou o {Nome}. ";
        }

        public override string Interagir()
        {
            return $"Vou te auxiliar nessa missão!";
        }
    }
}
