using System;
using System.Collections.Generic;

namespace MIPrimerProgramaCSharp.Objetivos7
{
    class _39_BuclesForEach
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach (int entero in numeros )
            {
                Console.WriteLine("Numero: {0}", entero); 
            }
            Console.ReadLine();
        }
    }
}
