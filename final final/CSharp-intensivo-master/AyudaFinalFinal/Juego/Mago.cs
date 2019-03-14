using System;
namespace Juego
{
    public class Mago: Guerrero
    {
        public Mago(): base(60, 1, 2)
        {
        }

        protected override void Atacar(Guerrero b)
        {
            // Hacer
        }

        protected override void Defender()
        {
            // Hacer
        }

        protected override void CastearHechizo(Guerrero b)
        {
            // Hacer
        }

        private uint mana = 30;
    }
}
