using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_final
{
    public class Caballero
    {
        //CONSTRUCTORES Y DESTRUCTOR
        public Caballero()
        {
            salud = 100;
            dadosMelee = 6;
            dadosArmadura = 10;
            nombre = "Caballero";
        }
        public Caballero(uint s,uint m, uint a, string n)
        {
            salud = s;
            dadosMelee = m;
            dadosArmadura = a;
            nombre = n;
        }
        ~Caballero() {}

        //METODOS
        public void Turno(Caballero b)
        {
            int flag=0;
            switch(rnd.Next(0,2))
            {
                case 0:
                    if(flag ==1)
                        dadosArmadura /= 2;
                    Atacar(b);
                    break;
                case 1:
                    if (flag == 1)
                        dadosArmadura /= 2;                    
                    Defender();
                    flag = 1;
                    break;
                /*case 2:
                    CastearHechizo(b);
                    break;*/
            }
        }

        public void Defender()
        {
            Console.WriteLine("El personaje se defiende por este turno");
            dadosArmadura *= 2;
        }

        protected virtual void CastearHechizo(uint idx,Caballero enemigo)
        {

        }

        public virtual void Atacar(Caballero enemigo)
        {
            uint Danio = TiradaNdM(dadosMelee,10);
            enemigo.RecibirDanio(Danio);
            
        }

        public void RecibirDanio(uint danio) //COMPARAR EL DANIO CON LA ARMADURA.VIRTUAL?
        {
            uint armadura = TiradaNdM(dadosArmadura, 4);
            if (armadura >= danio)
            {
                Console.WriteLine("El daño fue reflejado por la armadura");
                return;
            }        
            if (salud < danio)
            {
                Console.WriteLine("Recibe " + danio + " puntos de daño y muere");
                salud = 0;
            }
                
            else
            {
                Console.WriteLine("Recibe " + danio + " puntos de daño");
                salud -= danio;
            }
                

        }
        public void Morir()
        {
            salud = 0;
        }

        public bool EstaVivo()
        {
            return salud > 0;
        }

        public uint Salud
        {
            get
            { return salud; }
        }
        public string Nombre
        {
            get
            { return nombre; }
        }

        protected uint TiradaNdM(uint n, uint m)
        {
            uint sum = 0;
            for (int t = 0; t < n; ++t)
            {
                sum += (uint)rnd.Next(1, (int)m + 1);
            }
            return sum;
        }

        //PROPIEDADES
        protected uint salud;
        protected Random rnd = new Random();
        protected uint dadosMelee;
        protected uint dadosArmadura;
        protected string nombre ;
    }
}
