using System;
using System.Collections.Generic;

          
namespace MIPrimerProgramaCSharp.Objetivos5
{
    class _23_ListasAddInsert
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 1, 2, 3 };
            Console.WriteLine("Tamaño de la lista"+ lista.Count);
            Console.WriteLine("Lista: "+ lista[0]+ " "+lista[1]+ " "+lista[2]);
            lista.Add(4);
            lista.Add(5);
            Console.WriteLine("Lista: " + lista[0] + " " + lista[1] + " " + lista[2] + " " + lista[3] + " " + lista[4]);
            lista.Insert(0, 0);
            lista.Insert(3,999);
            Console.WriteLine("Tamaño de la lista" + lista.Count);
            Console.WriteLine("Lista: " + lista[0] + " " + lista[1] + " " + lista[2] + " " + lista[3] + " " + lista[4] + " " + lista[5] + " " + lista[6]);
            Console.ReadLine();

        }
    }
}
