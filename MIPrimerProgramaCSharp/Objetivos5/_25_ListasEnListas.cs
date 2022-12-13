using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos5
{
    class _25_ListasEnListas
    {
        static void Main(String [] args)
        {
            List<List<int>> listaDeListas = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 10, 11, 12, 13 } };
            Console.WriteLine("Numero de elementos en la lista: " + listaDeListas.Count);
            Console.WriteLine("Numero de elementos en la primera lista: " + listaDeListas[0].Count);
            Console.WriteLine("Elementos de la la primera lista: " + listaDeListas[0][0] + " " + listaDeListas[0][1] + " " + listaDeListas[0][2]);
            Console.WriteLine("Numero de elementos en la segunda lista: " + listaDeListas[1].Count);
            Console.WriteLine("Elementos de la la segunda lista: " + listaDeListas[1][0] + " " + listaDeListas[1][1] + " " + listaDeListas[1][2] + " " + listaDeListas[1][3]);
            listaDeListas[0].Add(4);
            Console.WriteLine();
            listaDeListas[1].RemoveAt(0);
            Console.WriteLine("Numero de elementos en la primera lista modificada: " + listaDeListas[0].Count);
            Console.WriteLine("Elementos de la la primera lista modificada " + listaDeListas[0][0] + " " + listaDeListas[0][1] + " " + listaDeListas[0][2] + " " + listaDeListas[0][3]);
            Console.WriteLine();
            Console.WriteLine("Numero de elementos en la segunda lista: " + listaDeListas[1].Count);
            Console.WriteLine("Elementos de la la segunda lista modificada: " + listaDeListas[1][0] + " " + listaDeListas[1][1] + " " + listaDeListas[1][2]);

            Console.ReadLine();
        }
    }
}
