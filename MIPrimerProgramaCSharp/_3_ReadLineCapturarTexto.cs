using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp
{
    class _3_ReadLineCapturarTexto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Como te llamas?");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿Cuantos años tienes?");
            string edad = Console.ReadLine();
            Console.WriteLine("Te llamas "+nombre+" y tienes " + edad + " años");
            Console.WriteLine("Te llamas {0} y tienes {1} años", nombre, edad);
            Console.ReadLine();
        }
    }
}
