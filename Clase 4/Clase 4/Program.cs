using System;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos valores");
            int d1 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());

           // float p = promedio(d1, d2);
           
            Console.WriteLine("El promedio es: " + promedio(d1, d2));
            int div, resto;
            divResto(d1, d2, out div, out resto);
            Console.WriteLine("El dividendo es: " + div + "\nEl resto es: " + resto);
            Console.ReadKey();
        }

        public static float promedio(int a, int b)
        {
            float retorno = (a + b) / 2.0f;
            return retorno;
        }

        static public void divResto(int a, int b,
                                    out int div, out int resto)
        {
            div = a / b;
            resto = a % b;
        }

    }
}
