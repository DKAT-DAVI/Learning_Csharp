using System;

namespace Polimorfismo
{
    public class Jogador : Personagem
    {
        public override String Agir()
        {
            return $"Sou o Jogador {Nome}. ";
        }

        public override string Interagir()
        {
            return $"Vamos iniciar a partida!";
        }
    }
}
