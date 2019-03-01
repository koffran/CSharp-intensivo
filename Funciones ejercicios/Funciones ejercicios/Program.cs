using System;
//sceu.frba.edu.ar/diplovideojuegos

namespace Funciones_ejercicios
{
    class Program
    {
        public struct Player
        {
            public string nombre;
            public int vidas;
            public int clase;
        }

        static void Main(string[] args)
        {
            Player p;
            p.nombre = "Gandalf";
            p.vidas = 100;
            p.clase = 1;


            /* EJERCICIO 1
            Console.WriteLine("Ingrese la cantidad de veces a tirar el dado" );
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de caras del dado");
            int caras = int.Parse(Console.ReadLine());

            int dado = calcTirada(cantidad, caras);
            Console.WriteLine("El resultado es: " + dado);*/

            /*EJERCICIO 2
            Console.WriteLine("Ingrese el tamanio del arreglo aleatorio");
            int tam = int.Parse(Console.ReadLine());
            int[] arreglo = new int[tam];
            Random rnd = new Random();
            for(int i=0;i< tam; i++)
            {
                arreglo[i] = rnd.Next(0, 101);
            }
            Console.WriteLine("Los numeros son:");
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine(arreglo[i]);
            }


            int max=0, min=0;
            buscarExtremos(arreglo,out max,out min);
            Console.WriteLine("\n\tEl minimo es: " + min + "\n\tEl maximo es: " + max );*/

            /*EJERCICIO 3
            //Implemente un programa que inserte un elemento en la posición N de un arreglo. 
            int[] arreglo = new int[10];

            Random rnd = new Random();
            Console.WriteLine("Los numeros son:");
            for (int i = 0; i < 5; i++)
            {
                arreglo[i] = rnd.Next(0, 101);
                Console.WriteLine(arreglo[i]);
            }
            Insertar(arreglo, 5, 2, -3);
            Insertar(arreglo, 6, 2, -25);
            Insertar(arreglo, 7, 2, -10);
            Console.WriteLine("\nLos numeros nuevos son:");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(arreglo[i]);
            }*/




            Console.ReadKey();
        }



        public static void Insertar(int[] arreglo, int tam, int pos, int val)
        {
            for(int i= tam-1;i>=pos ;--i )
            {
                arreglo[i + 1] = arreglo[i];
            }
            arreglo[pos] = val;
        }
        
        public static void buscarExtremos(int[] arreglo,out int max, out int min)
        {
            if(arreglo.Length == 0)
            {
                max = 0;
                min = 0;
                return;
            }

            max = arreglo[0];
            min = arreglo[0];
            for(int i = 0;i< arreglo.Length;i++)
            {
                if(arreglo[i] > max)
                {
                    max = arreglo[i];
                }
                if (arreglo[i] < min)
                {
                    min = arreglo[i];
                }
            }
        }

        public static int calcTirada(int m, int n)
        {
            Random rnd = new Random();
            int suma = 0;
            for(int i = 0; i< m;i++)
            {
                int dado = rnd.Next(1, n + 1);
                Console.WriteLine("El dado es: " + dado.ToString());
                 suma += dado;
            }
            return suma;
        }
    }
}
