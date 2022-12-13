using System;
using System.Collections.Generic;


namespace MIPrimerProgramaCSharp.Objetivos6
{
    class _27_SentenciasIF
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero del 1 al 10: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            if (valor>10)
            {
                Console.WriteLine("el numero que has escrito es mayor que 10 ");
            }
            Console.WriteLine("Has escrito el numero {0} ", valor);
            Console.ReadLine();

        }
    }
}
