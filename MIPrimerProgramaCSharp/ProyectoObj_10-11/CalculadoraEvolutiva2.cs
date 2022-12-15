using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.ProyectoObj_10_11
{
    class CalculadoraEvolutiva2
    {
        static int LeerNumero(string texto)
        {
            bool leido = false;
            int valor = 0;
            while (!leido)
            {
                try
                {
                    Console.Write(texto);
                    valor = Convert.ToInt32(Console.ReadLine ());
                    leido = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: Tiene que introducir un numero.");
                }
            }
            return valor;
        }
        static void Suma()
        {
            Console.WriteLine("-----SUMA-----");
            int sumando1 = LeerNumero("Inserte el primer Sumando: ");
            int sumando2 = LeerNumero("Inserte el primer Sumando: ");
            int resultadoS = sumando1 + sumando2;
            Console.WriteLine("Resultado de la suma de {0} + {1} es igual a {2}", sumando1, sumando2, resultadoS);
        }
        static void Resta()
        {
            Console.WriteLine("-----RESTA-----");
            int minuendo = LeerNumero("Inserte el minuendo: ");
            int sustraendo = LeerNumero("Inserte el sustraendo: ");
            int resultadoR = minuendo - sustraendo;
            Console.WriteLine("Resultado de la Resta de {0} - {1} es igual a {2}", minuendo, sustraendo, resultadoR);
        }
        static void Multiplicacion()
        {
            Console.WriteLine("-----Multiplicación-----");
            int multiplicando1 = LeerNumero("Inserte el primer multiplicando: ");
            int multiplicando2 = LeerNumero("Inserte el segundo multiplicando: ");
            int resultadoM = multiplicando1 * multiplicando2;
            Console.WriteLine("Resultado de la Multiplicacion de {0} * {1} es igual a {2}", multiplicando1, multiplicando2, resultadoM);
        }
        static void Divicion()
        {
            Console.WriteLine("-----División-----");
            int divisior = LeerNumero("Inserte el dividendo: ");
            int cociente = LeerNumero("Inserte el divisor: ");

            try
            {
                int resultadoD = divisior / cociente;
                Console.WriteLine("Resultado de la Divición de {0} / {1} es igual a {2}", divisior, cociente, resultadoD);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("ERROR: {0}",ex.Message);
            }
        }
        static void Calculadora()
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
                opcion = LeerNumero("Opcion: ");
                switch (opcion)
                {
                    case 1:
                        Suma();
                        break;
                    case 2:
                        Resta();
                        break;
                    case 3:
                        Multiplicacion();
                        break;
                    case 4:
                        Divicion();
                        break;
                    case 5:
                        fin = true;
                        break;

                }
            }
            Console.WriteLine("****CALCULADORA APAGADA*****");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Calculadora();
        }
    }
}
