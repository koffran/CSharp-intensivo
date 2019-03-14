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

        protected override void CastearHechizo(uint idx,Caballero b)
        {
            // Hacer
            if ((grimorio == null) ||
          (idx >= grimorio.Length) ||
          (grimorio[idx] == null))
                return;
            uint c = grimorio[idx].Costo;
            if (mana >= c)
            {
                mana -= c;
                grimorio[idx].Castear();
            }

        }

        //GETTER
        public uint Costo
        {
            get { return costo; }
        }

        private uint mana = 30;
        protected uint costo;
        private Hechizo[] grimorio;
    }
}
