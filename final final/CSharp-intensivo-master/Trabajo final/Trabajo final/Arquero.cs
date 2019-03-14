using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_final
{
    public class Arquero : Caballero
    {
        public Arquero() : base(80,8,8,"Arquero") { flechas = 8; }
        public Arquero(uint s,uint m,uint a, string n ) : base(s,m,a,n)
        {
            flechas = 8;
        }
        ~Arquero() { }

        public override void Atacar( Caballero enemigo)
        {
            if(flechas>0)
            {
                Console.WriteLine("Dispara una flecha al enemigo");
                uint Danio = TiradaNdM(dadosMelee, 14);
                enemigo.RecibirDanio(Danio);
                flechas--;
            }
            else
            {
                Console.WriteLine("No hay flechas, realiza ataque melee");
                uint Danio = TiradaNdM(dadosMelee, 10);
                enemigo.RecibirDanio(Danio);
            }         
        }
        private uint flechas;

    }
}
