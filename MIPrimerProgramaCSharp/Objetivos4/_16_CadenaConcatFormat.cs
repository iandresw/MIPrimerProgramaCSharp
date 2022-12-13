using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos4
{
    class _16_CadenaConcatFormat
    {
        static void Main(String[] args)
        {
            string cadena1 = "Hola es tiempo de programar";
            string cadena2 = "Esto es una cadena";
            string cadena3 = "Multilinea";

            string cadenaMultilineaV1 = string.Concat(cadena1, "\n", cadena2, "\n", cadena3);
            string cadenaMultilineaV2 = cadena1 + "\n" + cadena2 + "\n" + cadena3;
            Console.WriteLine(cadenaMultilineaV1);
            Console.WriteLine();
            Console.WriteLine(cadenaMultilineaV2);
            Console.WriteLine();
            string cadena4 = "La cadena tiene {0} lineas. \nLa primera la ha escrito {1}. \nLa segunda la ha escrito {2}.";
            string cadenaFinal = string.Format(cadena4, 5, "Alfredo", "Sheila");
            Console.WriteLine(cadenaFinal );
            Console.ReadLine();


        }
    }
}
