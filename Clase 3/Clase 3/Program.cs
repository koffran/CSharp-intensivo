using System;

namespace Clase_3
{
    class Program
    {

        /*En una pelea entre dos personajes en un juego de Rol uno golpea con un arma 2D6+3 y el
        otro tiene un escudo 2D4+1, el segundo personaje recibirá un daño igual a la diferencia del
        golpe del arma con la resistencia del escudo. Si esta resulta negativa o cero, no recibe ningún
        daño. Hacer un programa que haga las tiradas de los dados y muestre el daño infringido.
          */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int d4 = rnd.Next(1, 5), d6 = rnd.Next(1, 7);

            int ataque = 2 * d6 + 3;
            int defensa = 2 * d4 + 1;
            int resultado = ataque - defensa;

            int opcion = 0;
            Console.WriteLine("1- Daño en rol\n2- \n3- n ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (ataque > defensa)
                    {
                        Console.WriteLine("El ataque es: " + ataque.ToString());
                        Console.WriteLine("La defensa es: " + defensa.ToString());
                        Console.WriteLine("El primer personaje saca un " + d6.ToString() +
                                        "\nEl segundo personaje saca un " + d4.ToString() +
                                        "\nEl segundo personaje recibe " + resultado.ToString() + " puntos de daño");
                    }
                    else
                    {
                        Console.WriteLine("El ataque es: " + ataque.ToString());
                        Console.WriteLine("La defensa es: " + defensa.ToString());
                        Console.WriteLine("El primer personaje saca un " + d6.ToString() +
                                        "\nEl segundo personaje saca un " + d4.ToString() +
                                        "\nEl segundo personaje no recibe daño");
                    }
                    break;
                case 2:
                    break;
                case 3:

                    break;
                default:
                    Console.WriteLine("Ingresar una opcion correcta <1 - ?> ");
                    break;
            }

            Console.WriteLine("\n\nPresione <Escape> para salir del programa");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
