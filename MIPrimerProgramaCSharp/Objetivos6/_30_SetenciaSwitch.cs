using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPrimerProgramaCSharp.Objetivos6
{
    class _30_SetenciaSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigos Promocionales: ORO, PLATA, BRONCE ó PLATINO");
            Console.WriteLine("Introduzca su codigo promocional para saber su descuento: ");
            string codigo = Console.ReadLine();
            switch(codigo)
            {
                case "ORO":
                    Console.WriteLine("El descuentoaplicado es del 25% ");
                    break;
                case "PLATA":
                    Console.WriteLine("El descuentoaplicado es del 15% ");
                    break;
                case "BRONCE":
                    Console.WriteLine("El descuentoaplicado es del 5% ");
                    break;
                case "PLATINO":
                    Console.WriteLine("El descuentoaplicado es del 40% ");
                    break;
                default:
                    Console.WriteLine("Codigo promocional no valido ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
