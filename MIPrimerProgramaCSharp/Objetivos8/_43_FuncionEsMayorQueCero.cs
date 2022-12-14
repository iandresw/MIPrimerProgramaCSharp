using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos8
{
    class _43_FuncionEsMayorQueCero
    {
        static void EsMayprQueCero(int valor)
        {
            
            if(valor > 0)
            {
                Console.WriteLine("El numero introducido es mayor que cero ");

            }
            else
            {
                Console.WriteLine("el numero introducido no es mayor que cero");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero ");
            int valorLeido = Convert.ToInt32(Console.ReadLine ());
            EsMayprQueCero(valorLeido);
            Console.ReadLine();
        }
    }
}
