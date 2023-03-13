using System;

namespace Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem();
            p1.Nome = "Wanderson Rodrigues";
            //Console.WriteLine(p1.Agir());  

            Jogador j1 = new Jogador();
            j1.Nome = "Abóbora";
            //Console.WriteLine(j1.Agir());

            Inimigo i1 = new Inimigo();
            i1.Nome = "Carlos";
            //Console.WriteLine(i1.Agir());

            Npc npc1 = new Npc();
            npc1.Nome = "Eris";
            //Console.WriteLine(npc1.Agir());

            Personagem[] personagens = new Personagem[4];
            personagens[0] = p1;
            personagens[1] = j1;
            personagens[2] = i1;
            personagens[3] = npc1;

            for (int i = 0; i < personagens.Length; i++)
            {
                Console.WriteLine(personagens[i].Agir());
            }

            Console.WriteLine();

            foreach (Personagem p in personagens)
            {
                Console.WriteLine(p.Agir() + p.Interagir());
            }

            Console.ReadKey();
        }
    }
}
