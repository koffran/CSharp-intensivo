using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_final
{
    public abstract class Hechizo
    {
        public Hechizo(uint c) { costo = c; }
        ~Hechizo() { }

        public abstract void Castear();
        public uint GetCosto() { return costo; }

        protected uint costo;
    }


    public class Fireball: Hechizo
    {
        public Fireball(uint d) : base(20)
        {
            danio = d;
        }
        ~Fireball() { }
        public override void Castear()
        {
            Console.WriteLine("Se lanza una bola de fuego al enemigo y realiza"+danio+ "Puntos de daño");
        }
        private uint danio;
    }

    public class Agua : Hechizo
    {
        public Agua(uint d) : base(15)
        {
            danio = d;
        }
        ~Agua() { }
        public override void Castear()
        {
            Console.WriteLine("Se lanza una magia de agua al enemigo y realiza" + danio + "Puntos de daño");
        }
        private uint danio;
    }
}

