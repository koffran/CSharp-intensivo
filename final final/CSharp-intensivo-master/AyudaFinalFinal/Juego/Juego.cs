using System;
using System.Collections.Generic;

namespace Juego
{
    public class Juego
    {
        public void Inicializar()
        {
            LlenarBando(b1);
            LlenarBando(b2);
        }

        public void Correr()
        {
            while (!HayVencedor(b1, b2))
            {
                RondaAtaques(b1, b2);
                RondaAtaques(b2, b1);
            }

            bool muertoB1 = EstanTodosMuertos(b1);
            bool muertoB2 = EstanTodosMuertos(b2);
            if (muertoB1 && muertoB2)
            {
                Console.WriteLine("Empate!");
            }
            else
            {
                if (muertoB1)
                    Console.WriteLine("Gano bando 2");
                else
                    Console.WriteLine("Gano bando 1");
            }
        }

        private void LlenarBando(List<Guerrero> bando)
        {
            for (int i = 0; i < 30; ++i)
            {
                switch (rnd.Next(0, 2))
                {
                    case 0:
                        bando.Add(new Caballero());
                        break;
                    case 1:
                        bando.Add(new Mago());
                        break;
                }

            }
        }

        public void RondaAtaques(List<Guerrero> bAtaque,
            List<Guerrero> bDefensa)
        {
            for (int i = 0; i < bAtaque.Count; ++i)
            {
                Guerrero a = bAtaque[i];
                if (!a.EstaVivo())
                    continue;
                Guerrero b = null;
                for (int e = 0; e < bDefensa.Count; ++e)
                {
                    if (bDefensa[e].EstaVivo())
                    {
                        b = bDefensa[e];
                        break;
                    }
                }
                if (b != null)
                    a.Turno(b);
            }
        }

        private bool EstanTodosMuertos(List<Guerrero> bando)
        {
            bool todosMuertos = true;
            for (int i = 0; i < bando.Count; ++i)
            {
                if (bando[i].EstaVivo())
                {
                    todosMuertos = false;
                    break;
                }
            }
            return todosMuertos;
        }

        private bool HayVencedor(List<Guerrero> bando1,
            List<Guerrero> bando2)
        {
            return EstanTodosMuertos(bando1) || EstanTodosMuertos(bando2);
        }

        private List<Guerrero> b1 = new List<Guerrero>();
        private List<Guerrero> b2 = new List<Guerrero>();
        private Random rnd = new Random();
    }
}
