using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_final
{
    class Mago: Caballero
    {
        //CONSTRUCTORES Y DESTRUCTOR
        public Mago() : base() { salud = 60; dadosMelee = 8; dadosArmadura = 8; nombre = "Mago"; }
        public Mago(uint s, uint m, uint a, string n) : base(s, m, a, n)  { }
        ~Mago() { }

        //METODOS

        public virtual void Atacar(Caballero enemigo)
        {
            if(mana > 20)
            {
                CastearHechizo( rnd.Next(0, 2), enemigo)
            }
            else
            {
                Console.WriteLine("No hay mana suficiente, realiza ataque melee");
                uint Danio = TiradaNdM(dadosMelee, 5);
                enemigo.RecibirDanio(Danio);
            }

        }

        protected override void CastearHechizo(uint idx,Caballero b)
        {
            // Hacer
            if ((grimorio == null) ||
          (idx >= grimorio.Length) ||
          (grimorio[idx] == null))
                return;
            uint c = grimorio[idx].GetCosto();

            if (mana >= c)
            {
                mana -= c;
                grimorio[idx].Castear();
            }

        }

        public void InicializarHechizos()
        {
            grimorio[0] = new Fireball(30);
            grimorio[1] = new Agua(25);
        }


        //PROPIEDADES
        private uint mana = 30;
        protected uint costo;
        private Hechizo[] grimorio = new Hechizo[1];
        

    }
}
