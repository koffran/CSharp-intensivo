using System;

namespace Clase_4_Arrays
{
    struct Enemigo
    {
        public int vida;
        public string nombre;
        public int danio;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //tipo[] nombre = new tipo[tamaño];
            /*int[] notas = new int[30];
            Random rnd = new Random();

            for(int i =0;i<30;i++)
            {
                notas[i] = rnd.Next(0, 11);
            }

            for(int i=0;i<30;i++)
            {
                Console.WriteLine(i + " "+ notas[i].ToString() );
            }
            */

            //ARREGLOS BIDIMENSIONALES
            // tipo nombre[m][n] filas / columnas
            /* Random rnd = new Random();
             int[,] notas = new int[3,30];

             for(int cursos=0; cursos<3;cursos++)
             {
                 for (int alumno = 0; alumno <30;alumno++)
                 {
                     notas[cursos, alumno] = rnd.Next(0, 11);
                 }
             }

             for (int cursos = 0; cursos < 3; cursos++)
             {
                 for (int alumno = 0; alumno < 30; alumno++)
                 {
                     Console.Write(notas[cursos, alumno]+" ");
                 }
                 Console.WriteLine();
             }*/

            //STRUCTS
            /*
             struct FichaAlumno 
             {
             public int dni;
             public string nombre;
             public string apellido;
             public int telefono;
             }
              */

            Enemigo[] e = new Enemigo[10]; // DECLARADA LA ESTRUCTURA ARRIBa
            for(int i=0;i<10;i++)
            {
                e[i].nombre = "jose" + i;
                e[i].vida = 100;
                Random rnd = new Random();
                e[i].danio = rnd.Next(3, 5);
            }


            for (int i = 0; i < 10; i++)
            {
              Console.WriteLine("Nombre: "+e[i].nombre+ "\nVida: "+ e[i].vida + "\nDanio: " + e[i].danio + "\n");  
            }
            

            Console.ReadKey();
        }
    }
}
