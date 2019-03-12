using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_final
{
    public class Armadura
    {
        protected int proteccion;

        public Armadura()
        {
            proteccion = 15;
        }

        public Armadura(int p)
        {
            proteccion = p;
        }
        ~Armadura() { }

        public virtual int Proteccion
        {
            get
            { return proteccion; }
        }
 
    }

    public class Liviana : Armadura
    {
        public Liviana() : base() { proteccion = 5; }
        ~Liviana() { }
        public override int Proteccion => base.Proteccion;
    }

    public class Caballero
    {
        //CONSTRUCTORES Y DESTRUCTOR
        public Caballero() { salud = 100; }
        public Caballero(uint s)
        {
            salud = s;
        }
        ~Caballero() { Console.WriteLine("Caballero eliminado"); }

        //METODOS
        public virtual void Atacar(uint s, Caballero enemigo)
        {
            enemigo.RecibirDanio(s);
        }
       
        public void RecibirDanio(uint s)
        {
            salud -= s;
        }
        public void Morir()
        {
            salud =0;
        }
        public uint Salud
        {
            get
                { return salud; }
        }

        //PROPIEDADES
        protected uint salud;
        protected Armadura armor;
    }

    class Program
    {
        static void Main(string[] args)
        {
            uint atqCaballero;//2d4
            uint turno, atacante, defensor;

            Caballero[] Bando1 = new Caballero[30];
            Caballero[] Bando2 = new Caballero[30];

            for (int i = 0; i < 30; i++)
            {
                Bando1[i] = new Caballero();
                Bando2[i] = new Caballero(80);
            }

            Bandos_Listar(Bando1,Bando2);

            int tam1 = Bando1.Length;
            int tam2 = Bando2.Length;

            while (tam1 !=0 && tam2 !=0)
             {
                 turno = (uint)calcTirada(1, 2);
                 Random rnd2 = new Random();
                 Console.WriteLine("Tamaño 1: " + tam1 + "\nTamaño 2: " + tam2+ "\n\n");

                if(turno ==1) //ATACA EL BANDO 1
                {
                    Console.WriteLine("Ataca el bando 1");
                    atacante = (uint)rnd2.Next(0,30); //SE ELIGE AL AZAR QUE GUERRERO ATACA
                    defensor = (uint)rnd2.Next(0, 30);//SE ELIGE AL AZAR QUE GUERRERO DEFIENDE

                    while (Bando2[defensor].Salud == 0)//VERIFICO QUE EL DEFENSOR ESTE VIVO PARA NO ATACAR A LOS MUERTOS
                    {
                        defensor = (uint)rnd2.Next(0, 30);
                    }

                    Console.WriteLine("El caballero " + atacante + " del bando 1 ataca al caballero " + defensor + " del bando 2");
                     atqCaballero = (uint)calcTirada(2, 40);
                     Console.WriteLine("Y le realiza " + atqCaballero + " puntos de daño");

                    if ( Bando2[defensor].Salud <= atqCaballero) // SI LA SALUD ES MENOR AL ATAQUE, MATO AL DEFENSOR
                    {
                         Bando2[defensor].Morir();
                        Console.WriteLine("El guerrero " + defensor + " del bando 2 murio");
                         tam2--;
                    }

                    if (Bando2[defensor].Salud != 0) // REALIZO EL ATAQUE, TUVE QUE VALIDAR PORQUE SINO SEGUIA ATACANDO AUNQUE ESTEN MUERTOS.
                     {
                        Bando1[atacante].Atacar(atqCaballero, Bando2[defensor]);
                    } 
       }
       else //ATACA EL BANDO 2
       {
           Console.WriteLine("Empieza el bando 2");
           atacante = (uint)rnd2.Next(0, 30);
           defensor = (uint)rnd2.Next(0, 30);

            while (Bando1[defensor].Salud == 0)
            {
                defensor = (uint)rnd2.Next(0, 30);
            }

           Console.WriteLine("El caballero " + atacante + " del bando 2 ataca al caballero " + defensor + " del bando 1");
           atqCaballero = (uint)calcTirada(2, 15);
           Console.WriteLine("Y le realiza " + atqCaballero + " puntos de daño");

            if (Bando1[defensor].Salud <= atqCaballero) // SI LA SALUD ES MENOR AL ATAQUE, MATO AL DEFENSOR
            {
                Bando1[defensor].Morir();
                Console.WriteLine("El guerrero " + defensor + " del bando 1 murio");
                tam1--;
            }

            if (Bando1[defensor].Salud != 0) // REALIZO EL ATAQUE, TUVE QUE VALIDAR PORQUE SINO SEGUIA ATACANDO AUNQUE ESTEN MUERTOS.
            {
                Bando2[atacante].Atacar(atqCaballero, Bando1[defensor]);
            }
       }
                Console.ReadKey();
                Console.Clear();

                Bandos_Listar(Bando1,Bando2);

                Console.ReadKey();
            }

            if(tam1>0)
            {
                Console.WriteLine("\n\n\t\t\tGANO EL BANDO 1");
            }
            else
            {
                Console.WriteLine("\n\n\t\t\tGano el bando 2");
            }

            Console.ReadKey();     
        }

        public static void Bandos_Listar(Caballero[] bando1, Caballero[] bando2)
        {
            Console.WriteLine("\tBando 1 \t\t\t Bando 2");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("\t" + "Caballero " + i + " Salud:" + bando1[i].Salud + "\t\t\tCaballero " + i + " Salud:" + bando2[i].Salud);
            }
        }

        public static int calcTirada(int m, int n)
        {
            Random rnd = new Random();
            int suma = 0;
            for (int i = 0; i < m; i++)
            {
                int dado = rnd.Next(1, n + 1);
                suma += dado;
            }
            return suma;
        }
    }
}
