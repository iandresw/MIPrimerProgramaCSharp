using System;


namespace MIPrimerProgramaCSharp.Objetivos3
{
   class _8_ModuloVariables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########## MODULO ###########");
            Console.WriteLine("Dividendo (Entero): ");
            int dividendo = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Divisor (Entero): ");
            int divisor = Convert.ToInt32(System.Console.ReadLine());
            int resultado1 = dividendo % divisor;
            Console.WriteLine("Resultado modulo (Entera):" + resultado1);
            Console.ReadLine();
        }
    }
}