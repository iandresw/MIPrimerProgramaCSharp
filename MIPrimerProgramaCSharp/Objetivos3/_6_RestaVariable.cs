using System;

namespace MIPrimerProgramaCSharp.Objetivos3
{
    class _6_RestaVariable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########### RESTA DE ENTERA ###########");
            Console.WriteLine("minuendo (Entero): ");
            int minuendo1 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Sustraendo (Entero): ");
            int sustraendo1 = Convert.ToInt32(System.Console.ReadLine());
            int resultado1 = minuendo1 - sustraendo1;
            Console.WriteLine("Resultado resta (Entera):" + resultado1);
            Console.ReadLine();

            Console.WriteLine("########### RESTA REAL ###########");
            Console.WriteLine("minuendo (real): ");
            decimal minuendo2 = Convert.ToDecimal(System.Console.ReadLine());
            Console.WriteLine("Sustraendo (real): ");
            decimal sustraendo2 = Convert.ToDecimal(System.Console.ReadLine());
            decimal resultado2 = minuendo2 - sustraendo2;
            Console.WriteLine("Resultado resta (Real):" + resultado2);
            Console.ReadLine();

        }
    }
}