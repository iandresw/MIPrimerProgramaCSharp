using System;
using System.Collections.Generic;


namespace MIPrimerProgramaCSharp.Objetivos5
{
    class _22_Listas2
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 1,2,3};
            Console.Write("Lista Origina: "+ lista[0] +" " + lista[1] + " " + lista[2] + "\n");
            lista[0] = 10;
            lista[1] = 11;
            lista[2] = 12;
            Console.Write("Lista Modificada: " + lista[0] + " " + lista[1] + " " + lista[2] + "\n");
            Console.ReadLine();
        }
    }
}
