using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp
{
    class _17_CadenaEqualEndStarWhit
    {
        static void Main(string[] args)
        {
            string cadena = "Hola";
            Console.WriteLine("La cadena es: "+ cadena);
            Console.WriteLine("¿Empieza por \"Ho\"?:" + cadena.StartsWith("Ho"));
            Console.WriteLine("¿Empieza por \"ho\"?:" + cadena.StartsWith("ho"));
            Console.WriteLine("¿Termina con \"la\"?:" + cadena.EndsWith("la"));
            Console.WriteLine("¿Termina con \"La\"?:" + cadena.EndsWith("La"));
            Console.WriteLine("¿Es igua a \"Hola\"?:" + cadena.Equals("Hola"));
            Console.ReadLine();
        }
    }
}
