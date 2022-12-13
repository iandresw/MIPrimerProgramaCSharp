using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos7
{
    class _35_BuclesDo
    {
        static void Main(string[] args)
        {
            int valor = 0;
            do
            {
                Console.WriteLine("Introduzca un numero mayor que 100 ");
                valor = Convert.ToInt32(Console.ReadLine());

            }
            while (valor <=100);
            Console.WriteLine("Finde del programa");
            Console.ReadLine();
        }
    }
}
