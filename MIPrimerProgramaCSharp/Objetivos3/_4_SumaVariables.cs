using System;

namespace MIPrimerProgramaCSharp.Objetivos3
{
    class _4_SumaVariables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########### SUMA DE ENTEROS ###########");
            Console.WriteLine("Primero sumando (Entero): ");
            int sumando1 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Segundo sumando (Entero): ");
            int sumando2 = Convert.ToInt32(System.Console.ReadLine());
            int resultado1 = sumando1 + sumando2;
            Console.WriteLine("Resultado suma (Entera):" + resultado1);
            Console.ReadLine();

            Console.WriteLine("########### SUMA REAL ###########");
            Console.WriteLine("Primero sumando (real): ");
            decimal sumando3 = Convert.ToDecimal(System.Console.ReadLine());
            Console.WriteLine("Segundo sumando (real): ");
            decimal sumando4 = Convert.ToDecimal(System.Console.ReadLine());
            decimal resultado2 = sumando3 + sumando4;
            Console.WriteLine("Resultado suma (real):" + resultado2);
            Console.ReadLine();

        }
    }
}
