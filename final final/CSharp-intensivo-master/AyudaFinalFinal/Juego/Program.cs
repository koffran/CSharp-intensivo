using System;
using System.Collections.Generic;

namespace Juego
{
    class Program
    {

        static void Main(string[] args)
        {
            Juego j = new Juego();
            j.Inicializar();
            j.Correr();
            Console.ReadKey();
        }
    }
}
