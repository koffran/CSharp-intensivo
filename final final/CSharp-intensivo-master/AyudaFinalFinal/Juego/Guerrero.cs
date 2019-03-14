using System;
namespace Juego
{
    public abstract class Guerrero
    {
        public Guerrero(uint s, uint m, uint a)
        {
            salud = s;
            dadosMelee = m;
            dadosArmadura = a;
        }

        public void Turno(Guerrero b)
        {
            switch (rnd.Next(0,3))
            {
                case 0:
                    Atacar(b);
                    break;
                case 1:
                    Defender();
                    break;
                case 2:
                    CastearHechizo(b);
                    break;
            }
        }

        protected abstract void Atacar(Guerrero b);

        protected abstract void Defender();

        protected abstract void CastearHechizo(Guerrero b);

        // Ejemplo de como se puede realizar un ataque.
        // Ver si lo usan para atacar
        protected void AtaqueMelee(Guerrero b)
        {
            uint danio = TiradaNdM(2, 6);
            b.RecibirDanio(danio);
        }

        public bool EstaVivo()
        {
            return salud > 0;
        }

        public void RecibirDanio(uint danio)
        {
            uint armadura = TiradaNdM(dadosArmadura, 4);
            if (armadura >= danio)
                return;
            if (salud < danio)
                salud = 0;
            else
                salud -= danio;
        }

        protected uint TiradaNdM(uint n, uint m)
        {
            uint sum = 0;
            for (int t=0; t < n; ++t)
            {
                sum += (uint)rnd.Next(1, (int)m + 1);
            }
            return sum;
        }

        protected Random rnd = new Random();
        protected uint salud;
        protected uint dadosMelee;
        protected uint dadosArmadura;
    }
}
