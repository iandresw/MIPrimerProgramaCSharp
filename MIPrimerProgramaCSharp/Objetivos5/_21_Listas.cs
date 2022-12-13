using System;
using System.Collections.Generic;

namespace MIPrimerProgramaCSharp.Objetivos5
{
    class _21_Listas
    {
        static void Main(string[] args)
        {
            List<int> listaEnteros = new List<int> { 1,2,3,4,5};
            Console.WriteLine(listaEnteros[0]);
            Console.WriteLine(listaEnteros[1]);
            Console.WriteLine(listaEnteros[2]);
            Console.WriteLine(listaEnteros[3]);

            IList<string> listaCadena = new List<string> { "Hola", "¿Que tal?", "Estoy Aprendiendo" };
            Console.WriteLine(listaCadena[0]);
            Console.WriteLine(listaCadena[1]);
            Console.WriteLine(listaCadena[2]);
            Console.ReadLine();

        }
    }
}
