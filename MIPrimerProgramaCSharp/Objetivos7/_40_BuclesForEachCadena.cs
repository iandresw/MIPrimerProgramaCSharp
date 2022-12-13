using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos7
{
    class _40_BuclesForEachCadena
    {
        static void Main(string[] args)
        {
            List<string> animales = new List<string> { "Perro", "Gato", "Caballo", "Pato" };
            foreach (string cadena in animales)
            {
                Console.WriteLine("Animal: {0} ", cadena);
            }
            Console.ReadLine();
        }
    }
}
