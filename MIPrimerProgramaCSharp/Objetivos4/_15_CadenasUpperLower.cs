using System;

namespace MIPrimerProgramaCSharp.Objetivos4
{
    class _15_CadenasUpperLower
    {
        static void Main(String[] args)
        {
            string cadena = "en un lugar de la mancha";
            Console.WriteLine("Original: " + cadena);
            Console.WriteLine("Length: "+ cadena.Length);
            cadena = cadena.ToUpper();
            Console.WriteLine("ToUpper: "+ cadena);
            cadena = cadena.ToLower();
            Console.WriteLine("ToLower: " + cadena);
            Console.ReadLine();
        }
    }
}
