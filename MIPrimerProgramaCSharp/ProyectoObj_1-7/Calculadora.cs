using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.ProyectoObj_1_7
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ C A L C U L A D O R A -----------");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicación");
            Console.WriteLine("4.- División");
            Console.WriteLine("5.- Salir");
            bool fin = false;
            int opcion = 0;
            while (!fin)
            {
                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("-----SUMA-----");
                        Console.Write("Inserte el primer sumando: ");
                        int sumando1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserte el segundo sumando: ");
                        int sumando2 = Convert.ToInt32(Console.ReadLine());
                        int resultadoS = sumando1 + sumando2;
                        Console.WriteLine("Resultado de la suma de {0} + {1} es igual a {2}",sumando1,sumando2,resultadoS);
                        break;
                    case 2:
                        Console.WriteLine("-----RESTA-----");
                        Console.Write("Inserte el Minuendo: ");
                        int minuendo= Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserte el Sustarendo: ");
                        int sustraendo = Convert.ToInt32(Console.ReadLine());
                        int resultadoR = minuendo - sustraendo;
                        Console.WriteLine("Resultado de la Resta de {0} - {1} es igual a {2}", minuendo, sustraendo, resultadoR);
                        break;
                    case 3:
                        Console.WriteLine("-----Multiplicación-----");
                        Console.Write("Inserte el Primer Multiplicando: ");
                        int multiplicando1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserte el segundo Multiplicando: ");
                        int multiplicando2 = Convert.ToInt32(Console.ReadLine());
                        int resultadoM = multiplicando1 * multiplicando2;
                        Console.WriteLine("Resultado de la Multiplicacion de {0} * {1} es igual a {2}", multiplicando1, multiplicando2, resultadoM);
                        break;
                    case 4:
                        Console.WriteLine("-----División-----");
                        Console.Write("Inserte el divisor: ");
                        int divisior = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserte el cosiente : ");
                        int cociente = Convert.ToInt32(Console.ReadLine());
                        int resultadoD = divisior / cociente;
                        Console.WriteLine("Resultado de la Divición de {0} / {1} es igual a {2}", divisior, cociente, resultadoD);
                        break;
                    case 5:
                        fin = true;
                        break;

                }
            }
            Console.WriteLine("****CALCULADORA APAGADA*****");
            Console.ReadLine();
        }
    }
}
