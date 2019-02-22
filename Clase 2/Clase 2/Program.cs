using System;

namespace Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lanzar dos dados, mostrar la tirada e informasr si son iguales o no y la suma de ambos
            int dado1, dado2, suma;

            Random rnd = new Random();
            dado1 = rnd.Next(1, 7);
            dado2 = rnd.Next(1, 7);

            Console.WriteLine("El dado 1 es: " + dado1.ToString() + "\nEl dado 2 es: " + dado2.ToString());
            
                if(dado1 == dado2)
            {
                Console.WriteLine("\nLos dados son iguales");
            }
                else
            {
                Console.WriteLine("\nLos dados son diferentes");
            }

            suma = dado1 + dado2;
            Console.WriteLine("\nLa suma entre los dados es: " + suma.ToString());

            Console.WriteLine("\n\nPresione <Enter> para salir del programa");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
