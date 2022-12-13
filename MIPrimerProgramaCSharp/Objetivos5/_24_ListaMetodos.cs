using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos5
{
    class _24_ListaMetodos
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 1,2,3,4,5};
            Console.WriteLine("Numero de elementos: "+ lista.Count  );
            Console.WriteLine("lista: "+lista[0]+" "+lista[1] + " " + lista[2] + " " + lista[3] + " " + lista[4]);
            Console.WriteLine("¿Contiene la lista el 3?: " + lista.Contains (3)) ;
            Console.WriteLine();
            lista.Remove(1);
            Console.WriteLine("Numero de elementos: " + lista.Count);
            Console.WriteLine("lista: " + lista[0] + " " + lista[1] + " " + lista[2] + " " + lista[3]);
            Console.WriteLine();
            lista.Add(3);
            Console.WriteLine("Numero de elementos: " + lista.Count);
            Console.WriteLine("lista: " + lista[0] + " " + lista[1] + " " + lista[2] + " " + lista[3] + " " + lista[4]);
            Console.WriteLine();
            lista.Remove(3);
            Console.WriteLine("Numero de elementos: " + lista.Count);
            Console.WriteLine("lista: " + lista[0] + " " + lista[1] + " " + lista[2] + " " + lista[3]);
            Console.WriteLine();
            lista.Clear();
            Console.WriteLine("Numero de elementos: " + lista.Count);
            Console.ReadLine();
        }
    }
}
