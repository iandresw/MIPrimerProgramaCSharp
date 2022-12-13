using System;

namespace MIPrimerProgramaCSharp.Objetivos3
{
    class _5_MultiplicacionVariables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########### MULTIPLICACION DE ENTERA ###########");
            Console.WriteLine("Primero mltiplicando (Entero): ");
            int multiplicando1 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Segundo multiplicando (Entero): ");
            int multiplicando2 = Convert.ToInt32(System.Console.ReadLine());
            int resultado1 = multiplicando1 * multiplicando2;
            Console.WriteLine("Resultado multiplicacion (Entera):" + resultado1);
            Console.ReadLine();

            Console.WriteLine("########### MULTIPLICACION REAL ###########");
            Console.WriteLine("Primero multiplicando (real): ");
            decimal multiplicando3 = Convert.ToDecimal(System.Console.ReadLine());
            Console.WriteLine("Segundo sumando (real): ");
            decimal multiplicando4 = Convert.ToDecimal(System.Console.ReadLine());
            decimal resultado2 = multiplicando3 * multiplicando4;
            Console.WriteLine("Resultado multiplicacion (real):" + resultado2);
            Console.ReadLine();

        }
    }
}