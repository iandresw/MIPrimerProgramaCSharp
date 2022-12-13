using System;
using System.Collections.Generic;


namespace MIPrimerProgramaCSharp.Objetivos6
{
    class _28_SentenciaIfElse
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int> { 1, 5, 8, 9, 3 };
            Console.Write("Introduzca un numero del 1 al 10: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            if (valores.Contains (valor ))
            {
                Console.WriteLine("¡Valor encontrado en la lista de valores! ");
            } 
            else
            {
                Console.WriteLine("¡Valor NO encontrado en la lista de valores! ");
            }
            Console.ReadLine();

        }
    }
}
