using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos7
{
    class _33_BuclesWhile2
    {
        static void Main(string[] args)
        {
            int valor = 0;
            bool fin = false;
            while (!fin)
            {
                Console.WriteLine("Introduzca un numero mayor que 100: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor > 100)
                {
                    fin = true;
                    Console.WriteLine("siii");
                }
                else
                {
                    Console.WriteLine("El numero no es mayor que 100: ");
                }
            }
            Console.WriteLine("Find del programa");
            Console.ReadLine();
        }
    }
}
