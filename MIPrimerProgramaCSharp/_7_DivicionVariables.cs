using System;


namespace MIPrimerProgramaCSharp
{
    class _7_DivicionVariables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########### DIVICION DE ENTERA ###########");
            Console.WriteLine("Dividendo (Entero): ");
            int dividendo1 = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Divisor (Entero): ");
            int divisor1 = Convert.ToInt32(System.Console.ReadLine());
            int resultado1 = dividendo1 / divisor1;
            Console.WriteLine("Resultado division (Entera):" + resultado1);
            Console.ReadLine();

            Console.WriteLine("########### DIVICION REAL ###########");
            Console.WriteLine("Dividendo (real): ");
            decimal dividendo2 = Convert.ToDecimal(System.Console.ReadLine());
            Console.WriteLine("Divisor (real): ");
            decimal divisor2 = Convert.ToDecimal(System.Console.ReadLine());
            decimal resultado2 = dividendo2 / divisor2;
            Console.WriteLine("Resultado division (real):" + resultado2);
            Console.ReadLine();

        }
    }
}