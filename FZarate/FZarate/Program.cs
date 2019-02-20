using System;

namespace FZarate
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) TiString() Para pasar a cadena.
            /*int b = 20;
            char a = 'Z';
            Console.WriteLine(a.ToString() + " " + b.ToString());*/

            //2)FLUJO DE ENTRADA Y SALIDA
            /*Console.WriteLine("EScriba un numero: "); //PIDO EL NUMERO
            string numeroStr = Console.ReadLine(); //CREO UNA VARIABLE TIPO STRING Y GUARDO EL NUMERO AHI
            Console.WriteLine("El numero es " + numeroStr);*/


            //Calcular area (pi * r°2)  y circunferencia (pi * 2r) de un circulo cuyo radio se ingresa como dato
            /* Console.WriteLine("Escriba el radio: ");
             float r = float.Parse(Console.ReadLine()); //PARSEAR A FLOTANTE AL PEDIR EL DATO.
             // float pi = 3.1415f; //SIEMPRE LA F AL FINAL PARA REPRESENTAR FLOAT SINO LO TOMA COMO DOUBLE Y TIRA ERROR
             float pi = (float) Math.PI; // PI con casteo a float porque sino lo toma como double 
             float circunferencia = 2 * r * pi;
             float area = pi * r * r; 

             Console.WriteLine("La circunferencia es: " + circunferencia.ToString() + "\nEl area es : " + area.ToString()); //SIEMPRE TOSTRING() como buena practica*/

            //Calcule raices o soluciones para una ecuacion cuadratica (ax2 + bx + c = 0) El usuario ingresa a, b y c.
            Console.WriteLine("EScriba el numero A : ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("EScriba el numero B : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("EScriba el numero C : ");
            float c = float.Parse(Console.ReadLine());

            //float x1 = -b + Math.Sqrt(b * b + 4 * a * c) / 2 * a; separar en pasos
            //Console.WriteLine("X1 es : " + x1);
            // -b +- raiz b cuadrado + 4*a*c  / 2a

            Console.WriteLine("\nPresione Enter para cerrar el programa");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
